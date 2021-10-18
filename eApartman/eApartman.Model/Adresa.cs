using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class Adresa
    {
        public int AdresaId { get; set; }
        public string Naziv { get; set; }
        public int Broj { get; set; }
        public int? GradId { get; set; }

        public virtual Grad Grad { get; set; }
    }
}
