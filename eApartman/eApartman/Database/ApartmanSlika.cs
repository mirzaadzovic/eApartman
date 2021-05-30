using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class ApartmanSlika
    {
        public int SlikaId { get; set; }
        public byte[] SlikaFile { get; set; }
        public byte[] SlikaThumbnail { get; set; }
        public int? ApartmanId { get; set; }

        public virtual Apartman Apartman { get; set; }
    }
}
