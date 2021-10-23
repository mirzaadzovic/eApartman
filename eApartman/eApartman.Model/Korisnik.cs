using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using eApartman.Model.DataAttributes;

namespace eApartman.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[MinLength(2)]
        public string Ime { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //[MinLength(2)]
        public string Prezime { get; set; }
        //[MinLength(3)]
        //[Required(AllowEmptyStrings = false, ErrorMessage = "Neispravan unos!")]
        public string Username { get; set; }
        //[EmailAddress()]
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
