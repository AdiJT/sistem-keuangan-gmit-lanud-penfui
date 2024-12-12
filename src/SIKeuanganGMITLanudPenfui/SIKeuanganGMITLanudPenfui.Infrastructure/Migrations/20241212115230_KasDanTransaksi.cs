using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class KasDanTransaksi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomorBukti",
                table: "TblTransaksi",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Keterangan",
                table: "TblKas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Keterangan",
                value: "Kas BANK");

            migrationBuilder.InsertData(
                table: "TblKas",
                columns: new[] { "Id", "Keterangan", "Saldo", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 2, "Kas Tunai", 4693500.0, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kas Tunai" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 75,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 76,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 77,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 78,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 79,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 80,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 81,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 82,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 83,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 84,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 85,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 86,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 87,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 88,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 89,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 90,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 91,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 92,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 93,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 94,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 95,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 96,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 97,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 98,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 99,
                column: "NomorBukti",
                value: "SK/1");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC3hfAXt/iwxOh8VwWyrCHoCTUQ7R6a3yy62QD9u0pEoKZd2gA/ig3tFMgEBdoHtQw==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGEkt/kTUSMzOZuOwSMA7CFTSPjwhT0h9X0Lkhho9/W9fOyXTKRTz54jMU+dXAwDDg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "NomorBukti",
                table: "TblTransaksi");

            migrationBuilder.DropColumn(
                name: "Keterangan",
                table: "TblKas");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBnLy1F+8bhbe0LAw7KizapYQ5Dd4U9AapJ4IwLlPCBS3QR1r7eLRzusG9RMBR2ccg==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEIaeB9HbmQJtZ5znyebWipmD9Qghoa8qlz5joDSX1gaijYQKRaBQEc8e6Oi5RB0VQ==");
        }
    }
}
