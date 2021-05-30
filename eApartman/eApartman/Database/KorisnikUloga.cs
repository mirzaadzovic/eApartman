using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class KorisnikUloga
    {
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
