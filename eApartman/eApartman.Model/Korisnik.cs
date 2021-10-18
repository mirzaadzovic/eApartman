using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Apartman> Apartmen { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        //public virtual ICollection<Utisak> Utisaks
        //{
        //    get; set;
        //}
    }
}
