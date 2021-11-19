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
            context.Database.EnsureCreated();
            context.Database.Migrate();



            //Dodavanje popusta
            if (!context.Popusts.Where(p => p.Naziv == "Sedmični").Any())
            {
                context.Popusts.Add(new Popust()
                {
                    Naziv = "Sedmični",
                    Opis = "Popust za rezervacije du" +
                    "že od 7 dana",
                    Procent = (decimal)0.05,
                });
                context.SaveChanges();
            }

          
          
            ////Dodavanje država
            //if (!context.Drzavas.Any())
            //{
            //    context.Drzavas.Add(new Drzava()
            //    {
            //        Naziv = "Albanija",
            //        Sifra = "ALB",
            //    });
            //    context.SaveChanges();

            //    context.Drzavas.Add(new Drzava()
            //    {
            //        Naziv = "Crna Gora",
            //        Sifra = "MNE",
            //    });
            //    context.SaveChanges();

            //    context.Drzavas.Add(new Drzava()
            //    {
            //        Naziv = "Bosna i Hercegovina",
            //        Sifra = "BIH",
            //    });           
            //    context.SaveChanges();
            //}

            ////Dodavanje gradova
            //if (!context.Grads.Any())
            //{
            //    context.Grads.Add(new Grad() 
            //    { 
            //        Naziv="Sarajevo",
            //        PostanskiBroj=71000,
            //        DrzavaId=3,
            //    });
            //    context.Grads.Add(new Grad()
            //    {
            //        Naziv = "Mostar",
            //        PostanskiBroj = 88000,
            //        DrzavaId = 3,
            //    });
            //    context.Grads.Add(new Grad()
            //    {
            //        Naziv = "Podgorica",
            //        PostanskiBroj = 81000,
            //        DrzavaId = 2,
            //    });
            //    context.Grads.Add(new Grad()
            //    {
            //        Naziv = "Herceg Novi",
            //        PostanskiBroj = 85340,
            //        DrzavaId = 2,
            //    });
            //    context.Grads.Add(new Grad()
            //    {
            //        Naziv = "Saranda",
            //        PostanskiBroj = 5500,
            //        DrzavaId = 1,
            //    });
            //    context.Grads.Add(new Grad()
            //    {
            //        Naziv = "Drač",
            //        PostanskiBroj = 5200,
            //        DrzavaId = 1,
            //    });
            //    context.SaveChanges();

            //}

            //if (!context.Adresas.Any())
            //{
            //    context.Add(new Adresa() 
            //    {
            //        Broj=23,
            //        Naziv="Majkla Džordana",
            //        GradId=1,
            //    });
            //    context.Add(new Adresa()
            //    {
            //        Broj = 2,
            //        Naziv = "Avdije Vršajevića",
            //        GradId = 3,
            //    });
            //    context.Add(new Adresa()
            //    {
            //        Broj = 12,
            //        Naziv = "Džemala Bijedića",
            //        GradId = 6,
            //    });
            //    context.Add(new Adresa()
            //    {
            //        Broj = 6,
            //        Naziv = "Avde Jabučice",
            //        GradId = 5,
            //    });

            //    context.SaveChanges();
            //}

            //if(!context.Apartmen.Any())
            //{
     

            //    var apartman1 = new Apartman()
            //    {
            //        Naziv = "Babovina",
            //        AdresaId = 1,
            //        ApartmanTipId = 1,
            //        CheckoutVrijeme = TimeSpan.FromHours(12),
            //        Cijena = 25,
            //        ImaBalkon = true,
            //        ImaParking = false,
            //        MaxOsoba = 3,
            //        PetFriendly = false,
            //        VlasnikId = context.Korisniks.Where(u=>u.Username=="user").First().KorisnikId,
            //        SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman1.jpg"),
            //    };        

            //    context.Apartmen.Add(apartman1);

            //    var apartman2 = new Apartman()
            //    {
            //        Naziv = "Đedovina",
            //        AdresaId = 2,
            //        ApartmanTipId = 1,
            //        CheckoutVrijeme = TimeSpan.FromHours(12),
            //        Cijena = 30,
            //        ImaBalkon = true,
            //        ImaParking = true,
            //        MaxOsoba = 4,
            //        PetFriendly = false,
            //        VlasnikId = context.Korisniks.Where(u => u.Username == "admin").First().KorisnikId,
            //        SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman2.jpg"),

            //    };

            //    context.Apartmen.Add(apartman2);

            //    var apartman3 = new Apartman()
            //    {
            //        Naziv = "PraĐedovina",
            //        AdresaId = 3,
            //        ApartmanTipId = 1,
            //        CheckoutVrijeme = TimeSpan.FromHours(12),
            //        Cijena = 15,
            //        ImaBalkon = true,
            //        ImaParking = true,
            //        MaxOsoba = 2,
            //        PetFriendly = false,
            //        VlasnikId = context.Korisniks.Where(u => u.Username == "user").First().KorisnikId,
            //        SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman3.jpg"),

            //    };

            //    context.Apartmen.Add(apartman3);

            //    var apartman4 = new Apartman()
            //    {
            //        Naziv = "Villa Gorica",
            //        AdresaId = 4,
            //        ApartmanTipId = 1,
            //        CheckoutVrijeme = TimeSpan.FromHours(12),
            //        Cijena = 5,
            //        ImaBalkon = false,
            //        ImaParking = false,
            //        MaxOsoba = 15,
            //        PetFriendly = true,
            //        VlasnikId = context.Korisniks.Where(u => u.Username == "admin").First().KorisnikId,
            //        SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman4.jpg"),

            //    };

            //    context.Apartmen.Add(apartman4);
                       
            //    context.SaveChanges();

                //Dodavanje rezervacija
            if(!context.Rezervacijas.Any())
            {
                var rezervacija1 = new Rezervacija()
                {
                    GostIme = "Ado",
                    GostPrezime = "Gegaj",
                    ApartmanId = 4,
                    BrojDana = 2,
                    Cijena = 10,
                    DatumCheckOut = DateTime.Now.Date,
                    DatumCheckIn = DateTime.Now.AddDays(-2).Date,
                    BrojOsoba = 12,
                    Izvrsena = true,
                    Otkazana = false,
                    GostId = context.Korisniks.Where(u => u.Username == "gost").First().KorisnikId,
                    Poruka = "Pravim parti drama",
                };
                context.Rezervacijas.Add(rezervacija1);

                var rezervacija2 = new Rezervacija()
                {
                    GostIme = "Ado",
                    GostPrezime = "Gegaj",
                    ApartmanId = 2,
                    BrojDana = 2,
                    Cijena = 50,
                    DatumCheckOut = DateTime.Now.Date,
                    DatumCheckIn = DateTime.Now.AddDays(-2).Date,
                    BrojOsoba = 1,
                    Izvrsena = true,
                    Otkazana = false,
                    GostId = context.Korisniks.Where(u => u.Username == "gost").First().KorisnikId,
                    Poruka = "Bit ću vamo sam i na Gorici s rajom istovremeno, pa ćemo viđet kako će ić",
                };
                context.Rezervacijas.Add(rezervacija2);

                context.SaveChanges();
            }       
               
        }
        public static void DodajPassword(Korisnik user, string password)
        {
            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateHash(user.PasswordSalt, password);
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

    }
}

