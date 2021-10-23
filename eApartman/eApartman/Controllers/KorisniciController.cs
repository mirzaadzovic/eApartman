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
    [Authorize]
    public class KorisniciController:BaseCRUDController<Model.Korisnik, Korisnik, KorisnikInsertRequest, KorisnikUpdateRequest, KorisnikSearchObject>
    {
        public KorisniciController(ICRUDService<Model.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest> service)
            :base(service)
        {
        }
        [AllowAnonymous]
        public override Model.Korisnik Insert([FromBody] KorisnikInsertRequest request)
        {
            return base.Insert(request);
        }
    }
}
