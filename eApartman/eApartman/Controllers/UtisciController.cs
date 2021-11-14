using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class UtisciController:BaseCRUDController<Model.Utisak, Utisak, Model.Utisak, Model.Utisak, UtisakSearchObject>
    {
        public UtisciController(ICRUDService<Model.Utisak, UtisakSearchObject, Model.Utisak, Model.Utisak> service):base(service)
        {

        }
    }
}
