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
    public class GradService:BaseCRUDService<Model.Grad, Grad, GradUpsertRequest, GradUpsertRequest, GradSearchObject>
    {
        public GradService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        public override IEnumerable<Model.Grad> Get(GradSearchObject search)
        {
            var set = _context.Set<Grad>().AsQueryable();
            if (search != null)
            {
                if (!string.IsNullOrEmpty(search?.Naziv))
                {
                    set=set.Where(g => g.Naziv == search.Naziv);
                }
                if (search.IncludeDrzava)
                {
                    set=set.Include(g => g.Drzava);
                }
            }

            var entity = _mapper.Map<List<Model.Grad>>(set);
            
            return entity;
        }
        public override Model.Grad GetById(int id)
        {
            var set = _context.Set<Grad>()
                .Include(g => g.Drzava);

            var entity = set.Where(g => g.GradId == id).FirstOrDefault();

            return _mapper.Map<Model.Grad>(entity);
        }
    }
}
