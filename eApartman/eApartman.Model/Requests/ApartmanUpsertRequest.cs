using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class ApartmanUpsertRequest
    {
        public string Naziv { get; set; }
        public int? VlasnikId { get; set; }
        public virtual Korisnik Vlasnik { get; set; }
        public int? AdresaId { get; set; }
        public virtual Adresa Adresa { get; set; }
        public int MaxOsoba { get; set; }
        public bool ImaBalkon { get; set; }
        public bool ImaParking { get; set; }
        public bool PetFriendly { get; set; }
        public TimeSpan? CheckoutVrijeme { get; set; }
        public decimal Cijena { get; set; }
        public byte[] SlikaProfilnaFile { get; set; }
        public byte[] SlikaProfilnaThumbnail { get; set; }
        public int? ApartmanTipId { get; set; }
    }
}
