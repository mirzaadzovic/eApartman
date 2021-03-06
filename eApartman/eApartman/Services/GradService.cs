using AutoMapper;
using eApartman.Database;
using eApartman.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            set = set.Include(g => g.Drzava);

            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                set =set.Where(g => g.Naziv.ToLower().Contains(search.Naziv.ToLower()));
            }
            if (!string.IsNullOrEmpty(search?.Drzava))
            {
                set = set.Where(g => g.Drzava.Naziv.ToLower().Contains(search.Drzava.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search?.Query))
            {
                set = set
                    .Where(g => 
                    g.Naziv.ToLower().Contains(search.Query.ToLower())
                    ||
                    g.Drzava.Naziv.ToLower().Contains(search.Query.ToLower()
                    ));
            }

            if (search?.DrzavaId>0)
            {
                set = set.Where(g => g.DrzavaId == search.DrzavaId);
            }
            

            var entity = _mapper.Map<List<Model.Grad>>(set.OrderBy(g=>g.Drzava.Naziv).ThenBy(g=>g.Naziv));
            
            return entity;
        }
        public override Model.Grad GetById(int id)
        {
            var set = _context.Set<Grad>()
                .Include(g => g.Drzava)
                .Include(g=>g.Adresas);

            var entity = set.Where(g => g.GradId == id).FirstOrDefault();

            return _mapper.Map<Model.Grad>(entity);
        }
    }
}
