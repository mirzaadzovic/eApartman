using AutoMapper;
using eApartman.Database;
using eApartman.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Profiles
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Grad, Model.Grad>().ReverseMap();
            CreateMap<Drzava, Model.Drzava>().ReverseMap();
            CreateMap<DrzavaUpsertRequest, Database.Drzava>().ReverseMap();
        }
    }
}
