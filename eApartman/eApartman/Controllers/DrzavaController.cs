using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class DrzavaController:BaseCRUDController<Model.Drzava, Drzava, DrzavaUpsertRequest, DrzavaUpsertRequest, DrzavaSearchObject>
    {
        public DrzavaController(ICRUDService<Model.Drzava, DrzavaSearchObject, DrzavaUpsertRequest, DrzavaUpsertRequest> service):base(service)
        {

        }
    }
}
