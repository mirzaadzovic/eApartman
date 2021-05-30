using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class GradoviController:BaseCRUDController<Model.Grad, Grad, GradUpsertRequest, GradUpsertRequest, object>
    {
        public GradoviController(ICRUDService<Model.Grad, object, GradUpsertRequest, GradUpsertRequest> service)
            :base(service)
        {

        }
    }
}
