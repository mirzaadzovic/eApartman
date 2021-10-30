using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class Moderator
    {
        public int VlasnikId { get; set; }
        public int ModeratorId { get; set; }

        public virtual Korisnik ModeratorNavigation { get; set; }
        public virtual Korisnik Vlasnik { get; set; }
    }
}
