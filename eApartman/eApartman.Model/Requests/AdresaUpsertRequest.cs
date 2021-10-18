using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class AdresaUpsertRequest
    {
        public string Naziv { get; set; }
        public int Broj { get; set; }
        public int? GradId { get; set; }

    }
}
