using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model
{
    public class ApartmanSlika
    {
        public int SlikaId { get; set; }
        public byte[] SlikaFile { get; set; }
        public byte[] SlikaThumbnail { get; set; }
        public int? ApartmanId { get; set; }
    }
}
