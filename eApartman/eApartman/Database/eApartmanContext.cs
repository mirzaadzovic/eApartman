using System;
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
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
