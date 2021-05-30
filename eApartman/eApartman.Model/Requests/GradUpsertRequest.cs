using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class GradUpsertRequest
    {
        public string Naziv { get; set; }
        public int? PostanskiBroj { get; set; }
        public int? DrzavaId { get; set; }
        public virtual Drzava Drzava { get; set; }
    }
}
