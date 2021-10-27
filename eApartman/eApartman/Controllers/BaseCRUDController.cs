using eApartman.Model;
using eApartman.Model.Requests;
using eApartman.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    [Authorize]
    public class BaseCRUDController<T, TDb, TInsert, TUpdate, TSearch>:BaseReadController<T, TSearch> where T:class where TDb:class where TInsert:class where TUpdate:class where TSearch:class
    {
        protected readonly new ICRUDService<T, TSearch, TInsert, TUpdate> _service;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public virtual T Insert([FromBody]TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public virtual T Update(int id, [FromBody]TUpdate request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public virtual T Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
