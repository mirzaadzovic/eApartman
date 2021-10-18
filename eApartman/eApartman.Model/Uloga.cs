using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class Uloga
    {
        public int UlogaId { get; set; }
        public string UlogaNaziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
