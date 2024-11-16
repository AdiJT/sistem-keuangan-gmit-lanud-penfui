using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GantiTahunRAPBJPakaiValueObjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFz2XQBulUPhQSOAU48TlpN1td0kq4JYsL5EKXn59vEhPD/CZVe3F2PFQpjf0gsIiw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEML6iwhBAPxjmfsNgyW5GGqTJSs7yRymxTjd/i8wgKvIlyZarG0/qeZJ9YoCra1SvA==");
        }
    }
}
