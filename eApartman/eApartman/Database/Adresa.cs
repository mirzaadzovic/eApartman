using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Adresa
    {
        public Adresa()
        {
            Apartmen = new HashSet<Apartman>();
        }

        public int AdresaId { get; set; }
        public string Naziv { get; set; }
        public int Broj { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Apartman> Apartmen { get; set; }
    }
}
