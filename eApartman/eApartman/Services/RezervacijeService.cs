using AutoMapper;
using eApartman.Database;
using eApartman.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class RezervacijeService:BaseCRUDService<Model.Rezervacija, Rezervacija, RezervacijaInsertRequest, RezervacijaUpdateRequest, RezervacijaSearchObject>, IRezervacijeService
    {
        public RezervacijeService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {          
        }
        public override IEnumerable<Model.Rezervacija> Get(RezervacijaSearchObject search)
        {
            var set = _context.Set<Rezervacija>().AsQueryable();
            set=FiltirirajListu(set, search);
            
            return _mapper.Map<List<Model.Rezervacija>>(set);
        }

        private IQueryable<Rezervacija> FiltirirajListu(IQueryable<Rezervacija> set, RezervacijaSearchObject search)
        {
            if (search != null)
            {
                foreach (string item in search.IncludeList)
                {
                    set = set.Include(item);
                }
            }

            if (search?.VlasnikId > 0)
                set = set.Where(r => r.Apartman.VlasnikId == search.VlasnikId);
            if (search?.GostId > 0)
                set = set.Where(r => r.GostId == search.GostId).OrderBy(r=>r.Izvrsena).ThenBy(r=>r.DatumCheckIn);
            if (search?.ApartmanId > 0)
                set = set.Where(r => r.Apartman.ApartmanId == search.ApartmanId);
            if (!string.IsNullOrWhiteSpace(search.ApartmanNaziv))
                set = set.Where(r => r.Apartman.Naziv == search.ApartmanNaziv);
  
            if(search?.Datum.HasValue==true)
            {
                set = set.Where(r =>
                  r.Otkazana==search.Otkazana && 
                  r.DatumCheckIn.Date<=search.Datum.Value.Date && r.DatumCheckOut.Date>search.Datum.Value.Date
                );
            }
            return set;
        }

        public override Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            if (request.DatumCheckIn.Date < DateTime.Now.Date)
                return new Model.Rezervacija();

            var entity = _mapper.Map<Rezervacija>(request);

            entity.DatumRezervacije = DateTime.Now;
            entity.BrojDana = GetBrojDana(request);
            entity.Cijena = GetCijena(request);

            _context.Set<Rezervacija>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
        public override Model.Rezervacija Update(int id, RezervacijaUpdateRequest request)
        {
            var entity = _context.Set<Rezervacija>().Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
        public async Task UpdateStatus()
        {
            var set = _context
                .Set<Rezervacija>()
                .AsQueryable()
                .Where(r=>r.Otkazana==false)
                .Where(r => r.DatumCheckOut.Date == DateTime.Today.Date);
           
            await set.ForEachAsync(r => r.Izvrsena = true);

            _context.SaveChanges();
        }
        public int GetBrojDana(RezervacijaInsertRequest request)
        {
            var dana = request.DatumCheckOut - request.DatumCheckIn;
            return dana.Days;
        }
        public decimal GetCijena(RezervacijaInsertRequest request)
        {
            decimal cijena = _context.Set<Apartman>().Find(request.ApartmanId).Cijena;
            var dana = GetBrojDana(request);
            return cijena * dana;
        }
    }
}
