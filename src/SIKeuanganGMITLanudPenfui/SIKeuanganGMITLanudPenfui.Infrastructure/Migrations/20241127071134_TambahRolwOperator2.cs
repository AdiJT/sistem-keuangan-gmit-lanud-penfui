using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahRolwOperator2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "AQAAAAIAAYagAAAAEI3eC8Pk9dOU7SVN3y/mcUmQ4oMcyPlhAa5gs/oZb4BgTxASWDT/I0nSLV3bnFsKWg==", "Operator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMgCBp8LhZZwIsIGCPhtNvHBwD8OfPhwpJbYz0g33O4yaRv2thhWUv67whTqjGVxHA==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "Role" },
                values: new object[] { "AQAAAAIAAYagAAAAEM9Gtb0+/o3ua/wNme1CrUOuVNzVOYydQRGqZBeGorjD2KDmM5OtwlB+f7o1EAOwoA==", "Bendahara" });
        }
    }
}
