using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahEntitasBuktiTransaksi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Jenis = table.Column<int>(type: "integer", nullable: false),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    FileBukti = table.Column<string>(type: "text", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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

            migrationBuilder.InsertData(
                table: "TblBuktiTransaksi",
                columns: new[] { "Id", "FileBukti", "Jenis", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 1, "http://locahost:1704/file/1", 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 1" },
                    { 2, "http://locahost:1704/file/2", 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Belanja 2" },
                    { 3, "http://locahost:1704/file/3", 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 1" },
                    { 4, "http://locahost:1704/file/4", 0, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bukti Transaksi Penerimaan 2" }
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
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECfupaZ2lm+Pvyqa/DmVGI9kZ3pqO+IjKrHrvhRDZDOWTkBkcFUlsUSdmQ9hXRHu6A==");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENL/e9VnPGFr00u0MUUE5GYdDuk71OPcbQYimuqedtkZG9NTYuk6qi1o7Uqy5LXOIw==");
        }
    }
}
