using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eApartman.Database
{
    public partial class eApartmanContext : DbContext
    {
        public eApartmanContext()
        {
        }

        public eApartmanContext(DbContextOptions<eApartmanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresa> Adresas { get; set; }
        public virtual DbSet<Apartman> Apartmen { get; set; }
        public virtual DbSet<ApartmanSlika> ApartmanSlikas { get; set; }
        public virtual DbSet<ApartmanTip> ApartmanTips { get; set; }
        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual DbSet<Moderator> Moderators { get; set; }
        public virtual DbSet<Popust> Popusts { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Utisak> Utisaks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\MIRZA;Database=eApartman;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Adresa>(entity =>
            {
                entity.ToTable("Adresa");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Adresas)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("fk_grad");
            });

            modelBuilder.Entity<Apartman>(entity =>
            {
                entity.ToTable("Apartman");

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Adresa)
                    .WithMany(p => p.Apartmen)
                    .HasForeignKey(d => d.AdresaId)
                    .HasConstraintName("fk_adresa");

                entity.HasOne(d => d.ApartmanTip)
                    .WithMany(p => p.Apartmen)
                    .HasForeignKey(d => d.ApartmanTipId)
                    .HasConstraintName("fk_apartmantip");

                entity.HasOne(d => d.Vlasnik)
                    .WithMany(p => p.Apartmen)
                    .HasForeignKey(d => d.VlasnikId)
                    .HasConstraintName("fk_vlasnik");
            });

            modelBuilder.Entity<ApartmanSlika>(entity =>
            {
                entity.HasKey(e => e.SlikaId)
                    .HasName("pk_slika");

                entity.ToTable("ApartmanSlika");

                entity.HasOne(d => d.Apartman)
                    .WithMany(p => p.ApartmanSlikas)
                    .HasForeignKey(d => d.ApartmanId)
                    .HasConstraintName("fk_apartman");
            });

            modelBuilder.Entity<ApartmanTip>(entity =>
            {
                entity.ToTable("ApartmanTip");

                entity.Property(e => e.ApartmanTipNaziv)
                    .IsRequired()
                    .HasMaxLength(30);
                
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Sifra).HasMaxLength(3);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("fk_drzava");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<KorisnikUloga>(entity =>
            {
                entity.HasKey(e => new { e.KorisnikId, e.UlogaId })
                    .HasName("pk_korisnikuloga");

                entity.ToTable("KorisnikUloga");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUlogas)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnik");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUlogas)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_uloga");
            });

            modelBuilder.Entity<Moderator>(entity =>
            {
                entity.ToTable("Moderator");

                entity.Property(e => e.ModeratorId).ValueGeneratedNever();

                entity.HasOne(d => d.ModeratorNavigation)
                    .WithOne(p => p.ModeratorModeratorNavigation)
                    .HasForeignKey<Moderator>(d => d.ModeratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_moderatorkorisnik");

                entity.HasOne(d => d.Vlasnik)
                    .WithMany(p => p.ModeratorVlasniks)
                    .HasForeignKey(d => d.VlasnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vlasnikkorisnik");
            });

            modelBuilder.Entity<Popust>(entity =>
            {
                entity.ToTable("Popust");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Procent).HasColumnType("money");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.Property(e => e.BrojDana).HasComputedColumnSql("(datediff(day,[DatumCheckIn],[DatumCheckOut]))", true);

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.DatumCheckIn).HasColumnType("datetime");

                entity.Property(e => e.DatumCheckOut).HasColumnType("datetime");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.GostIme).HasMaxLength(25);

                entity.Property(e => e.GostPrezime).HasMaxLength(25);

                entity.HasOne(d => d.Apartman)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.ApartmanId)
                    .HasConstraintName("fk_apartmanrezervacija");

                entity.HasOne(d => d.Gost)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.GostId)
                    .HasConstraintName("fk_gost");

                entity.HasOne(d => d.Popust)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.PopustId)
                    .HasConstraintName("fk_popust");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.Opis).HasMaxLength(128);

                entity.Property(e => e.UlogaNaziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Utisak>(entity =>
            {
                entity.ToTable("Utisak");

                entity.Property(e => e.UtisakId).ValueGeneratedNever();

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.HasOne(d => d.Apartman)
                    .WithMany(p => p.Utisaks)
                    .HasForeignKey(d => d.ApartmanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_apartmanutisak");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Utisaks)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_korisnikutisak");

                entity.HasOne(d => d.UtisakNavigation)
                    .WithOne(p => p.Utisak)
                    .HasForeignKey<Utisak>(d => d.UtisakId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Utisak__UtisakId__160F4887");
            });

            OnModelCreatingPartial(modelBuilder);

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
                KorisnikId=1,
                Ime = "User",
                Prezime = "Usersky",
                Username = "user",
                Email = "user@example.com",
                Telefon = "062-225-883",
                Status = true,
                DatumRegistracije = DateTime.Now,
            };

            SetupService.DodajPassword(user, "user");
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

            SetupService.DodajPassword(admin, "admin");
            modelBuilder.Entity<Korisnik>().HasData(admin);


            //Gost gost
            var gost = new Korisnik()
            {
                KorisnikId=3,
                Ime = "Ado",
                Prezime = "Gegaj",
                Username = "gost",
                Email = "gost@example.com",
                Telefon = "063-225-883",
                Status = true,
                DatumRegistracije = DateTime.Now,
            };

            SetupService.DodajPassword(gost, "gost");
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
                ApartmanId=1,
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
                SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman1.jpg"),
            };

            modelBuilder.Entity<Apartman>().HasData(apartman1);

            var apartman2 = new Apartman()
            {
                ApartmanId=2,
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
                SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman2.jpg"),

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
                SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman3.jpg"),

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
                SlikaProfilnaFile = File.ReadAllBytes("Slike/apartman4.jpg"),

            };

            modelBuilder.Entity<Apartman>().HasData(apartman4);



        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
