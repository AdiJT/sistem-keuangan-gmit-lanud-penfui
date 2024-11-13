using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataTransaksi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 2,
                column: "AkunId",
                value: 101);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "TanggalDitambahkan",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "TblBuktiTransaksi",
                columns: new[] { "Id", "FileBukti", "Jenis", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 5, "http://locahost:1704/file/5", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 3" },
                    { 6, "http://locahost:1704/file/6", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 4" },
                    { 7, "http://locahost:1704/file/7", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 5" },
                    { 8, "http://locahost:1704/file/8", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 6" },
                    { 9, "http://locahost:1704/file/9", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 7" },
                    { 10, "http://locahost:1704/file/10", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 8" },
                    { 11, "http://locahost:1704/file/11", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 9" },
                    { 12, "http://locahost:1704/file/12", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 10" },
                    { 13, "http://locahost:1704/file/13", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 11" },
                    { 14, "http://locahost:1704/file/14", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 12" },
                    { 15, "http://locahost:1704/file/15", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 13" },
                    { 16, "http://locahost:1704/file/16", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 14" },
                    { 17, "http://locahost:1704/file/17", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 15" },
                    { 18, "http://locahost:1704/file/18", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 16" },
                    { 19, "http://locahost:1704/file/19", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 17" },
                    { 20, "http://locahost:1704/file/20", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 18" },
                    { 21, "http://locahost:1704/file/21", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 19" },
                    { 22, "http://locahost:1704/file/22", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 20" },
                    { 23, "http://locahost:1704/file/23", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 21" },
                    { 24, "http://locahost:1704/file/24", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 22" },
                    { 25, "http://locahost:1704/file/25", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 23" },
                    { 26, "http://locahost:1704/file/26", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 24" },
                    { 27, "http://locahost:1704/file/27", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 25" },
                    { 28, "http://locahost:1704/file/28", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 26" },
                    { 29, "http://locahost:1704/file/29", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 27" },
                    { 30, "http://locahost:1704/file/30", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 28" },
                    { 31, "http://locahost:1704/file/31", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 29" },
                    { 32, "http://locahost:1704/file/32", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 30" },
                    { 33, "http://locahost:1704/file/33", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 31" },
                    { 34, "http://locahost:1704/file/34", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 32" },
                    { 35, "http://locahost:1704/file/35", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 33" },
                    { 36, "http://locahost:1704/file/36", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 34" },
                    { 37, "http://locahost:1704/file/37", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 35" },
                    { 38, "http://locahost:1704/file/38", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 36" },
                    { 39, "http://locahost:1704/file/39", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 37" },
                    { 40, "http://locahost:1704/file/40", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 38" },
                    { 41, "http://locahost:1704/file/41", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 39" },
                    { 42, "http://locahost:1704/file/42", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 40" },
                    { 43, "http://locahost:1704/file/43", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 41" },
                    { 44, "http://locahost:1704/file/44", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 42" },
                    { 45, "http://locahost:1704/file/45", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 43" },
                    { 46, "http://locahost:1704/file/46", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 44" },
                    { 47, "http://locahost:1704/file/47", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 45" },
                    { 48, "http://locahost:1704/file/48", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 46" },
                    { 49, "http://locahost:1704/file/49", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 47" },
                    { 50, "http://locahost:1704/file/50", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 48" },
                    { 51, "http://locahost:1704/file/51", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 49" },
                    { 52, "http://locahost:1704/file/52", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 50" },
                    { 53, "http://locahost:1704/file/53", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 51" },
                    { 54, "http://locahost:1704/file/54", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 52" },
                    { 55, "http://locahost:1704/file/55", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 53" },
                    { 56, "http://locahost:1704/file/56", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 54" },
                    { 57, "http://locahost:1704/file/57", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 55" },
                    { 58, "http://locahost:1704/file/58", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 56" },
                    { 59, "http://locahost:1704/file/59", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 57" },
                    { 60, "http://locahost:1704/file/60", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 58" },
                    { 61, "http://locahost:1704/file/61", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 59" },
                    { 62, "http://locahost:1704/file/62", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 60" },
                    { 63, "http://locahost:1704/file/63", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 61" },
                    { 64, "http://locahost:1704/file/64", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 62" },
                    { 65, "http://locahost:1704/file/65", 0, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 63" },
                    { 66, "http://locahost:1704/file/66", 0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 64" },
                    { 67, "http://locahost:1704/file/67", 0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 65" },
                    { 68, "http://locahost:1704/file/68", 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 3" },
                    { 69, "http://locahost:1704/file/69", 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 4" },
                    { 70, "http://locahost:1704/file/70", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 5" },
                    { 71, "http://locahost:1704/file/71", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 6" },
                    { 72, "http://locahost:1704/file/72", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 7" },
                    { 73, "http://locahost:1704/file/73", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 8" },
                    { 74, "http://locahost:1704/file/74", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 9" }
                });

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDiubah" },
                values: new object[] { 10852500.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Uraian" },
                values: new object[] { 16, 5000.0, 6966500.0, "Terima nazar Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEML6iwhBAPxjmfsNgyW5GGqTJSs7yRymxTjd/i8wgKvIlyZarG0/qeZJ9YoCra1SvA==");

            migrationBuilder.InsertData(
                table: "TblBelanja",
                columns: new[] { "Id", "AkunId", "BuktiTransaksiId", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 3, 109, 68, 40000.0, 1, 11286500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs MCB Broco 6A" },
                    { 4, 109, 69, 5000.0, 1, 11281500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs Box MCB" },
                    { 5, 100, 70, 71600.0, 1, 11209900.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 4 kg gula pasir timbang @Rp. 17.900,-" },
                    { 6, 100, 71, 12500.0, 1, 11197400.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs teh sariwangi (50P)" },
                    { 7, 100, 72, 59900.0, 1, 11137500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs tugu buaya spesial (1 kg)" },
                    { 8, 100, 73, 30000.0, 1, 11107500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 30 potong kue @Rp. 1.000,-" },
                    { 9, 101, 74, 255000.0, 1, 10852500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-" }
                });

            migrationBuilder.InsertData(
                table: "TblPenerimaan",
                columns: new[] { "Id", "AkunId", "BuktiTransaksiId", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 3, 16, 5, 10000.0, 1, 6976500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 2" },
                    { 4, 18, 6, 100000.0, 1, 7076500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 3" },
                    { 5, 19, 7, 10000.0, 1, 7086500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 4" },
                    { 6, 16, 8, 5000.0, 1, 7091500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 5" },
                    { 7, 17, 9, 20000.0, 1, 7111500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 6" },
                    { 8, 21, 10, 30000.0, 1, 7141500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 1" },
                    { 9, 21, 11, 50000.0, 1, 7191500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 2" },
                    { 10, 21, 12, 10000.0, 1, 7201500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 3" },
                    { 11, 21, 13, 9000.0, 1, 7210500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 4" },
                    { 12, 21, 14, 5000.0, 1, 7215500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 5" },
                    { 13, 21, 15, 10000.0, 1, 7225500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 6" },
                    { 14, 21, 16, 50000.0, 1, 7275500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 7" },
                    { 15, 22, 17, 10000.0, 1, 7285500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 1" },
                    { 16, 22, 18, 5000.0, 1, 7290500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 2" },
                    { 17, 22, 19, 10000.0, 1, 7300500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 3" },
                    { 18, 22, 20, 50000.0, 1, 7350500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 4" },
                    { 19, 22, 21, 50000.0, 1, 7400500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 5" },
                    { 20, 22, 22, 100000.0, 1, 7500500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 6" },
                    { 21, 22, 23, 10000.0, 1, 7510500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 7" },
                    { 22, 22, 24, 10000.0, 1, 7520500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 8" },
                    { 23, 22, 25, 10000.0, 1, 7530500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 9" },
                    { 24, 22, 26, 10000.0, 1, 7540500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 10" },
                    { 25, 50, 27, 50000.0, 1, 7590500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Oktovianus Metboki Rayon 5" },
                    { 26, 50, 28, 77000.0, 1, 7667500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Elisabeth Tualaka Rayon 7" },
                    { 27, 50, 29, 72000.0, 1, 7739500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel AS Rayon 2" },
                    { 28, 50, 30, 10000.0, 1, 7749500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Aranci Suek Rayon 4" },
                    { 29, 50, 31, 50000.0, 1, 7799500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Bpk. Dominggus Kole Rayon 7" },
                    { 30, 50, 32, 300000.0, 1, 8099500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel. IB Rayon 4" },
                    { 31, 50, 33, 50000.0, 1, 8149500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Naomi A. Henuk Rayon 2" },
                    { 32, 50, 34, 100000.0, 1, 8249500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 33, 50, 35, 69000.0, 1, 8318500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marcus Baria Rayon 7" },
                    { 34, 50, 36, 150000.0, 1, 8468500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Annie M. Malonda Rayon 7" },
                    { 35, 50, 37, 50000.0, 1, 8518500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Mikhael Nenotek Rayon 5" },
                    { 36, 50, 38, 50000.0, 1, 8568500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 37, 50, 39, 50000.0, 1, 8618500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 38, 50, 40, 30000.0, 1, 8648500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 39, 50, 41, 10000.0, 1, 8658500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Melkisedek Kasse Rayon 4" },
                    { 40, 50, 42, 57000.0, 1, 8715500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Nur M. Tasrap Rayon 5" },
                    { 41, 50, 43, 16000.0, 1, 8731500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marthen Patipellohy Rayon 5" },
                    { 42, 50, 44, 60000.0, 1, 8791500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Benyamin Sua Rayon 3" },
                    { 43, 50, 45, 100000.0, 1, 8891500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama Rayon 7" },
                    { 44, 50, 46, 50000.0, 1, 8941500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Daud Ludji Rayon 4" },
                    { 45, 50, 47, 10000.0, 1, 8951500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 1" },
                    { 46, 50, 48, 111000.0, 1, 9062500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 2" },
                    { 47, 50, 49, 10000.0, 1, 9072500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 3" },
                    { 48, 50, 50, 10000.0, 1, 9082500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 4" },
                    { 49, 50, 51, 10000.0, 1, 9092500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 5" },
                    { 50, 50, 52, 20000.0, 1, 9112500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 6" },
                    { 51, 50, 53, 2000.0, 1, 9114500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 7" },
                    { 52, 50, 54, 64000.0, 1, 9178500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 8" },
                    { 53, 50, 55, 10000.0, 1, 9188500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 9" },
                    { 54, 50, 56, 10000.0, 1, 9198500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 10" },
                    { 55, 50, 57, 10000.0, 1, 9208500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 11" },
                    { 56, 44, 58, 100000.0, 1, 9308500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama" },
                    { 57, 44, 59, 30000.0, 1, 9338500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 58, 44, 60, 25000.0, 1, 9363500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibu. Febei Nuban Rayon 7" },
                    { 59, 44, 61, 100000.0, 1, 9463500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Kristian Walu Logo Rayon 1" },
                    { 60, 44, 62, 250000.0, 1, 9713500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Max Warruw Rayon 7" },
                    { 61, 14, 63, 100000.0, 1, 9813500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur ULTAH ke-79" },
                    { 62, 44, 64, 400000.0, 1, 10213500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4" },
                    { 63, 10, 65, 791000.0, 1, 10354500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 64, 81, 66, 643000.0, 1, 10997500.0, new DateOnly(2024, 1, 3), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 65, 14, 67, 329000.0, 1, 11326500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 2,
                column: "AkunId",
                value: 141);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "TanggalDitambahkan",
                value: new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDiubah" },
                values: new object[] { 6031500.0, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Uraian" },
                values: new object[] { 21, 30000.0, 7141000.0, "Terima perpuluhan tidak tetap Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEE7MmboN6aGpSbwSJpjkOqy0nJQVowsFu3fnUjyeWJ+eZiFQkQLikf6T2EQlBqAAPw==");
        }
    }
}
