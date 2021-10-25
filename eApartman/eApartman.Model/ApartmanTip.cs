using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class ApartmanTip
    {
        public int ApartmanTipId { get; set; }
        public string ApartmanTipNaziv { get; set; }
        public string Opis { get; set; }
        public override string ToString()
        {
            return ApartmanTipNaziv;
        }
    }
}
