using eApartman.Database;
using eApartman.Model;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class ApartmaniTipController : BaseReadController<Model.ApartmanTip, object>
    {
        public ApartmaniTipController(IReadService<Model.ApartmanTip, object> service) : base(service)
        {
        }
    }
}
