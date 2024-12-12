using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahInformasiGereja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblInformasiGereja",
                columns: table => new
                {
                    Tahun = table.Column<int>(type: "integer", nullable: false),
                    KetuaMajelisJemaat = table.Column<string>(type: "text", nullable: false),
                    Bendahara = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblInformasiGereja", x => x.Tahun);
                });

            migrationBuilder.InsertData(
                table: "TblInformasiGereja",
                columns: new[] { "Tahun", "Bendahara", "KetuaMajelisJemaat" },
                values: new object[] { 2024, "Pnt. Melkianus Foes", "Pdt. Ishak B. Batmalo, S.Th" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblInformasiGereja");

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
    }
}
