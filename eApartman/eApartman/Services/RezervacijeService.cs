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
    public class RezervacijeService:BaseCRUDService<Model.Rezervacija, Rezervacija, RezervacijaInsertRequest, RezervacijaUpdateRequest, RezervacijaSearchObject>
    {
        public RezervacijeService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
            
        }
        public override IEnumerable<Model.Rezervacija> Get(RezervacijaSearchObject search)
        {
            var set = _context.Set<Rezervacija>().AsQueryable();
            if(search!=null)
            {
                foreach(string item in search.IncludeList)
                {
                    set = set.Include(item);
                }
            }
            if(search?.IncludeList.Contains("Apartman") == true)
            {
                if (search.VlasnikId > 0) 
                    set = set.Where(r => r.Apartman.VlasnikId == search.VlasnikId);
                if (search.ApartmanId > 0) 
                    set = set.Where(r => r.Apartman.ApartmanId == search.ApartmanId);
                if (string.IsNullOrWhiteSpace(search.ApartmanNaziv)) 
                    set = set.Where(r => r.Apartman.Naziv == search.ApartmanNaziv);
            }
            return _mapper.Map<List<Model.Rezervacija>>(set);
        }
        public override Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            var entity = _mapper.Map<Rezervacija>(request);
            entity.DatumRezervacije = DateTime.Now;
            _context.Set<Rezervacija>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
        public override Model.Rezervacija Update(int id, RezervacijaUpdateRequest request)
        {
            var entity = _context.Set<Rezervacija>().Find(request);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
    }
}
