using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class DrzavaController:BaseCRUDController<Model.Drzava, Drzava, DrzavaUpsertRequest, DrzavaUpsertRequest, object>
    {
        public DrzavaController(ICRUDService<Model.Drzava, object, DrzavaUpsertRequest, DrzavaUpsertRequest> service):base(service)
        {

        }
    }
}
