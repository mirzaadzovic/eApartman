using eApartman.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public interface IApartmaniService:ICRUDService<Model.Apartman, ApartmanSearchObject, ApartmanUpsertRequest, ApartmanUpsertRequest>
    {
        IEnumerable<Model.Apartman> Recommend(int korisnikId);
    }
}
