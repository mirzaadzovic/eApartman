using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class RezervacijaUpdateRequest
    {
        public DateTime DatumCheckIn { get; set; }
        public DateTime DatumCheckOut { get; set; }
        public bool Izvrsena { get; set; }
        public bool Otkazana { get; set; }
    }
}
