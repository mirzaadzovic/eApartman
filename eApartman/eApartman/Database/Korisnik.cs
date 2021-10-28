using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Apartmen = new HashSet<Apartman>();
            KorisnikUlogas = new HashSet<KorisnikUloga>();
            Rezervacijas = new HashSet<Rezervacija>();
            Utisaks = new HashSet<Utisak>();
            VlasnikModeratorModerators = new HashSet<VlasnikModerator>();
            VlasnikModeratorVlasniks = new HashSet<VlasnikModerator>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Apartman> Apartmen { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        public virtual ICollection<Utisak> Utisaks { get; set; }
        public virtual ICollection<VlasnikModerator> VlasnikModeratorModerators { get; set; }
        public virtual ICollection<VlasnikModerator> VlasnikModeratorVlasniks { get; set; }
    }
}
