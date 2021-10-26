using AutoMapper;
using eApartman.Database;
using eApartman.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class SlikeService : BaseCRUDService<Model.ApartmanSlika, ApartmanSlika, List<ApartmanSlikaInsertRequest>, ApartmanSlikaInsertRequest, object>
    {
        public SlikeService(eApartmanContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<Model.ApartmanSlika> Get(object search=null)
        {
            var set = _context.Set<ApartmanSlika>().AsQueryable();
            if(int.TryParse(search?.ToString(), out int id))
            {
                set = set.Where(s => s.ApartmanId == id);
            }

            var entity = _mapper.Map<List<Model.ApartmanSlika>>(set);

            return entity;
        }
        public override Model.ApartmanSlika Insert(List<ApartmanSlikaInsertRequest> request)
        {
            var set = _context.Set<ApartmanSlika>();

            foreach(ApartmanSlikaInsertRequest slika in request)
            {
                var entity = _mapper.Map<ApartmanSlika>(slika);
                set.Add(entity);
            }
            _context.SaveChanges();

            return new Model.ApartmanSlika();
        }
    }
}
