using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataTransaksiMaret2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Saldo",
                value: 11767000.0);

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 85, 77, "https://file/1", 0, 12000.0, 1, 11340500.0, new DateTime(2024, 3, 1, 1, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah katekasasi reguler di Gereja JLET, dipimpin oleh Pjr. Lusia L. Kassir-Kollis" },
                    { 86, 81, "https://file/1", 0, 138000.0, 1, 11478500.0, new DateTime(2024, 3, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan perhadapan Koster, UPP dan BP Kategorial, Fungsional dan Profesional JLET periode pelayanan 2024-2027 di Gereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 87, 65, "https://file/1", 0, 288500.0, 1, 11767000.0, new DateTime(2024, 3, 1, 1, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah rumah tangga dirumah Bpk. Yeskiel Humau Rayon 2, dipimpin oleh Dkn. Guntur S. Karlau" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMmn+LDrRMmHwH8kAKSEblL69/ta/NN/aaCZ79sIiwWRJWiAM7HTxxRdKG1lnQR9+A==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJpyFJHtK5S+OCVqqYp+45HXjGW7rOyoXDSnILFYUjoC2GsSMqBe98EihYiF+D45ZQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Saldo",
                value: 11328500.0);

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
    }
}
