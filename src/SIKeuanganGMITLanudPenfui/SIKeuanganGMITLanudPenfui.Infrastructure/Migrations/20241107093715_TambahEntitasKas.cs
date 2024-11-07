using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahEntitasKas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KasId",
                table: "TblPenerimaan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalDitambahkan",
                table: "TblPenerimaan",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblPenerimaan",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "KasId",
                table: "TblBelanja",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalDitambahkan",
                table: "TblBelanja",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblBelanja",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TblKas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Saldo = table.Column<double>(type: "double precision", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KasId", "TanggalDitambahkan", "TanggalDiubah" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KasId", "TanggalDitambahkan", "TanggalDiubah" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TblKas",
                columns: new[] { "Id", "Saldo", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 1, 6031500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kas Bank GMIT Lanud" });

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KasId", "TanggalDitambahkan", "TanggalDiubah" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KasId", "TanggalDitambahkan", "TanggalDiubah" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENL/e9VnPGFr00u0MUUE5GYdDuk71OPcbQYimuqedtkZG9NTYuk6qi1o7Uqy5LXOIw==");

            migrationBuilder.CreateIndex(
                name: "IX_TblPenerimaan_KasId",
                table: "TblPenerimaan",
                column: "KasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBelanja_KasId",
                table: "TblBelanja",
                column: "KasId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBelanja_TblKas_KasId",
                table: "TblBelanja",
                column: "KasId",
                principalTable: "TblKas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblPenerimaan_TblKas_KasId",
                table: "TblPenerimaan",
                column: "KasId",
                principalTable: "TblKas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBelanja_TblKas_KasId",
                table: "TblBelanja");

            migrationBuilder.DropForeignKey(
                name: "FK_TblPenerimaan_TblKas_KasId",
                table: "TblPenerimaan");

            migrationBuilder.DropTable(
                name: "TblKas");

            migrationBuilder.DropIndex(
                name: "IX_TblPenerimaan_KasId",
                table: "TblPenerimaan");

            migrationBuilder.DropIndex(
                name: "IX_TblBelanja_KasId",
                table: "TblBelanja");

            migrationBuilder.DropColumn(
                name: "KasId",
                table: "TblPenerimaan");

            migrationBuilder.DropColumn(
                name: "TanggalDitambahkan",
                table: "TblPenerimaan");

            migrationBuilder.DropColumn(
                name: "TanggalDiubah",
                table: "TblPenerimaan");

            migrationBuilder.DropColumn(
                name: "KasId",
                table: "TblBelanja");

            migrationBuilder.DropColumn(
                name: "TanggalDitambahkan",
                table: "TblBelanja");

            migrationBuilder.DropColumn(
                name: "TanggalDiubah",
                table: "TblBelanja");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPqml/BwYTfsa7f6UAiX1NChIqQzRwmHQmzgSzhBcZ26uwWf2uznZ8wm9MaZSpmqVw==");
        }
    }
}
