using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataAkunTambahan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "PresentaseSetoran", "Uraian" },
                values: new object[,]
                {
                    { 232, null, 7, null, null, "Administrasi Baptisan" },
                    { 233, null, 7, null, null, "Administrasi Peneguhan Sidi Baru" },
                    { 234, null, 7, null, null, "Administrasi Pemberkatan Nikah" },
                    { 235, null, 7, null, null, "Bunga Bank" },
                    { 236, null, 7, null, null, "Hasil Lelang" },
                    { 237, null, 7, null, null, "Penerimaan Lainnya" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECTVkC1v2Xg0/xJbJVhsIfE1d1yFwW6IOt4DSRnFbvfSgbGf50IlRt3154vTd/xAmA==");

            migrationBuilder.InsertData(
                table: "TblDetailRAPBJ",
                columns: new[] { "KodeAkun", "TahunRAPBJ", "HargaSatuan", "Satuan", "Volume" },
                values: new object[,]
                {
                    { 232, 2024, 10000.0, "kali", 1 },
                    { 233, 2024, 10000.0, "kali", 1 },
                    { 234, 2024, 10000.0, "kali", 1 },
                    { 235, 2024, 10000.0, "kali", 1 },
                    { 236, 2024, 10000.0, "kali", 1 },
                    { 237, 2024, 10000.0, "kali", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 232, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 233, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 234, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 235, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 236, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 237, 2024 });

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECfupaZ2lm+Pvyqa/DmVGI9kZ3pqO+IjKrHrvhRDZDOWTkBkcFUlsUSdmQ9hXRHu6A==");
        }
    }
}
