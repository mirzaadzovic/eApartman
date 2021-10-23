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
        public ApartmaniController(ICRUDService<Model.Apartman, ApartmanSearchObject, ApartmanUpsertRequest, ApartmanUpsertRequest> service)
            :base(service)
        {
        }

        [Authorize(Roles = "Vlasnik,Developer")]
        [HttpPost]
        public override Model.Apartman Insert([FromBody] ApartmanUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Vlasnik,Developer")]
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
    }
}
