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
    public class RezervacijeController:BaseCRUDController<Model.Rezervacija, Rezervacija, RezervacijaInsertRequest, RezervacijaUpdateRequest, RezervacijaSearchObject>
    {
        public RezervacijeController(ICRUDService<Model.Rezervacija, RezervacijaSearchObject, RezervacijaInsertRequest, RezervacijaUpdateRequest> service)
            :base(service)
        {
        }
        [Authorize(Roles="Vlasnik,ModeratorRezervacije,Developer,Gost")]
        public override IEnumerable<Model.Rezervacija> Get([FromQuery] RezervacijaSearchObject search = null)
        {
            return base.Get(search);
        }

        [Authorize(Roles = "Vlasnik,ModeratorRezervacije,Developer,Gost")]
        public override Model.Rezervacija GetById(int id)
        {
            return base.GetById(id);
        }

        [Authorize(Roles = "Vlasnik,ModeratorRezervacije,Developer,Gost")]
        public override Model.Rezervacija Insert([FromBody] RezervacijaInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles = "Vlasnik,ModeratorRezervacije,Developer,Gost")]
        public override Model.Rezervacija Update(int id, [FromBody] RezervacijaUpdateRequest request)
        {
            return base.Update(id, request);
        }


    }
}
