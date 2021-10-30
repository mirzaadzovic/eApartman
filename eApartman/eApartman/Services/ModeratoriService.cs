﻿using AutoMapper;
using eApartman.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class ModeratoriService : BaseCRUDService<Model.Korisnik, VlasnikModerator, Model.VlasnikModerator, Model.VlasnikModerator, Model.VlasnikModerator>
    {
        public ModeratoriService(eApartmanContext context, IMapper mapper) : base(context, mapper)
        {
          
        }
        public override IEnumerable<Model.Korisnik> Get(Model.VlasnikModerator search)
        {
            var set = _context
                .Set<VlasnikModerator>()
                .AsQueryable();
            //Ako moderator traži vlasnika kojem moderira apartmane ili rezervacje
            if (search?.ModeratorId>0)
            {
                set=set.Where(vm => vm.ModeratorId == search.ModeratorId);
            }
            //Ako vlasnik traži moderatore koji mu moderiraju apartmane ili rezervacije
            if (search?.VlasnikId>0)
            {
                set = set.Where(vm => vm.VlasnikId == search.VlasnikId);
            }

            var moderatori = _context
                .Set<Korisnik>()
                .Include("KorisnikUlogas");

            if (search!=null)
            {
                var ids = set.Select(vm => vm.ModeratorId);
                moderatori=moderatori.Where(k => ids.Contains(k.KorisnikId));
            }
            
            return _mapper.Map<List<Model.Korisnik>>(moderatori);
        }
        public override Model.Korisnik Insert(Model.VlasnikModerator request)
        {
            var entity = _mapper.Map<VlasnikModerator>(request);
            _context.Set<VlasnikModerator>().Add(entity);
            _context.SaveChanges();

            var moderator = _context.Set<Korisnik>().Find(entity.ModeratorId);
            return _mapper.Map<Model.Korisnik>(moderator);
        }

    }
}
