using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class RezervacijaSearchObject
    {
        public string[] IncludeList { get; set; } = { };
        public DateTime? Datum { get; set; }
        public string ApartmanNaziv { get; set; }
        public int VlasnikId { get; set; }
        public int ApartmanId { get; set; }
        public bool Otkazana { get; set; }
        public bool Izvrsena { get; set; }

    }
}
