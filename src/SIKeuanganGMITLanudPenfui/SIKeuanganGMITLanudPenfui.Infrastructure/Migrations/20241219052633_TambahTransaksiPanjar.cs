using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahTransaksiPanjar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "NomorBukti", "SaldoKas", "StatusTransaksi", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 120, 76, null, 1, 100000.0, 2, null, 4793500.0, 0, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transaksi Panjar 1" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPRVABemTXxtXZocS4JRaQBd1hmsI77kXisFgGpyOi0xK43FBk1mRRD3tse4mwXoew==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHYSXnNvRc1FFWDDxeO+vYUZzeXZOBGRGP8KzP6XaZ6UBJBNcDz+BRG64HeJuKkB2A==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKI8WnKqisKtQ+hWHEo1XAwZtsOIybGfYHwXfnRyvkPDkdxKyWqtsU4Zny/lFcWNLg==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJXsMvwiT0XzynjexdC2kySRNMpxMEuCV0ouJ0sOD+aeIW3OPy2Qqy3/O3vXmDFPhA==");
        }
    }
}
