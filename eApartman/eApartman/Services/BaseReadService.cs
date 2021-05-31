using AutoMapper;
using eApartman.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class BaseReadService<T, TSearch, TDb> : IReadService<T,TSearch> where T : class where TSearch:class where TDb : class
    {
        protected readonly eApartmanContext _context;
        protected readonly IMapper _mapper;
        public BaseReadService(eApartmanContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search)
        {
            var set = _context.Set<TDb>();
            var entity = _mapper.Map<List<T>>(set);
            return entity;
        }

        public virtual T GetById(int id)
        {
            var set = _context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    }
}
