using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataTransaksiMei : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDitambahkan", "TanggalDiubah" },
                values: new object[] { 4693500.0, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 94, 73, "https://file/1", 0, 160000.0, 1, 8666500.0, new DateTime(2024, 5, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah gabungan kaum perempuan dirumah Ibu. Marni Aplugi Rayon 1&7, dipimpin oleh Dkn. Orpa M. Bria-P" },
                    { 95, 73, "https://file/1", 0, 87000.0, 1, 8753500.0, new DateTime(2024, 5, 1, 1, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah gabungan kaum perempuan dirumah Ibu. Meytri Boimata Rayon 2, dipimpin oleh Pnt. Nelcy Kamesa-Ballu" },
                    { 96, 73, "https://file/1", 0, 160000.0, 1, 8913500.0, new DateTime(2024, 5, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah gabungan kaum perempuan dirumah Ibu. Yunita Lali Pora Rayon 4, dipimpin oleh Pnt. Rivera Lantik-N" },
                    { 97, 185, "https://file/1", 1, 2000000.0, 1, 6913500.0, new DateTime(2024, 5, 4, 1, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunjangan Ketua Majelis Jemaat  bulan Mei 2024" },
                    { 98, 186, "https://file/1", 1, 1200000.0, 1, 5713500.0, new DateTime(2024, 5, 4, 1, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunjangan Kesejahteraan Pendeta bulan Mei 2024" },
                    { 99, 187, "https://file/1", 1, 750000.0, 1, 4693500.0, new DateTime(2024, 5, 4, 1, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunjangan Kesehatan Pendeta bulan Mei 2024" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPB+4/XAFbPfMM7pLQJe7k76RZlnMyfQFJPJQF6NeoGTvj2RmOyf2jeUp+/SF3gRJA==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENoCgN0hwL/91WUIO2zn0Sr375mjFsCWwGy2E6depIhGvVYWTQaVmrQHEpqqZ1u7Gw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDitambahkan", "TanggalDiubah" },
                values: new object[] { 11767000.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
    }
}
