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
            CreateMap<Database.Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<Database.KorisnikUloga, Model.KorisnikUloga>().ReverseMap();
            CreateMap<Database.Uloga, Model.Uloga>().ReverseMap();
            CreateMap<KorisnikInsertRequest, Korisnik>().ReverseMap();
            CreateMap<KorisnikUpdateRequest, Korisnik>().ReverseMap();
            CreateMap<Grad, Model.Grad>().ReverseMap();
            CreateMap<Drzava, Model.Grad>().ReverseMap();
            CreateMap<GradUpsertRequest, Grad>().ReverseMap();
            CreateMap<Drzava, Model.Drzava>().ReverseMap();
            CreateMap<DrzavaUpsertRequest, Database.Drzava>().ReverseMap();
            CreateMap<Adresa, Model.Adresa>().ReverseMap();
            CreateMap<AdresaUpsertRequest, Adresa>();
            CreateMap<Apartman, Model.Apartman>().ReverseMap();
            CreateMap<ApartmanUpsertRequest, Apartman>().ReverseMap();
            CreateMap<ApartmanUpsertRequest, Model.Apartman>().ReverseMap();
            CreateMap<ApartmanSlika, Model.ApartmanSlika>().ReverseMap();
            CreateMap<ApartmanTip, Model.ApartmanTip>().ReverseMap();
            CreateMap<Rezervacija, Model.Rezervacija>().ReverseMap();
            CreateMap<Utisak, Model.Utisak>().ReverseMap();

        }
    }
}
