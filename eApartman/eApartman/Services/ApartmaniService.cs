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

            if (search != null)
            {
                set=FiltrirajListu(set, search);             
            }

            return _mapper.Map<List<Model.Apartman>>(set);
        }

        IQueryable<Apartman> GetSlobodniApartmani(IQueryable<Apartman> set, DateTime checkin, DateTime checkout)
        {
            if(checkin>=DateTime.Today && checkout > DateTime.Today)
            {
                var rezervacije = _context.Set<Rezervacija>()
                    .Where(r => r.DatumCheckIn >= checkin && r.DatumCheckIn < checkout)
                    .Select(r => r.ApartmanId)
                    .Distinct();
                    //.ToArray();

                set = set.Where(a => !rezervacije.Contains(a.ApartmanId));
            }

            return set;
        }

        IQueryable<Apartman> FiltrirajListu(IQueryable<Apartman> set, ApartmanSearchObject search)
        {
            set = GetSlobodniApartmani(set, search.CheckIn, search.CheckOut);

            if (search.IncludeRezervacije)
                set.Include("Rezervacijas.Gost");

            if (search.IncludeSlike)
                set.Include("Slikas");

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
