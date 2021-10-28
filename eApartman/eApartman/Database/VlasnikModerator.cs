using System;
using System.Collections.Generic;

#nullable disable

namespace eApartman.Database
{
    public partial class VlasnikModerator
    {
        public int VlasnikId { get; set; }
        public int ModeratorId { get; set; }

        public virtual Korisnik Moderator { get; set; }
        public virtual Korisnik Vlasnik { get; set; }
    }
}
