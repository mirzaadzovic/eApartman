using eApartman.Database;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class RezervacijeController:BaseCRUDController<Model.Rezervacija, Rezervacija, object, object, object>
    {
        public RezervacijeController(ICRUDService<Model.Rezervacija, object, object, object> service)
            :base(service)
        {
        }
    }
}
