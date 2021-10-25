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
    public class AdreseService:BaseCRUDService<Model.Adresa, Adresa, AdresaUpsertRequest, AdresaUpsertRequest, AdresaSearchObject>
    {
        public AdreseService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        public override IEnumerable<Model.Adresa> Get(AdresaSearchObject search)
        {
            var set = _context.Set<Adresa>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv)) 
                set = set.Where(a => a.Naziv == search.Naziv);

            if (search?.Broj>0) 
                set = set.Where(a => a.Broj == search.Broj);

            var entity = _mapper.Map <List<Model.Adresa>>(set);
            return entity;
        }
    }
}
