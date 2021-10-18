using AutoMapper;
using eApartman.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class BaseCRUDService<T,TDb, TInsert, TUpdate, TSearch> : BaseReadService<T, TSearch, TDb>, ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TDb : class where TInsert : class where TUpdate : class where TSearch:class
    {
        public BaseCRUDService(eApartmanContext context, IMapper mapper):base(context, mapper)
        {
        }
        public virtual T Insert(TInsert request)
        {
            var entity = _mapper.Map<TDb>(request);
            _context.Set<TDb>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDb>().Find(id);
            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
        public virtual T Delete(int id)
        {
            var entity = _context.Set<TDb>().Find(id);

            _context.Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
