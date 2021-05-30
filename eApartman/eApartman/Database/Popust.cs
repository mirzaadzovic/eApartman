using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Popust
    {
        public Popust()
        {
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public int PopustId { get; set; }
        public string Naziv { get; set; }
        public decimal Procent { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
