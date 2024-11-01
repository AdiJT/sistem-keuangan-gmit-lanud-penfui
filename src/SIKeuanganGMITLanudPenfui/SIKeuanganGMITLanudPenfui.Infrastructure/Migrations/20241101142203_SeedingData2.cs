using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "Id", "PasswordHash", "Role", "UserName" },
                values: new object[] { 1, "AQAAAAIAAYagAAAAEPqml/BwYTfsa7f6UAiX1NChIqQzRwmHQmzgSzhBcZ26uwWf2uznZ8wm9MaZSpmqVw==", "Bendahara", "Bendahara" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
