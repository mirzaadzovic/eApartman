using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class KorisniciController:BaseCRUDController<Model.Korisnik, Korisnik, KorisnikInsertRequest, KorisnikUpdateRequest, KorisnikSearchObject>
    {
        public KorisniciController(ICRUDService<Model.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest> service)
            :base(service)
        {
        }
    }
}
