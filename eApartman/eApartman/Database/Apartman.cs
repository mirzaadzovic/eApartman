using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Apartman
    {
        public Apartman()
        {
            ApartmanSlikas = new HashSet<ApartmanSlika>();
            Rezervacijas = new HashSet<Rezervacija>();
            Utisaks = new HashSet<Utisak>();
        }

        public int ApartmanId { get; set; }
        public string Naziv { get; set; }
        public int? VlasnikId { get; set; }
        public int? AdresaId { get; set; }
        public int MaxOsoba { get; set; }
        public bool ImaBalkon { get; set; }
        public bool ImaParking { get; set; }
        public bool PetFriendly { get; set; }
        public TimeSpan? CheckoutVrijeme { get; set; }
        public decimal Cijena { get; set; }
        public byte[] SlikaProfilnaFile { get; set; }
        public byte[] SlikaProfilnaThumbnail { get; set; }
        public int? ApartmanTipId { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual ApartmanTip ApartmanTip { get; set; }
        public virtual Korisnik Vlasnik { get; set; }
        public virtual ICollection<ApartmanSlika> ApartmanSlikas { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        public virtual ICollection<Utisak> Utisaks { get; set; }
    }
}
