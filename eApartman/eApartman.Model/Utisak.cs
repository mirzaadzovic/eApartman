using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class Utisak
    {
        public int UtisakId { get; set; }
        public int? KorisnikId { get; set; }
        public int? ApartmanId { get; set; }
        public string Komentar { get; set; }
        public int? OcjenaWiFi { get; set; }
        public int? OcjenaLokacija { get; set; }
        public int? OcjenaCistoca { get; set; }
        public int? OcjenaVlasnik { get; set; }
    }
}
