using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public interface IReadService<T, TSearch> where T:class where TSearch:class
    {
        IEnumerable<T> Get(TSearch search);
        T GetById(int Id);
    }
}
