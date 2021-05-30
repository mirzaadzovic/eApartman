using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Grad
    {
        public Grad()
        {
            Adresas = new HashSet<Adresa>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? PostanskiBroj { get; set; }
        public int? DrzavaId { get; set; }

        public virtual Drzava Drzava { get; set; }
        public virtual ICollection<Adresa> Adresas { get; set; }
    }
}
