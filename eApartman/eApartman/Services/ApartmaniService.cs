using AutoMapper;
using eApartman.Database;
using eApartman.Model.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class ApartmaniService:BaseCRUDService<Model.Apartman, Apartman, ApartmanUpsertRequest, ApartmanUpsertRequest, ApartmanSearchObject>, IApartmaniService
    {
        public ApartmaniService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        public override IEnumerable<Model.Apartman> Get(ApartmanSearchObject search)
        {
            var set = _context.Set<Apartman>()
                .Include("Adresa.Grad.Drzava")
                .Include("Vlasnik")
                .AsQueryable();

            if (search != null) set=FiltrirajListu(set, search);

            return _mapper.Map<List<Model.Apartman>>(set);
        }
        public override Model.Apartman Update(int id, ApartmanUpsertRequest request)
        {
            var entity = _context.Set<Apartman>().Find(id);
            _mapper.Map(request, entity);
            _context.Entry(entity).Property(a=>a.VlasnikId).IsModified = false;
            _context.SaveChanges();
         

            return _mapper.Map<Model.Apartman>(entity);
        }

       public IQueryable<Apartman> GetSlobodniApartmani(IQueryable<Apartman> set, DateTime checkin, DateTime checkout)
        {
            if(checkin>=DateTime.Today && checkout > DateTime.Today)
            {
                var rezervacije = _context.Set<Rezervacija>()
                    .Where(r =>
                    (r.DatumCheckIn >= checkin && r.DatumCheckOut <= checkout)
                    ||
                    (r.DatumCheckIn <= checkin && r.DatumCheckOut >= checkout
                    &&
                    r.DatumCheckOut > checkin && r.DatumCheckIn < checkout)
                    ||
                    (r.DatumCheckIn <= checkin && r.DatumCheckOut <= checkout
                    && r.DatumCheckOut > checkin)
                    ||
                    (r.DatumCheckIn >= checkin && r.DatumCheckOut >= checkout
                    && r.DatumCheckIn < checkout))
                    .Where(r => r.Otkazana == false)                    
                    .Select(r => r.ApartmanId)
                    .Distinct();

                set = set.Where(a => !rezervacije.Contains(a.ApartmanId));
            }

            return set;
        }

        IQueryable<Apartman> FiltrirajListu(IQueryable<Apartman> set, ApartmanSearchObject search)
        {
            if (!string.IsNullOrWhiteSpace(search.Grad) && search.Grad != "")
            {
                set = set.Where(a => a.Adresa.Grad.Naziv.ToLower().Contains(search.Grad.ToLower())
                || a.Adresa.Grad.Drzava.Naziv.ToLower().Contains(search.Grad.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search.Tip) && search.Tip != "")
            {
                set = set.Where(a => a.ApartmanTip.ApartmanTipNaziv.Contains(search.Tip));
            }

            if (search.Osoba > 0)
                set = set.Where(a => a.MaxOsoba >= search.Osoba);

            if (search.Parking)
                set = set.Where(a => a.ImaParking);

            //Ima li slobodnih
            set = GetSlobodniApartmani(set, search.CheckIn, search.CheckOut);

            if (search?.IncludeRezervacije==true)
                set=set.Include("Rezervacijas.Gost");

            if (search?.IncludeSlike==true)
                set=set.Include("ApartmanSlikas");

            set=set.Include("ApartmanTip");

            if (search?.VlasnikId > 0)
                set = set.Where(a => a.VlasnikId == search.VlasnikId);

            if (!string.IsNullOrWhiteSpace(search.Naziv) && search.Naziv != "")
            {
                set = set.Where(a => a.Naziv.ToLower().Contains(search.Naziv.ToLower()));
            }

            return set;
        }
        private static MLContext mlContext = null;
        private static ITransformer model = null;
        
        public IEnumerable<Model.Apartman> Recommend(int korisnikId)
        {
            var rezervacija = _context.Rezervacijas
                .Where(r => r.GostId == korisnikId)
                .OrderByDescending(r => r.DatumRezervacije)
                .FirstOrDefault();
            if(rezervacija==null)
            {
                return new List<Model.Apartman>();
            }

            int apartmanId = (int)rezervacija.ApartmanId;
  

            if (mlContext == null)
            {
                mlContext = new MLContext();
                var tmpData = _context.Korisniks.Include("Rezervacijas")
                    .Where(k=>k.KorisnikId!=korisnikId && k.Rezervacijas.Count>0);
                var data = new List<ApartmanEntry>();
                
                foreach(var k in tmpData)
                {
                    var disctinctItemId = k.Rezervacijas.Select(r => r.ApartmanId).Distinct().ToList();
                    disctinctItemId.ForEach(a =>
                    {
                        var relatedItems = k.Rezervacijas.Where(x => x.ApartmanId != a);
                        foreach(var rItem in relatedItems)
                        {
                            data.Add(new ApartmanEntry() 
                            {
                                ApartmanID=(uint)a,
                                CoRentedApartmanID=(uint)rItem.ApartmanId
                            });
                        }
                    });
                }
                var trainData = mlContext.Data.LoadFromEnumerable(data);
                
                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ApartmanEntry.ApartmanID);
                options.MatrixRowIndexColumnName = nameof(ApartmanEntry.CoRentedApartmanID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                //options.K = 100;
                options.C = 0.00001;

                var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);
               
                model= est.Fit(trainData);

            }

            var allItems = _context.Apartmen.Include("Adresa.Grad").Include("ApartmanSlikas").Where(r=>r.ApartmanId!=apartmanId);

            var predictionResult = new List<Tuple<Apartman, float>>();

            foreach(var item in allItems)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ApartmanEntry, CoRented_prediction>(model);

                var prediction = predictionEngine.Predict(new ApartmanEntry()
                {
                    ApartmanID=(uint)apartmanId,
                    CoRentedApartmanID=(uint)item.ApartmanId
                });
                predictionResult.Add(new Tuple<Apartman, float>(item, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(pr => _mapper.Map<Model.Apartman>(pr.Item1)).Take(2).ToList();

            for(int i=0; i<finalResult.Count; i++)
            {
                finalResult[i].DatumSlobodan = GetPrviSlobodanDatum(finalResult[i]);
            }
            

            return finalResult;
        }
        public class CoRented_prediction
        {
            public float Score { get; set; }
        }

        public class ApartmanEntry
        {
            [KeyType(count: 31)]
            public uint ApartmanID { get; set; }

            [KeyType(count: 31)]
            public uint CoRentedApartmanID { get; set; }
            public float Label { get; set; }
        }

        public DateTime GetPrviSlobodanDatum(Model.Apartman apartman)
        {
            var rezervacije = _context.Rezervacijas
                .Where(r => r.ApartmanId == apartman.ApartmanId && r.DatumCheckIn.Date >= DateTime.Today.Date);

            DateTime datum=DateTime.Now.Date;
            var rezervacija = rezervacije.Where(r => r.DatumCheckIn.Date == datum).FirstOrDefault();
            while (rezervacija!=null)
            {             
                datum = datum.AddDays((int)rezervacija.BrojDana).Date;
                rezervacija = rezervacije.Where(r => r.DatumCheckIn.Date == datum).FirstOrDefault();
            }
            return datum;
        }

    }
}
