using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eApartman.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apartman",
                keyColumn: "ApartmanId",
                keyValue: 3,
                column: "AdresaId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 11, 19, 23, 28, 49, 651, DateTimeKind.Local).AddTicks(125), "NQ6O4To5Kjw68Mg+j2ne97IHuW0=", "LMQj/Fj187Z0/6eSfri03w==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 11, 19, 23, 28, 49, 673, DateTimeKind.Local).AddTicks(5029), "3NpcU3oFXmv4AIN2uZcy+80cFPI=", "T+4Pi+BKyEcp54dL5iHR4Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 11, 19, 23, 28, 49, 673, DateTimeKind.Local).AddTicks(7357), "31oNxDrFdOtrJ96rBJIlvPIkH10=", "0QR1iruyKedvYTQKnO9jvg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Apartman",
                keyColumn: "ApartmanId",
                keyValue: 3,
                column: "AdresaId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 11, 19, 23, 13, 5, 225, DateTimeKind.Local).AddTicks(9281), "2rFxyaWbF0sNmB9ysgOf99ZjldU=", "53QIv9TA+pUWxhsIQ0B+Eg==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 11, 19, 23, 13, 5, 250, DateTimeKind.Local).AddTicks(9035), "YkdBcx41TTnFeCOCInc4D793kIg=", "L+ou3El22YUeIwKQCxHKOQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 11, 19, 23, 13, 5, 251, DateTimeKind.Local).AddTicks(1340), "q7QFfMpobbgxSjxTaWiuCqnoW+Q=", "Z0dMNPacBEgy3GXDjqtS/A==" });
        }
    }
}
