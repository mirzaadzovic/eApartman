using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string OldPassword { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public byte[] Slika { get; set; }
        public bool? Status { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
    }
}
