using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
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
    }
}
