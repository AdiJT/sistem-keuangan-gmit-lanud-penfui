using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahOnDeleteCascadeDiAkun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblAkun_TblGolonganAkun_GolonganAkunId",
                table: "TblAkun");

            migrationBuilder.DropForeignKey(
                name: "FK_TblAkun_TblKelompokAkun_KelompokAkunId",
                table: "TblAkun");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKCpmhWJbmCqACRd5dj488wcRGX5rMzZwOGZnldw8LWV2E10FqeYEdFB9ZWpE4mgRg==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHQ/uJ9wpL9+wcAv50phEVpKv31gP3OAQVcsUBI8jBZS923TYl6EVJbkjWPlQptG2w==");

            migrationBuilder.AddForeignKey(
                name: "FK_TblAkun_TblGolonganAkun_GolonganAkunId",
                table: "TblAkun",
                column: "GolonganAkunId",
                principalTable: "TblGolonganAkun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblAkun_TblKelompokAkun_KelompokAkunId",
                table: "TblAkun",
                column: "KelompokAkunId",
                principalTable: "TblKelompokAkun",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblAkun_TblGolonganAkun_GolonganAkunId",
                table: "TblAkun");

            migrationBuilder.DropForeignKey(
                name: "FK_TblAkun_TblKelompokAkun_KelompokAkunId",
                table: "TblAkun");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPRVABemTXxtXZocS4JRaQBd1hmsI77kXisFgGpyOi0xK43FBk1mRRD3tse4mwXoew==");

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHYSXnNvRc1FFWDDxeO+vYUZzeXZOBGRGP8KzP6XaZ6UBJBNcDz+BRG64HeJuKkB2A==");

            migrationBuilder.AddForeignKey(
                name: "FK_TblAkun_TblGolonganAkun_GolonganAkunId",
                table: "TblAkun",
                column: "GolonganAkunId",
                principalTable: "TblGolonganAkun",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblAkun_TblKelompokAkun_KelompokAkunId",
                table: "TblAkun",
                column: "KelompokAkunId",
                principalTable: "TblKelompokAkun",
                principalColumn: "Id");
        }
    }
}
