using eApartman.Database;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class ModeratoriController : BaseCRUDController<Model.Korisnik, VlasnikModerator, Model.VlasnikModerator, Model.VlasnikModerator, Model.VlasnikModerator>
    {
        public ModeratoriController(ICRUDService<Model.Korisnik, Model.VlasnikModerator, Model.VlasnikModerator, Model.VlasnikModerator> service) : base(service)
        {
        }
    }
}
