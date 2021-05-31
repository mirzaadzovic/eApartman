using eApartman.Model;
using eApartman.Model.Requests;
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
        protected readonly new ICRUDService<T, TSearch, TInsert, TUpdate> _service;
        private ICRUDService<Grad, GradSearchObject, GradUpsertRequest, GradUpsertRequest> service;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service):base(service)
        {
            _service = service;
        }


        [HttpPost]
        public T Insert([FromBody]TInsert request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public T Update(int id, [FromBody]TUpdate request)
        {
            return _service.Update(id, request);
        }
    }
}
