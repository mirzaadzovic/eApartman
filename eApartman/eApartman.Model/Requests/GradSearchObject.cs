using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class GradSearchObject
    {
        public string Naziv { get; set; }
        public bool IncludeAdrese { get; set; }
        public string Drzava { get; set; }
        public int DrzavaId { get; set; }
        public string Query { get; set; }
    }
}
