using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public int? GostId { get; set; }
        public int? ApartmanId { get; set; }
        public string Poruka { get; set; }
        public int BrojOsoba { get; set; }
        public DateTime DatumCheckIn { get; set; }
        public DateTime DatumCheckOut { get; set; }
        public int? BrojDana { get; set; }
        public bool Izvrsena { get; set; }
        public bool Otkazana { get; set; }
        public decimal? Cijena { get; set; }
        public int? PopustId { get; set; }
        public string GostIme { get; set; }
        public string GostPrezime { get; set; }
        public string Adresa => Apartman?.Adresa?.Naziv + " " + Apartman?.Adresa?.Broj;
        public string ApartmanNaziv => Apartman?.Naziv;
        public string CheckIn => DatumCheckIn.ToString("d.M.yyyy");
        public string CheckOut => DatumCheckOut.ToString("d.M.yyyy");
        public DateTime? DatumRezervacije { get; set; }
        public virtual Apartman Apartman { get; set; }
        public virtual Korisnik Gost { get; set; }
        public virtual Popust Popust { get; set; }
    }
}
