using eApartman.Database;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class ModeratoriController : BaseCRUDController<Model.Korisnik, Moderator, Model.Moderator, Model.Moderator, Model.Moderator>
    {
        public ModeratoriController(ICRUDService<Model.Korisnik, Model.Moderator, Model.Moderator, Model.Moderator> service) : base(service)
        {
        }
    }
}
