using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class ApartmanTip
    {
        public ApartmanTip()
        {
            Apartmen = new HashSet<Apartman>();
        }

        public int ApartmanTipId { get; set; }
        public string ApartmanTipNaziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Apartman> Apartmen { get; set; }
    }
}
