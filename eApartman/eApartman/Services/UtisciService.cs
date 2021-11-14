using AutoMapper;
using eApartman.Database;
using eApartman.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class UtisciService:BaseCRUDService<Model.Utisak, Model.Utisak, Model.Utisak, Model.Utisak, UtisakSearchObject>
    {
        public UtisciService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        public override IEnumerable<Model.Utisak> Get(UtisakSearchObject search)
        {
            var set = _context.Set<Utisak>().AsQueryable();
            if (search?.ApartmanId > 0)
                set = set.Where(u => u.ApartmanId == search.ApartmanId);
            if (search?.GostId > 0)
                set = set.Where(u => u.KorisnikId == search.GostId);
            return _mapper.Map<List<Model.Utisak>>(set);
        }
    }
}
