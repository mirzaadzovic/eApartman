using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Utisak
    {
        public int UtisakId { get; set; }
        public int? KorisnikId { get; set; }
        public int? ApartmanId { get; set; }
        public string Komentar { get; set; }
        public int? OcjenaWiFi { get; set; }
        public int? OcjenaLokacija { get; set; }
        public int? OcjenaCistoca { get; set; }
        public int? OcjenaVlasnik { get; set; }
        public DateTime? DatumKreiranja { get; set; }

        public virtual Apartman Apartman { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
