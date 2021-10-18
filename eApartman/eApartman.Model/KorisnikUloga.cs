using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class KorisnikUloga
    {
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
