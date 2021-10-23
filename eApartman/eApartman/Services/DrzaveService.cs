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
    public class DrzaveService : BaseCRUDService<Model.Drzava, Drzava, DrzavaUpsertRequest, DrzavaUpsertRequest, DrzavaSearchObject>
    {
        public DrzaveService(eApartmanContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<Model.Drzava> Get(DrzavaSearchObject search)
        {
            IQueryable<Drzava>set= _context.Set<Drzava>();
            if(search!=null)
            {
                if (search.IncludeGradovi)
                   set= set.Include(d => d.Grads);
            }

            return _mapper.Map<List<Model.Drzava>>(set.OrderBy(d=>d.Naziv));
        }
    }
}
