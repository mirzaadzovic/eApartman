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
            var set = _context.Utisaks.AsQueryable();
            if (search?.ApartmanId > 0)
                set = set.Where(u => u.ApartmanId == search.ApartmanId);
            if (search?.GostId > 0)
                set = set.Where(u => u.KorisnikId == search.GostId);
            return _mapper.Map<List<Model.Utisak>>(set);
        }
        public override Model.Utisak GetById(int id)
        {
            var entity = _context.Utisaks.Find(id);
            if (entity == null) return null;
            return _mapper.Map<Model.Utisak>(entity);
        }
        public override Model.Utisak Insert(Model.Utisak request)
        {
            var search=_context.Utisaks.Find(request.UtisakId);
            if (search == null)
            {
                var entity = _mapper.Map<Utisak>(request);
                _context.Utisaks.Add(entity);
                _context.SaveChanges();
            }
            return request;
        }
    }
}
