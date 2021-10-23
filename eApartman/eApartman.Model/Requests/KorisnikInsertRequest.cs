using eApartman.Model.DataAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class KorisnikInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //[BezDvotacke]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        //[BezDvotacke]
        public string Password{ get; set; }
        public string PasswordPotvrda { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public bool? Status { get; set; }
        public byte[] Slika { get; set; }
        public List<int> Uloge { get; set; }
    }
}
