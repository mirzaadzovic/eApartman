using eApartman.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman
{
    public class SetupService
    {
        public void Init(eApartmanContext context)
        {
            context.Database.Migrate();

            if (!context.Popusts.Where(p => p.Naziv == "Sedmični").Any())
            {
                context.Popusts.Add(new Popust()
                {
                    Naziv = "Sedmični",
                    Opis = "Popust za rezervacije du" +
                    "že od 7 dana",
                    Procent = (decimal)0.05,
                }) ;
            }
            context.SaveChanges();
        }
    }
}
