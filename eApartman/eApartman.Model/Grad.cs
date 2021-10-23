using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eApartman.Model
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int? PostanskiBroj { get; set; }
        public int? DrzavaId { get; set; }
        public virtual Drzava Drzava { get; set; }
        public ICollection<Adresa> Adresas { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
