using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class KorisnikSearchObject
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] IncludeList { get; set; }
    }
}
