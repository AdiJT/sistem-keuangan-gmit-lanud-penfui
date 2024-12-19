using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahStatusTransaksi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomorBukti",
                table: "TblTransaksi",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FileBukti",
                table: "TblTransaksi",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "StatusTransaksi",
                table: "TblTransaksi",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 75,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 76,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 77,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 78,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 79,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 80,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 81,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 82,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 83,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 84,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 85,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 86,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 87,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 88,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 89,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 90,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 91,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 92,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 93,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 94,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 95,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 96,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 97,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 98,
                column: "StatusTransaksi",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 99,
                column: "StatusTransaksi",
                value: 1);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusTransaksi",
                table: "TblTransaksi");

            migrationBuilder.AlterColumn<string>(
                name: "NomorBukti",
                table: "TblTransaksi",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileBukti",
                table: "TblTransaksi",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ14M3LFFrPy7f2lVO0X8H3T0SX6i5Z+YSwsfYHUDM5C1gxVziic43l6PLfCYG7dog==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA25NbR4pqNcMYFEApekJTOCLNGQQjcuPjSuBA93KNRENm3aKNxvVilHJX+OoL2DKw==");
        }
    }
}
