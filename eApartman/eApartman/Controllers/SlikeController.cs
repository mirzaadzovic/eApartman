using eApartman.Database;
using eApartman.Model.Requests;
using eApartman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Controllers
{
    public class SlikeController:BaseCRUDController<Model.ApartmanSlika, ApartmanSlika, List<ApartmanSlikaInsertRequest>, ApartmanSlikaInsertRequest, object>
    {
        public SlikeController(ICRUDService<Model.ApartmanSlika, object, List<ApartmanSlikaInsertRequest>, ApartmanSlikaInsertRequest> service)
            :base(service)
        {

        }
    }
}
