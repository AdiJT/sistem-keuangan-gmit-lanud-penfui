using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataTransaksiApril : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 88, 54, "https://file/1", 0, 469500.0, 1, 12236500.0, new DateTime(2024, 4, 1, 1, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolekte Ibadah Syukur Paskah" },
                    { 89, 19, "https://file/1", 0, 20000.0, 1, 12256500.0, new DateTime(2024, 4, 1, 1, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama" },
                    { 90, 21, "https://file/1", 0, 200000.0, 1, 12456500.0, new DateTime(2024, 4, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama" },
                    { 91, 185, "https://file/1", 1, 2000000.0, 1, 10456500.0, new DateTime(2024, 4, 1, 1, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunjangan Ketua Majelis Jemaat  bulan April 2024" },
                    { 92, 186, "https://file/1", 1, 1200000.0, 1, 9256500.0, new DateTime(2024, 4, 1, 1, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunjangan Kesejahteraan Pendeta bulan April 2024" },
                    { 93, 187, "https://file/1", 1, 750000.0, 1, 8506500.0, new DateTime(2024, 4, 1, 1, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunjangan Kesehatan Pendeta bulan April 2024" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENBXgJQ6yIHz8rW5UT7gYWnMa98Jroi9iEfNXMegIp95QTACLJflS3TifYYOOXbl2A==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFVbDZz1nnRYbF9k7ScHST6g7kDF6idMUBVv+84nc7BTPVtXA2z01+swxje6IkEEcw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 93);

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
    }
}
