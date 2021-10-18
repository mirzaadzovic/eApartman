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
    public class AdreseService:BaseCRUDService<Model.Adresa, Adresa, AdresaUpsertRequest, AdresaUpsertRequest, object>
    {
        public AdreseService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        public override IEnumerable<Model.Adresa> Get(object search)
        {
            var set = _context.Set<Adresa>().AsQueryable();
            set = set.Include(a => a.Grad)
                .ThenInclude(g => g.Drzava);
            var entity = _mapper.Map <List<Model.Adresa>>(set);
            return entity;
        }
    }
}
