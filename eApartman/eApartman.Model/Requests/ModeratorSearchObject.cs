using System;
using System.Collections.Generic;
using System.Text;

namespace eApartman.Model.Requests
{
    public class ModeratorSearchObject
    {
        public int ModeratorId { get; set; }
        public int VlasnikId { get; set; }
        public string Username { get; set; }
    }
}
