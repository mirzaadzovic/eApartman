using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class ApartmanSearchObject
    {
        public string Naziv { get; set; }
        public int VlasnikId { get; set; }
        public string Grad { get; set; }
        public string Tip { get; set; }
        public int Osoba { get; set; }
        public bool IncludeRezervacije { get; set; }
        public bool IncludeSlike { get; set; }
        public bool Parking { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
