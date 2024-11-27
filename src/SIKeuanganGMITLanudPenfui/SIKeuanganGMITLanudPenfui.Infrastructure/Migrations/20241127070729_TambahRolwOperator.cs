using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahRolwOperator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMgCBp8LhZZwIsIGCPhtNvHBwD8OfPhwpJbYz0g33O4yaRv2thhWUv67whTqjGVxHA==");

            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "Id", "PasswordHash", "Role", "UserName" },
                values: new object[] { 2, "AQAAAAIAAYagAAAAEM9Gtb0+/o3ua/wNme1CrUOuVNzVOYydQRGqZBeGorjD2KDmM5OtwlB+f7o1EAOwoA==", "Bendahara", "Operator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIUMu+o3Bw2BzlhY/OV1OMNCHUGxPPNodgCDfjAeI+px0ZxoN0cWRqYdJQonT32wDg==");
        }
    }
}
