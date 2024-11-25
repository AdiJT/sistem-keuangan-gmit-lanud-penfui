using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UbahTanggalTransaksiJadiDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Tanggal",
                table: "TblTransaksi",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tanggal",
                value: new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                column: "Tanggal",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "Tanggal",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "Tanggal",
                value: new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "Tanggal",
                value: new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOFmNVP85C/54FfHlf5CoIpfodDUjak6UW0CjG8SFIZXIvLhcYYA3x/bOJKk2yMs4w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Tanggal",
                table: "TblTransaksi",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 2));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 5));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 5));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 6));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 6));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 6));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 6));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 6));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 1));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 3));

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "Tanggal",
                value: new DateOnly(2024, 1, 5));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPJAw2Kh9EmphLUGntc8hIbCH79oAsPUzsH8rx+kiBs0fBFHHMDBeDkRC3iRKNc71g==");
        }
    }
}
