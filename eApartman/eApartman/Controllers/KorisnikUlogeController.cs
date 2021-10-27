using eApartman.Database;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class KorisnikUlogeController : BaseCRUDController<Model.KorisnikUloga, KorisnikUloga, Model.KorisnikUloga, object, object>
    {
        public KorisnikUlogeController(ICRUDService<Model.KorisnikUloga, object, Model.KorisnikUloga, object> service) : base(service)
        {
        }
    }
}
