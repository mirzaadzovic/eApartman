using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class Popust
    {
        public int PopustId { get; set; }
        public string Naziv { get; set; }
        public decimal Procent { get; set; }
        public string Opis { get; set; }
    }
}
