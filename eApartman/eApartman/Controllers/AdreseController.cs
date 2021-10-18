using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class AdreseController:BaseCRUDController<Model.Adresa, Adresa, AdresaUpsertRequest, AdresaUpsertRequest, object>
    {
        public AdreseController(ICRUDService<Model.Adresa, object, AdresaUpsertRequest, AdresaUpsertRequest> service)
            :base(service)
        {

        }
    }
}
