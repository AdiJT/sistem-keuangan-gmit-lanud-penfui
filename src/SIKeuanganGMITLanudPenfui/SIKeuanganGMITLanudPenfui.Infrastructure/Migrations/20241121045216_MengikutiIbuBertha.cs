using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MengikutiIbuBertha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBelanja_TblBuktiTransaksi_BuktiTransaksiId",
                table: "TblBelanja");

            migrationBuilder.DropForeignKey(
                name: "FK_TblPenerimaan_TblBuktiTransaksi_BuktiTransaksiId",
                table: "TblPenerimaan");

            migrationBuilder.DropTable(
                name: "TblBuktiTransaksi");

            migrationBuilder.DropIndex(
                name: "IX_TblPenerimaan_BuktiTransaksiId",
                table: "TblPenerimaan");

            migrationBuilder.DropIndex(
                name: "IX_TblBelanja_BuktiTransaksiId",
                table: "TblBelanja");

            migrationBuilder.DropColumn(
                name: "BuktiTransaksiId",
                table: "TblPenerimaan");

            migrationBuilder.DropColumn(
                name: "BuktiTransaksiId",
                table: "TblBelanja");

            migrationBuilder.AddColumn<string>(
                name: "FileBukti",
                table: "TblPenerimaan",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileBukti",
                table: "TblBelanja",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 5,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 6,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 7,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 8,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 9,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 5,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 6,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 7,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 8,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 9,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 10,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 11,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 12,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 13,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 14,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 15,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 16,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 17,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 18,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 19,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 20,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 21,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 22,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 23,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 24,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 25,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 26,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 27,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 28,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 29,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 30,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 31,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 32,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 33,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 34,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 35,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 36,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 37,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 38,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 39,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 40,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 41,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 42,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 43,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 44,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 45,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 46,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 47,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 48,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 49,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 50,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 51,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 52,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 53,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 54,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 55,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 56,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 57,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 58,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 59,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 60,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 61,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 62,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 63,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 64,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 65,
                column: "FileBukti",
                value: "https://file/1");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOCTxgXqk73WUZols40uX74ORthaWhXVHXv6lR6HMc/atpe4egW8erXcljgWGh/6cg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileBukti",
                table: "TblPenerimaan");

            migrationBuilder.DropColumn(
                name: "FileBukti",
                table: "TblBelanja");

            migrationBuilder.AddColumn<int>(
                name: "BuktiTransaksiId",
                table: "TblPenerimaan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuktiTransaksiId",
                table: "TblBelanja",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TblBuktiTransaksi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileBukti = table.Column<string>(type: "text", nullable: false),
                    Jenis = table.Column<int>(type: "integer", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Uraian = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBuktiTransaksi", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 1,
                column: "BuktiTransaksiId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 2,
                column: "BuktiTransaksiId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 3,
                column: "BuktiTransaksiId",
                value: 68);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 4,
                column: "BuktiTransaksiId",
                value: 69);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 5,
                column: "BuktiTransaksiId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 6,
                column: "BuktiTransaksiId",
                value: 71);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 7,
                column: "BuktiTransaksiId",
                value: 72);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 8,
                column: "BuktiTransaksiId",
                value: 73);

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 9,
                column: "BuktiTransaksiId",
                value: 74);

            migrationBuilder.InsertData(
                table: "TblBuktiTransaksi",
                columns: new[] { "Id", "FileBukti", "Jenis", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 1, "http://locahost:1704/file/1", 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 1" },
                    { 2, "http://locahost:1704/file/2", 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 2" },
                    { 3, "http://locahost:1704/file/3", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 1" },
                    { 4, "http://locahost:1704/file/4", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 2" },
                    { 5, "http://locahost:1704/file/5", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 3" },
                    { 6, "http://locahost:1704/file/6", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 4" },
                    { 7, "http://locahost:1704/file/7", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 5" },
                    { 8, "http://locahost:1704/file/8", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 6" },
                    { 9, "http://locahost:1704/file/9", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 7" },
                    { 10, "http://locahost:1704/file/10", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 8" },
                    { 11, "http://locahost:1704/file/11", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 9" },
                    { 12, "http://locahost:1704/file/12", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 10" },
                    { 13, "http://locahost:1704/file/13", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 11" },
                    { 14, "http://locahost:1704/file/14", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 12" },
                    { 15, "http://locahost:1704/file/15", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 13" },
                    { 16, "http://locahost:1704/file/16", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 14" },
                    { 17, "http://locahost:1704/file/17", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 15" },
                    { 18, "http://locahost:1704/file/18", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 16" },
                    { 19, "http://locahost:1704/file/19", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 17" },
                    { 20, "http://locahost:1704/file/20", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 18" },
                    { 21, "http://locahost:1704/file/21", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 19" },
                    { 22, "http://locahost:1704/file/22", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 20" },
                    { 23, "http://locahost:1704/file/23", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 21" },
                    { 24, "http://locahost:1704/file/24", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 22" },
                    { 25, "http://locahost:1704/file/25", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 23" },
                    { 26, "http://locahost:1704/file/26", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 24" },
                    { 27, "http://locahost:1704/file/27", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 25" },
                    { 28, "http://locahost:1704/file/28", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 26" },
                    { 29, "http://locahost:1704/file/29", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 27" },
                    { 30, "http://locahost:1704/file/30", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 28" },
                    { 31, "http://locahost:1704/file/31", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 29" },
                    { 32, "http://locahost:1704/file/32", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 30" },
                    { 33, "http://locahost:1704/file/33", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 31" },
                    { 34, "http://locahost:1704/file/34", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 32" },
                    { 35, "http://locahost:1704/file/35", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 33" },
                    { 36, "http://locahost:1704/file/36", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 34" },
                    { 37, "http://locahost:1704/file/37", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 35" },
                    { 38, "http://locahost:1704/file/38", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 36" },
                    { 39, "http://locahost:1704/file/39", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 37" },
                    { 40, "http://locahost:1704/file/40", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 38" },
                    { 41, "http://locahost:1704/file/41", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 39" },
                    { 42, "http://locahost:1704/file/42", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 40" },
                    { 43, "http://locahost:1704/file/43", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 41" },
                    { 44, "http://locahost:1704/file/44", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 42" },
                    { 45, "http://locahost:1704/file/45", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 43" },
                    { 46, "http://locahost:1704/file/46", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 44" },
                    { 47, "http://locahost:1704/file/47", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 45" },
                    { 48, "http://locahost:1704/file/48", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 46" },
                    { 49, "http://locahost:1704/file/49", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 47" },
                    { 50, "http://locahost:1704/file/50", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 48" },
                    { 51, "http://locahost:1704/file/51", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 49" },
                    { 52, "http://locahost:1704/file/52", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 50" },
                    { 53, "http://locahost:1704/file/53", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 51" },
                    { 54, "http://locahost:1704/file/54", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 52" },
                    { 55, "http://locahost:1704/file/55", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 53" },
                    { 56, "http://locahost:1704/file/56", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 54" },
                    { 57, "http://locahost:1704/file/57", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 55" },
                    { 58, "http://locahost:1704/file/58", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 56" },
                    { 59, "http://locahost:1704/file/59", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 57" },
                    { 60, "http://locahost:1704/file/60", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 58" },
                    { 61, "http://locahost:1704/file/61", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 59" },
                    { 62, "http://locahost:1704/file/62", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 60" },
                    { 63, "http://locahost:1704/file/63", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 61" },
                    { 64, "http://locahost:1704/file/64", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 62" },
                    { 65, "http://locahost:1704/file/65", 0, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 63" },
                    { 66, "http://locahost:1704/file/66", 0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 64" },
                    { 67, "http://locahost:1704/file/67", 0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Penerimaan 65" },
                    { 68, "http://locahost:1704/file/68", 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 3" },
                    { 69, "http://locahost:1704/file/69", 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 4" },
                    { 70, "http://locahost:1704/file/70", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 5" },
                    { 71, "http://locahost:1704/file/71", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 6" },
                    { 72, "http://locahost:1704/file/72", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 7" },
                    { 73, "http://locahost:1704/file/73", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 8" },
                    { 74, "http://locahost:1704/file/74", 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bukti Transaksi Belanja 9" }
                });

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 1,
                column: "BuktiTransaksiId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 2,
                column: "BuktiTransaksiId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 3,
                column: "BuktiTransaksiId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 4,
                column: "BuktiTransaksiId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 5,
                column: "BuktiTransaksiId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 6,
                column: "BuktiTransaksiId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 7,
                column: "BuktiTransaksiId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 8,
                column: "BuktiTransaksiId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 9,
                column: "BuktiTransaksiId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 10,
                column: "BuktiTransaksiId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 11,
                column: "BuktiTransaksiId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 12,
                column: "BuktiTransaksiId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 13,
                column: "BuktiTransaksiId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 14,
                column: "BuktiTransaksiId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 15,
                column: "BuktiTransaksiId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 16,
                column: "BuktiTransaksiId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 17,
                column: "BuktiTransaksiId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 18,
                column: "BuktiTransaksiId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 19,
                column: "BuktiTransaksiId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 20,
                column: "BuktiTransaksiId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 21,
                column: "BuktiTransaksiId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 22,
                column: "BuktiTransaksiId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 23,
                column: "BuktiTransaksiId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 24,
                column: "BuktiTransaksiId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 25,
                column: "BuktiTransaksiId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 26,
                column: "BuktiTransaksiId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 27,
                column: "BuktiTransaksiId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 28,
                column: "BuktiTransaksiId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 29,
                column: "BuktiTransaksiId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 30,
                column: "BuktiTransaksiId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 31,
                column: "BuktiTransaksiId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 32,
                column: "BuktiTransaksiId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 33,
                column: "BuktiTransaksiId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 34,
                column: "BuktiTransaksiId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 35,
                column: "BuktiTransaksiId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 36,
                column: "BuktiTransaksiId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 37,
                column: "BuktiTransaksiId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 38,
                column: "BuktiTransaksiId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 39,
                column: "BuktiTransaksiId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 40,
                column: "BuktiTransaksiId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 41,
                column: "BuktiTransaksiId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 42,
                column: "BuktiTransaksiId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 43,
                column: "BuktiTransaksiId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 44,
                column: "BuktiTransaksiId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 45,
                column: "BuktiTransaksiId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 46,
                column: "BuktiTransaksiId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 47,
                column: "BuktiTransaksiId",
                value: 49);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 48,
                column: "BuktiTransaksiId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 49,
                column: "BuktiTransaksiId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 50,
                column: "BuktiTransaksiId",
                value: 52);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 51,
                column: "BuktiTransaksiId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 52,
                column: "BuktiTransaksiId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 53,
                column: "BuktiTransaksiId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 54,
                column: "BuktiTransaksiId",
                value: 56);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 55,
                column: "BuktiTransaksiId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 56,
                column: "BuktiTransaksiId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 57,
                column: "BuktiTransaksiId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 58,
                column: "BuktiTransaksiId",
                value: 60);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 59,
                column: "BuktiTransaksiId",
                value: 61);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 60,
                column: "BuktiTransaksiId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 61,
                column: "BuktiTransaksiId",
                value: 63);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 62,
                column: "BuktiTransaksiId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 63,
                column: "BuktiTransaksiId",
                value: 65);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 64,
                column: "BuktiTransaksiId",
                value: 66);

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 65,
                column: "BuktiTransaksiId",
                value: 67);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHG3Z4Qic4hXvGsxi4WU9SXG0+I8E3yZVguKOAzL91jF4x596lXm+78hJM1P567s1w==");

            migrationBuilder.CreateIndex(
                name: "IX_TblPenerimaan_BuktiTransaksiId",
                table: "TblPenerimaan",
                column: "BuktiTransaksiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblBelanja_BuktiTransaksiId",
                table: "TblBelanja",
                column: "BuktiTransaksiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBelanja_TblBuktiTransaksi_BuktiTransaksiId",
                table: "TblBelanja",
                column: "BuktiTransaksiId",
                principalTable: "TblBuktiTransaksi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblPenerimaan_TblBuktiTransaksi_BuktiTransaksiId",
                table: "TblPenerimaan",
                column: "BuktiTransaksiId",
                principalTable: "TblBuktiTransaksi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
