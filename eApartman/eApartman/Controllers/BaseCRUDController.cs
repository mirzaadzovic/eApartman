using eApartman.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class BaseCRUDController<T, TDb, TInsert, TUpdate, TSearch>:BaseReadController<T, TSearch> where T:class where TDb:class where TInsert:class where TUpdate:class where TSearch:class
    {
        protected readonly new ICRUDService<T, object, TInsert, TUpdate> _service;
        public BaseCRUDController(ICRUDService<T, object, TInsert, TUpdate> service):base(service as IReadService<T, TSearch>)
        {
            _service = service;
        }
        [HttpPost]
        public T Insert([FromBody]TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public T Update(int Id, [FromBody]TUpdate request)
        {
            return _service.Update(Id, request);
        }
    }
}
