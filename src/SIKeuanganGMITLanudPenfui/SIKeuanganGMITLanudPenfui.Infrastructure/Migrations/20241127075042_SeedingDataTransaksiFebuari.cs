using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataTransaksiFebuari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDiubah" },
                values: new object[] { 11513000.0, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 75, 69, "https://file/1", 0, 177000.0, 1, 11029500.0, new DateTime(2024, 2, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah rumah tangga dirumah Bpk. Nur M. Tasrap Rayon 5, dipimpin oleh Pnt. Jeri K. Patipellohy-Akal" },
                    { 76, 70, "https://file/1", 0, 59000.0, 1, 11088500.0, new DateTime(2024, 2, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah rumah tangga dirumah Bpk. Devilpus Subu Rayon 6, dipimpin oleh Dkn. Lely Nepafay" },
                    { 77, 65, "https://file/1", 0, 104000.0, 1, 11192500.0, new DateTime(2024, 2, 1, 1, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah rumah tangga dirumah Bpk. Derven G. Foenay Rayon 2, dipimpin oleh Pnt. Djibrael Nawa" },
                    { 78, 66, "https://file/1", 0, 303000.0, 1, 11495500.0, new DateTime(2024, 2, 1, 1, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah rumah tangga dirumah Ibu. Erna Nggolut Rayon 3, dipimpin oleh Cavic Victor I. Hairmo, S.Th" },
                    { 79, 77, "https://file/1", 0, 17500.0, 1, 11513000.0, new DateTime(2024, 2, 1, 1, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah katekasasi reguler di Gereja JLET, dipimpin oleh Pjr. Lusia L. Kassir-Kollis" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Saldo", "TanggalDiubah" },
                values: new object[] { 10852500.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFmxt2HWKMJv5fKZpS/QoL6hVK7thhH0UozIeckdedGGtMOIVTPn+7YLYqj93CGgsg==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI3eC8Pk9dOU7SVN3y/mcUmQ4oMcyPlhAa5gs/oZb4BgTxASWDT/I0nSLV3bnFsKWg==");
        }
    }
}
