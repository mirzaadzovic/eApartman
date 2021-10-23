using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eApartman.Model
{
    public class Drzava
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public ICollection<Grad> Grads { get; set; }
        public override string ToString()
        {
            return Naziv;
        }

    }
}
