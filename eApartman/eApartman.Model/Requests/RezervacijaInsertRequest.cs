using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class RezervacijaInsertRequest
    {
        public int? GostId { get; set; }
        public int? ApartmanId { get; set; }
        public string Poruka { get; set; }
        public int BrojOsoba { get; set; }
        public DateTime DatumCheckIn { get; set; }
        public DateTime DatumCheckOut { get; set; }
        public int? BrojDana { get; set; }
        public decimal? Cijena { get; set; }
        public int? PopustId { get; set; }
        public string GostIme { get; set; }
        public string GostPrezime { get; set; }
        public DateTime? DatumRezervacije { get; set; }

    }
}
