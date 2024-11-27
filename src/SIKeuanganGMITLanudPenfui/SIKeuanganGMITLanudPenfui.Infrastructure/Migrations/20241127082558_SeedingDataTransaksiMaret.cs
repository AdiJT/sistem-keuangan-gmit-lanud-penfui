using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataTransaksiMaret : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDiubah" },
                values: new object[] { 11328500.0, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 80, 181, "https://file/1", 1, 500.0, 1, 11512500.0, new DateTime(2024, 3, 1, 1, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 pcs Kantong Kresek Kharisma Besar" },
                    { 81, 181, "https://file/1", 1, 60000.0, 1, 11452500.0, new DateTime(2024, 3, 1, 1, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pcs Rumput PL-923 @Rp. 20.000,-" },
                    { 82, 181, "https://file/1", 1, 72000.0, 1, 11380500.0, new DateTime(2024, 3, 1, 1, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3 pcs Bunga XH-24628 @Rp. 24.000,-" },
                    { 83, 181, "https://file/1", 1, 34000.0, 1, 11346500.0, new DateTime(2024, 3, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 pcs Rumput 2509 @Rp. 17.000,-" },
                    { 84, 181, "https://file/1", 1, 18000.0, 1, 11328500.0, new DateTime(2024, 3, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 pcs Rumput PL940" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECDbEgSWBQggg4afONmwxkddyQyNYAP2d+WvvY57178RiZUaK0hrHoWS30i7GK4A+Q==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEIYfjTmpClIwowmB6VsygGALNjbSZe/eoNHnvHEPykSvCH1Qe40bDlnKAvD01Ijxw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDiubah" },
                values: new object[] { 11513000.0, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMgjTl1Vheh75bs/hVBV5ypRXumhnDxsr37m8jflX5yJ0yHE0dlIlBWbptR24V8sXg==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHRsNuaXhf/rYxJXPpj3N+6gWWGubLwf072Rh3l1w1iiBXyvYK9TOHb022/xnz+4nA==");
        }
    }
}
