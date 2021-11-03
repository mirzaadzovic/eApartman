using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using eApartman.Model.DataAttributes;
using System.Linq;

namespace eApartman.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string Prezime { get; set; }
        [MinLength(3)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Neispravan unos!")]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Apartman> Apartmen { get; set; }
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual Moderator ModeratorModeratorNavigation { get; set; }
        public int? VlasnikId => ModeratorModeratorNavigation?.VlasnikId;
        public bool? IsVlasnik => KorisnikUlogas?.Any(u => u.UlogaId == 2);
        public bool? IsModeratorApartmani => KorisnikUlogas?.Any(u => u.UlogaId == 4);
        public bool? IsModeratorRezervacije => KorisnikUlogas?.Any(u => u.UlogaId == 5);

        //public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        //public virtual ICollection<Utisak> Utisaks
        //{
        //    get; set;
        //}
        public int GetVlasnikId()
        {   //Vraća VlasnikId u zavisnosti je li korisnik moderator ili nije
            return IsVlasnik == true ? KorisnikId : int.Parse(VlasnikId.ToString());
        }
        public string GetFullName()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
