using AutoMapper;
using eApartman.Database;
using eApartman.Filters;
using eApartman.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eApartman.Services
{
    public class KorisniciService:BaseCRUDService<Model.Korisnik, Korisnik, KorisnikInsertRequest, KorisnikUpdateRequest, KorisnikSearchObject>, IKorisniciService
    {
        public KorisniciService(eApartmanContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
        public override IEnumerable<Model.Korisnik> Get(KorisnikSearchObject search)
        {
            var set = _context.Korisniks.AsQueryable();

            if (search?.Ime!=null) set=set.Where(k=>k.Ime==search.Ime);
            if (search?.Prezime != null) set = set.Where(k => k.Prezime == search.Prezime);
            if (search?.Username != null) set = set.Where(k => k.Username == search.Username);
            foreach(string item in search?.IncludeList)
            {
                set = set.Include(item);
            }
          
            var entity = _mapper.Map<List<Model.Korisnik>>(set);
            return entity;
        }
        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                //throw new NotImplementedException();
                throw new Exception("Lozinka nije ispravna");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            entity.DatumRegistracije = DateTime.Now;

            _context.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                KorisnikUloga korisniciUloge = new KorisnikUloga();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;

                _context.KorisnikUlogas.Add(korisniciUloge);

            }
            _context.SaveChanges();
        
            return _mapper.Map<Model.Korisnik>(entity);
        }
        public override Model.Korisnik Update(int id, KorisnikUpdateRequest request)
        {
            Korisnik korisnik = _context.Set<Korisnik>().Find(id);
            MapirajKorisnikaUpdate(korisnik, request);

            foreach(var uloga in request.Uloge)
            {
                KorisnikUloga korisnikUloga = new KorisnikUloga();
                korisnikUloga.KorisnikId = korisnik.KorisnikId;
                korisnikUloga.UlogaId = uloga;
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(korisnik);
        }

        private void MapirajKorisnikaUpdate(Korisnik korisnik, KorisnikUpdateRequest request)
        {
            var password = GenerateHash(korisnik.PasswordSalt, request.OldPassword);

            if (password != korisnik.PasswordHash)
                throw new UserException("Neispravan stari password");
            if (request.Password != request.PasswordPotvrda)
                throw new Exception("Lozinka nije ispravna");

            korisnik.Ime = request.Ime;
            korisnik.Prezime = request.Prezime;
            korisnik.Telefon = request.Telefon;
            korisnik.Slika = request.Slika;
            korisnik.Status = request.Status;

            if (request.Password != "")
            {
                string salt = GenerateSalt();
                string hash = GenerateHash(salt, request.Password);
                korisnik.PasswordSalt = salt;
                korisnik.PasswordHash = hash;
            }
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public async Task<Model.Korisnik> Login(string username, string password)
        {
            var entity = await _context.Korisniks.Include("KorisnikUlogas.Uloga").FirstOrDefaultAsync(k => k.Username == username);
            if (entity == null)
                throw new UserException("Pogrešan username ili password...");

            var hash = GenerateHash(entity.PasswordSalt, password);
            if(hash!=entity.PasswordHash)
                throw new UserException("Pogrešan username ili password...");

            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}
