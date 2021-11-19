using eApartman.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace eApartman
{
    public class SetupService
    {
        public void Init(eApartmanContext context)
        {
            context.Database.Migrate();
        }
       

    }
}

