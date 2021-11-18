using eApartman.Database;
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
    public class ApartmaniController:BaseCRUDController<Model.Apartman, Apartman, ApartmanUpsertRequest, ApartmanUpsertRequest, ApartmanSearchObject>
    {
        private readonly new IApartmaniService _service;
        public ApartmaniController(IApartmaniService service)
            :base(service)
        {
            _service = service;
        }

        [Authorize(Roles = "Vlasnik,Developer,ModeratorApartmani")]
        [HttpPost]
        public override Model.Apartman Insert([FromBody] ApartmanUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Vlasnik,Developer,ModeratorApartmani")]
        [HttpPut("{id}")]
        public override Model.Apartman Update(int id, [FromBody] ApartmanUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "Vlasnik,Developer")]
        [HttpDelete("{id}")]
        public override Model.Apartman Delete(int id)
        {
            return _service.Delete(id);
        }
        [HttpGet("recommend/{id}")]
        public IEnumerable<Model.Apartman> Recommend(int id)
        {
            return _service.Recommend(id);
        }
    }
}
