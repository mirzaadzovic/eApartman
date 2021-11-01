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
    public class ApartmaniService:BaseCRUDService<Model.Apartman, Apartman, ApartmanUpsertRequest, ApartmanUpsertRequest, ApartmanSearchObject>
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
                set = set.Where(a => a.Adresa.Grad.Naziv.Contains(search.Grad));
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
                set=set.Include("Slikas");

            set=set.Include("ApartmanTip");

            if (search?.VlasnikId > 0)
                set = set.Where(a => a.VlasnikId == search.VlasnikId);

            if (!string.IsNullOrWhiteSpace(search.Naziv) && search.Naziv != "")
            {
                set = set.Where(a => a.Naziv.Contains(search.Naziv));
            }

            return set;
        }
    }
}
