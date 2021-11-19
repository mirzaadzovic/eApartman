using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eApartman.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApartmanTip",
                columns: table => new
                {
                    ApartmanTipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmanTipNaziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmanTip", x => x.ApartmanTipId);
                });

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sifra = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DatumRegistracije = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Popust",
                columns: table => new
                {
                    PopustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Procent = table.Column<decimal>(type: "money", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popust", x => x.PopustId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlogaNaziv = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostanskiBroj = table.Column<int>(type: "int", nullable: true),
                    DrzavaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "fk_drzava",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Moderator",
                columns: table => new
                {
                    ModeratorId = table.Column<int>(type: "int", nullable: false),
                    VlasnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moderator", x => x.ModeratorId);
                    table.ForeignKey(
                        name: "fk_moderatorkorisnik",
                        column: x => x.ModeratorId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_vlasnikkorisnik",
                        column: x => x.VlasnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloga",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_korisnikuloga", x => new { x.KorisnikId, x.UlogaId });
                    table.ForeignKey(
                        name: "fk_korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_uloga",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    AdresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Broj = table.Column<int>(type: "int", nullable: false),
                    GradId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.AdresaId);
                    table.ForeignKey(
                        name: "fk_grad",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apartman",
                columns: table => new
                {
                    ApartmanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VlasnikId = table.Column<int>(type: "int", nullable: true),
                    AdresaId = table.Column<int>(type: "int", nullable: true),
                    MaxOsoba = table.Column<int>(type: "int", nullable: false),
                    ImaBalkon = table.Column<bool>(type: "bit", nullable: false),
                    ImaParking = table.Column<bool>(type: "bit", nullable: false),
                    PetFriendly = table.Column<bool>(type: "bit", nullable: false),
                    CheckoutVrijeme = table.Column<TimeSpan>(type: "time", nullable: true),
                    Cijena = table.Column<decimal>(type: "money", nullable: false),
                    SlikaProfilnaFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaProfilnaThumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ApartmanTipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartman", x => x.ApartmanId);
                    table.ForeignKey(
                        name: "fk_adresa",
                        column: x => x.AdresaId,
                        principalTable: "Adresa",
                        principalColumn: "AdresaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_apartmantip",
                        column: x => x.ApartmanTipId,
                        principalTable: "ApartmanTip",
                        principalColumn: "ApartmanTipId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_vlasnik",
                        column: x => x.VlasnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApartmanSlika",
                columns: table => new
                {
                    SlikaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlikaFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ApartmanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_slika", x => x.SlikaId);
                    table.ForeignKey(
                        name: "fk_apartman",
                        column: x => x.ApartmanId,
                        principalTable: "Apartman",
                        principalColumn: "ApartmanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GostId = table.Column<int>(type: "int", nullable: true),
                    ApartmanId = table.Column<int>(type: "int", nullable: true),
                    Poruka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojOsoba = table.Column<int>(type: "int", nullable: false),
                    DatumCheckIn = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumCheckOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    BrojDana = table.Column<int>(type: "int", nullable: true, computedColumnSql: "(datediff(day,[DatumCheckIn],[DatumCheckOut]))", stored: true),
                    Izvrsena = table.Column<bool>(type: "bit", nullable: false),
                    Otkazana = table.Column<bool>(type: "bit", nullable: false),
                    Cijena = table.Column<decimal>(type: "money", nullable: true),
                    PopustId = table.Column<int>(type: "int", nullable: true),
                    GostIme = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GostPrezime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "fk_apartmanrezervacija",
                        column: x => x.ApartmanId,
                        principalTable: "Apartman",
                        principalColumn: "ApartmanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_gost",
                        column: x => x.GostId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_popust",
                        column: x => x.PopustId,
                        principalTable: "Popust",
                        principalColumn: "PopustId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Utisak",
                columns: table => new
                {
                    UtisakId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    ApartmanId = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OcjenaWiFi = table.Column<int>(type: "int", nullable: true),
                    OcjenaLokacija = table.Column<int>(type: "int", nullable: true),
                    OcjenaCistoca = table.Column<int>(type: "int", nullable: true),
                    OcjenaVlasnik = table.Column<int>(type: "int", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utisak", x => x.UtisakId);
                    table.ForeignKey(
                        name: "FK__Utisak__UtisakId__160F4887",
                        column: x => x.UtisakId,
                        principalTable: "Rezervacija",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_apartmanutisak",
                        column: x => x.ApartmanId,
                        principalTable: "Apartman",
                        principalColumn: "ApartmanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_korisnikutisak",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresa_GradId",
                table: "Adresa",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartman_AdresaId",
                table: "Apartman",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartman_ApartmanTipId",
                table: "Apartman",
                column: "ApartmanTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartman_VlasnikId",
                table: "Apartman",
                column: "VlasnikId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmanSlika_ApartmanId",
                table: "ApartmanSlika",
                column: "ApartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaId",
                table: "Grad",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Moderator_VlasnikId",
                table: "Moderator",
                column: "VlasnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_ApartmanId",
                table: "Rezervacija",
                column: "ApartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_GostId",
                table: "Rezervacija",
                column: "GostId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PopustId",
                table: "Rezervacija",
                column: "PopustId");

            migrationBuilder.CreateIndex(
                name: "IX_Utisak_ApartmanId",
                table: "Utisak",
                column: "ApartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Utisak_KorisnikId",
                table: "Utisak",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmanSlika");

            migrationBuilder.DropTable(
                name: "KorisnikUloga");

            migrationBuilder.DropTable(
                name: "Moderator");

            migrationBuilder.DropTable(
                name: "Utisak");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Apartman");

            migrationBuilder.DropTable(
                name: "Popust");

            migrationBuilder.DropTable(
                name: "Adresa");

            migrationBuilder.DropTable(
                name: "ApartmanTip");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
