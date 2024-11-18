using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UbahTanggalDiubahAuditableEntityNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblPenerimaan",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblKas",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblBuktiTransaksi",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblBelanja",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "TanggalDiubah",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHG3Z4Qic4hXvGsxi4WU9SXG0+I8E3yZVguKOAzL91jF4x596lXm+78hJM1P567s1w==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblPenerimaan",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblKas",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblBuktiTransaksi",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalDiubah",
                table: "TblBelanja",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblBuktiTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "TanggalDiubah",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFz2XQBulUPhQSOAU48TlpN1td0kq4JYsL5EKXn59vEhPD/CZVe3F2PFQpjf0gsIiw==");
        }
    }
}
