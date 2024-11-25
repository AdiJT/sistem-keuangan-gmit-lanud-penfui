using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UbahTanggalTransaksiJadiDateTime3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 1, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 2, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 5, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "Tanggal",
                value: new DateTime(2024, 1, 2, 0, 0, 7, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "Tanggal",
                value: new DateTime(2024, 1, 3, 0, 0, 9, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 0, 10, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 0, 11, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 0, 12, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 0, 13, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ606NDlRkHr2h6Coqry6cSzidBmUlN/ikuXephbQhJGONZa0g7mU4XL5Wre3l3iAg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 1, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 2, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 3, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 5, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "Tanggal",
                value: new DateTime(2024, 1, 2, 0, 1, 7, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 1, 8, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "Tanggal",
                value: new DateTime(2024, 1, 3, 0, 1, 9, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 1, 10, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 1, 11, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 1, 12, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 1, 13, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM6/iHKQRzoqw7TIyIBBus8hpsYZVENWH9QVabOFyTA1VBZG/sBk8j2cCw424HGnTA==");
        }
    }
}
