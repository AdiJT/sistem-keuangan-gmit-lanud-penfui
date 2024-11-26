using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSaldoKas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Saldo",
                value: 11209900.0);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOcOQmd6vaEYdTzcx9ytj6+r/cDCAolsFJ8RkYvxETF3R4lqHsGMfqqYKHRfVXNztA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblKas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Saldo",
                value: 10852500.0);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECVGWHM4bJUgSsg0OLyT87rRW8TmEUvMH6HQYpCZnUu6LU3gytuQG7XToRYjVoyuRA==");
        }
    }
}
