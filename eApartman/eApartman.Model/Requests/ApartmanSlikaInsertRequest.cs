using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class ApartmanSlikaInsertRequest
    {
        public byte[] SlikaFile { get; set; }
        public byte[] SlikaThumbnail { get; set; }
        public int? ApartmanId { get; set; }
    }
}
