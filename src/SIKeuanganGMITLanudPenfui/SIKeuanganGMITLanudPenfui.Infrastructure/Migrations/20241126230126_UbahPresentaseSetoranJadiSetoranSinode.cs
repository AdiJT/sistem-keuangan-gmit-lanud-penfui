using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UbahPresentaseSetoranJadiSetoranSinode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PresentaseSetoran",
                table: "TblAkun");

            migrationBuilder.AddColumn<bool>(
                name: "SetoranSinode",
                table: "TblAkun",
                type: "boolean",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 1,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 2,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 3,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 4,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 5,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 6,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 7,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 8,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 9,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 10,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 11,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 12,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 13,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 14,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 15,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 16,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 17,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 18,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 19,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 20,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 21,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 22,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 23,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 24,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 25,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 26,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 27,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 28,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 29,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 30,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 31,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 32,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 33,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 34,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 35,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 36,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 37,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 38,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 39,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 40,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 41,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 42,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 43,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 44,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 45,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 46,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 47,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 48,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 49,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 50,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 51,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 52,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 53,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 54,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 55,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 56,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 57,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 58,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 59,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 60,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 61,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 62,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 63,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 64,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 65,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 66,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 67,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 68,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 69,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 70,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 71,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 72,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 73,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 74,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 75,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 76,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 77,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 78,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 79,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 80,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 81,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 82,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 83,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 84,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 85,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 86,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 87,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 88,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 89,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 90,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 91,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 92,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 93,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 94,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 95,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 96,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 97,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 98,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 99,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 100,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 101,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 102,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 103,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 104,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 105,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 106,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 107,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 108,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 109,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 110,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 111,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 112,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 113,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 114,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 115,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 116,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 117,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 118,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 119,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 120,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 121,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 122,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 123,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 124,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 125,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 126,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 127,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 128,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 129,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 130,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 131,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 132,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 133,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 134,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 135,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 136,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 137,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 138,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 139,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 140,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 141,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 142,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 143,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 144,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 145,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 146,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 147,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 148,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 149,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 150,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 151,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 152,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 153,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 154,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 155,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 156,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 157,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 158,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 159,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 160,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 161,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 162,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 163,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 164,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 165,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 166,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 167,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 168,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 169,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 170,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 171,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 172,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 173,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 174,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 175,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 176,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 177,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 178,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 179,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 180,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 181,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 182,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 183,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 184,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 185,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 186,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 187,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 188,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 189,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 190,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 191,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 192,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 193,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 194,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 195,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 196,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 197,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 198,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 199,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 200,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 201,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 202,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 203,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 204,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 205,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 206,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 207,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 209,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 210,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 211,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 212,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 213,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 214,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 215,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 216,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 217,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 218,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 219,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 220,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 221,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 222,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 223,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 224,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 225,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 226,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 227,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 228,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 229,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 230,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 231,
                column: "SetoranSinode",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 232,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 233,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 234,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 235,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 236,
                column: "SetoranSinode",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 237,
                column: "SetoranSinode",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAo3V45lZyUymn6E06UCzZnTwHUJd/B6eN0UAkf4NC3tqwaxCxtWfCK046FXoQ0iPQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SetoranSinode",
                table: "TblAkun");

            migrationBuilder.AddColumn<double>(
                name: "PresentaseSetoran",
                table: "TblAkun",
                type: "double precision",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 1,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 2,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 3,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 4,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 5,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 6,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 7,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 8,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 9,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 10,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 11,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 12,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 13,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 14,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 15,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 16,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 17,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 18,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 19,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 20,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 21,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 22,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 23,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 24,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 25,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 26,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 27,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 28,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 29,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 30,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 31,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 32,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 33,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 34,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 35,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 36,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 37,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 38,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 39,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 40,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 41,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 42,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 43,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 44,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 45,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 46,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 47,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 48,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 49,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 50,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 51,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 52,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 53,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 54,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 55,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 56,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 57,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 58,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 59,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 60,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 61,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 62,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 63,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 64,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 65,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 66,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 67,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 68,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 69,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 70,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 71,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 72,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 73,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 74,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 75,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 76,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 77,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 78,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 79,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 80,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 81,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 82,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 83,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 84,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 85,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 86,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 87,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 88,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 89,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 90,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 91,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 92,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 93,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 94,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 95,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 96,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 97,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 98,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 99,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 100,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 101,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 102,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 103,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 104,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 105,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 106,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 107,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 108,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 109,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 110,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 111,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 112,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 113,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 114,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 115,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 116,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 117,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 118,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 119,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 120,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 121,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 122,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 123,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 124,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 125,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 126,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 127,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 128,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 129,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 130,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 131,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 132,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 133,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 134,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 135,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 136,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 137,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 138,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 139,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 140,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 141,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 142,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 143,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 144,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 145,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 146,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 147,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 148,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 149,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 150,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 151,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 152,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 153,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 154,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 155,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 156,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 157,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 158,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 159,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 160,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 161,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 162,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 163,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 164,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 165,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 166,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 167,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 168,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 169,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 170,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 171,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 172,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 173,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 174,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 175,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 176,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 177,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 178,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 179,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 180,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 181,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 182,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 183,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 184,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 185,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 186,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 187,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 188,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 189,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 190,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 191,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 192,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 193,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 194,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 195,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 196,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 197,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 198,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 199,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 200,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 201,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 202,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 203,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 204,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 205,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 206,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 207,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 209,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 210,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 211,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 212,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 213,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 214,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 215,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 216,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 217,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 218,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 219,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 220,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 221,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 222,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 223,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 224,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 225,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 226,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 227,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 228,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 229,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 230,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 231,
                column: "PresentaseSetoran",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 232,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 233,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 234,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 235,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 236,
                column: "PresentaseSetoran",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 237,
                column: "PresentaseSetoran",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENBTomxn0+ePF0laIoW5dFc+MLJsEfCdTZQKx6roxrpTwzk/RCxrqKFGCNgLc81udg==");
        }
    }
}
