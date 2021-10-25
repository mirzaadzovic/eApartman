using eApartman.Model.DataAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eApartman.Model.Requests
{
    public class KorisnikInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(2)]
        public string Prezime { get; set; }
        //[BezDvotacke]
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        [EmailAddress]
        public string Email { get; set; }
        public string Telefon { get; set; }
        //[BezDvotacke]
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Password{ get; set; }
        [MinLength(4)]
        public string PasswordPotvrda { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }
        public List<int> Uloge { get; set; }
    }
}
