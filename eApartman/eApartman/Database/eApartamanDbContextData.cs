using eApartman.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eApartman.Database
{
    public partial class eApartamanDbContext
    {
        void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Popust>().HasData(new List<Popust>
            {
                new Popust()
                {
                    PopustId=1,
                    Naziv = "Sedmični",
                    Opis = "Popust za rezervacije du" +
                    "že od 7 dana",
                    Procent = (decimal)0.05,
                }
            });
            modelBuilder.Entity<Uloga>().HasData(new List<Uloga>
            {
                    new Uloga()
                    {
                        UlogaId=1,
                        UlogaNaziv="Gost",
                        Opis="Klijent - iznajmljuje apartmane putem mobilne aplikacije",
                    },
                    new Uloga()
                    {
                        UlogaId=2,
                        UlogaNaziv="Vlasnik",
                        Opis="Vlasnik"
                    },
                    new Uloga
                    {
                        UlogaId=3,
                        UlogaNaziv = "Developer",
                        Opis = "Developer",
                    },
                    new Uloga
                    {
                        UlogaId=4,
                        UlogaNaziv = "ModeratorApartmani",
                        Opis = "Moderator apartmana",
                    },
                    new Uloga
                    {
                        UlogaId=5,
                        UlogaNaziv = "ModeratorRezervacija",
                        Opis = "Moderator rezervacija",
                    },

                }
           );
            var user = new Korisnik()
            {
                KorisnikId = 1,
                Ime = "User",
                Prezime = "Usersky",
                Username = "user",
                Email = "user@example.com",
                Telefon = "062-225-883",
                Status = true,
                DatumRegistracije = DateTime.Now,
            };

            Helper.DodajPassword(user, "user");
            modelBuilder.Entity<Korisnik>().HasData(user);

            //Vlasnik admin
            var admin = new Korisnik()
            {
                KorisnikId = 2,
                Ime = "Admin",
                Prezime = "Admin",
                Username = "admin",
                Email = "admin@example.com",
                Telefon = "061-225-883",
                Status = true,
                DatumRegistracije = DateTime.Now,
            };

            Helper.DodajPassword(admin, "admin");
            modelBuilder.Entity<Korisnik>().HasData(admin);


            //Gost gost
            var gost = new Korisnik()
            {
                KorisnikId = 3,
                Ime = "Ado",
                Prezime = "Gegaj",
                Username = "gost",
                Email = "gost@example.com",
                Telefon = "063-225-883",
                Status = true,
                DatumRegistracije = DateTime.Now,
            };

            Helper.DodajPassword(gost, "gost");
            modelBuilder.Entity<Korisnik>().HasData(gost);

            modelBuilder.Entity<KorisnikUloga>().HasData(new List<KorisnikUloga>()
            {
                new KorisnikUloga()
                {
                    KorisnikId=1,
                    UlogaId=2,
                },
                new KorisnikUloga()
                {
                    KorisnikId=2,
                    UlogaId=2,
                },
                new KorisnikUloga()
                {
                    KorisnikId=3,
                    UlogaId=1,
                },
            });
            modelBuilder.Entity<Drzava>().HasData(new List<Drzava>()
            {
                new Drzava()
                {
                    DrzavaId=1,
                    Naziv="Bosna i Hercegovina",
                    Sifra="BIH"
                },

                new Drzava()
                {
                    DrzavaId=2,
                    Naziv="Crna Gora",
                    Sifra="MNE"
                },
               new Drzava()
                {
                    DrzavaId=3,
                    Naziv="Albanija",
                    Sifra="ALB"
                },
            });

            modelBuilder.Entity<Grad>().HasData(new List<Grad>
                {
                    new Grad
                    {
                        GradId = 1,
                        DrzavaId=1,
                        Naziv = "Sarajevo",
                        PostanskiBroj=71000

                    },
                    new Grad
                    {
                        GradId = 2,
                        DrzavaId=1,
                        Naziv = "Mostar",
                        PostanskiBroj=88000
                    },
                    new Grad
                    {
                        GradId = 3,
                        Naziv = "Podgorica",
                        DrzavaId=2,
                        PostanskiBroj=82000,
                    },
                    new Grad
                    {
                        GradId = 4,
                        Naziv = "Saranda",
                        DrzavaId=3,
                        PostanskiBroj=52000,
                    },
                    new Grad
                    {
                        GradId = 5,
                        DrzavaId=3,
                        Naziv = "Drač",
                        PostanskiBroj=50000
                    }
                }
            );

            modelBuilder.Entity<Adresa>().HasData(new List<Adresa>
                {
                    new Adresa
                    {
                        AdresaId=1,
                        GradId = 1,
                        Naziv="Avde Jabučice",
                        Broj=6,
                    },
                    new Adresa
                    {
                        AdresaId=2,
                        GradId = 2,
                        Broj=12,
                        Naziv="Džemala Bijedića"
                    },
                    new Adresa
                    {
                        AdresaId=3,
                        GradId = 4,
                        Broj=23,
                        Naziv="Majkl Džordana"
                    },
                    new Adresa
                    {
                        AdresaId=4,
                        GradId = 5,
                        Broj=2,
                        Naziv="Avdije Vršajevića"
                    },
                }
            );

            modelBuilder.Entity<ApartmanTip>().HasData(new List<ApartmanTip>()
            {
                new ApartmanTip()
                {
                    ApartmanTipId=1,
                    ApartmanTipNaziv="Stan"
                },

                new ApartmanTip()
                {
                    ApartmanTipId=2,
                    ApartmanTipNaziv="Kuća"
                },
            });

            var apartman1 = new Apartman()
            {
                ApartmanId = 1,
                Naziv = "Babovina",
                AdresaId = 2,
                ApartmanTipId = 1,
                CheckoutVrijeme = TimeSpan.FromHours(12),
                Cijena = 25,
                ImaBalkon = true,
                ImaParking = false,
                MaxOsoba = 3,
                PetFriendly = false,
                VlasnikId = 1,
                SlikaProfilnaFile = File.ReadAllBytes("../img/apartman1.jpg"),
            };

            modelBuilder.Entity<Apartman>().HasData(apartman1);

            var apartman2 = new Apartman()
            {
                ApartmanId = 2,
                Naziv = "Đedovina",
                AdresaId = 3,
                ApartmanTipId = 1,
                CheckoutVrijeme = TimeSpan.FromHours(12),
                Cijena = 30,
                ImaBalkon = true,
                ImaParking = true,
                MaxOsoba = 4,
                PetFriendly = false,
                VlasnikId = 2,
                SlikaProfilnaFile = File.ReadAllBytes("../img/apartman2.jpg"),

            };

            modelBuilder.Entity<Apartman>().HasData(apartman2);

            var apartman3 = new Apartman()
            {
                ApartmanId = 3,
                Naziv = "PraĐedovina",
                AdresaId = 4,
                ApartmanTipId = 1,
                CheckoutVrijeme = TimeSpan.FromHours(12),
                Cijena = 15,
                ImaBalkon = true,
                ImaParking = true,
                MaxOsoba = 2,
                PetFriendly = false,
                VlasnikId = 2,
                SlikaProfilnaFile = File.ReadAllBytes("../img/apartman3.jpg"),

            };

            modelBuilder.Entity<Apartman>().HasData(apartman3);


            var apartman4 = new Apartman()
            {
                ApartmanId = 4,
                Naziv = "Villa Gorica",
                AdresaId = 1,
                ApartmanTipId = 1,
                CheckoutVrijeme = TimeSpan.FromHours(12),
                Cijena = 5,
                ImaBalkon = false,
                ImaParking = false,
                MaxOsoba = 15,
                PetFriendly = true,
                VlasnikId = 1,
                SlikaProfilnaFile = File.ReadAllBytes("../img/apartman4.jpg"),

            };

            modelBuilder.Entity<Apartman>().HasData(apartman4);

            var rezervacija1 = new Rezervacija()
            {
                RezervacijaId = 1,
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
                GostId = 3,
                Poruka = "Pravim parti drama",
            };
            modelBuilder.Entity<Rezervacija>().HasData(rezervacija1);

            var rezervacija2 = new Rezervacija()
            {
                RezervacijaId = 2,
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
                GostId = 3,
                Poruka = "Bit ću vamo sam i na Gorici s rajom istovremeno, pa ćemo viđet kako će ić",
            };
            modelBuilder.Entity<Rezervacija>().HasData(rezervacija2);
            
        }
    }
}
