using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Uloga
    {
        public Uloga()
        {
            KorisnikUlogas = new HashSet<KorisnikUloga>();
        }

        public int UlogaId { get; set; }
        public string UlogaNaziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
