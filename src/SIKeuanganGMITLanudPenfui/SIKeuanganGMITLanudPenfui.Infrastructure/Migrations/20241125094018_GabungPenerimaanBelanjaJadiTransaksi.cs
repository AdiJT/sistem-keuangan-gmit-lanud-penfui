using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GabungPenerimaanBelanjaJadiTransaksi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblBelanja");

            migrationBuilder.DropTable(
                name: "TblPenerimaan");

            migrationBuilder.CreateTable(
                name: "TblTransaksi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tanggal = table.Column<DateOnly>(type: "date", nullable: false),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<double>(type: "double precision", nullable: false),
                    SaldoKas = table.Column<double>(type: "double precision", nullable: false),
                    FileBukti = table.Column<string>(type: "text", nullable: false),
                    Jenis = table.Column<int>(type: "integer", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AkunId = table.Column<int>(type: "integer", nullable: false),
                    KasId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTransaksi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblTransaksi_TblAkun_AkunId",
                        column: x => x.AkunId,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblTransaksi_TblKas_KasId",
                        column: x => x.KasId,
                        principalTable: "TblKas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 1, 171, "https://file/1", 1, 500000.0, 1, 9713500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diakonia Duka Alm. An. Ezra Sioh Rayon 7" },
                    { 2, 101, "https://file/1", 1, 150000.0, 1, 9563500.0, new DateOnly(2024, 1, 2), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-" },
                    { 3, 109, "https://file/1", 1, 40000.0, 1, 11286500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs MCB Broco 6A" },
                    { 4, 109, "https://file/1", 1, 5000.0, 1, 11281500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs Box MCB" },
                    { 5, 100, "https://file/1", 1, 71600.0, 1, 11209900.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 4 kg gula pasir timbang @Rp. 17.900,-" },
                    { 6, 100, "https://file/1", 1, 12500.0, 1, 11197400.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs teh sariwangi (50P)" },
                    { 7, 100, "https://file/1", 1, 59900.0, 1, 11137500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs tugu buaya spesial (1 kg)" },
                    { 8, 100, "https://file/1", 1, 30000.0, 1, 11107500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 30 potong kue @Rp. 1.000,-" },
                    { 9, 101, "https://file/1", 1, 255000.0, 1, 10852500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-" },
                    { 10, 51, "https://file/1", 0, 930000.0, 1, 6961500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolekte" },
                    { 11, 16, "https://file/1", 0, 5000.0, 1, 6966500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 1" },
                    { 12, 16, "https://file/1", 0, 10000.0, 1, 6976500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 2" },
                    { 13, 18, "https://file/1", 0, 100000.0, 1, 7076500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 3" },
                    { 14, 19, "https://file/1", 0, 10000.0, 1, 7086500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 4" },
                    { 15, 16, "https://file/1", 0, 5000.0, 1, 7091500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 5" },
                    { 16, 17, "https://file/1", 0, 20000.0, 1, 7111500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 6" },
                    { 17, 21, "https://file/1", 0, 30000.0, 1, 7141500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 1" },
                    { 18, 21, "https://file/1", 0, 50000.0, 1, 7191500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 2" },
                    { 19, 21, "https://file/1", 0, 10000.0, 1, 7201500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 3" },
                    { 20, 21, "https://file/1", 0, 9000.0, 1, 7210500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 4" },
                    { 21, 21, "https://file/1", 0, 5000.0, 1, 7215500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 5" },
                    { 22, 21, "https://file/1", 0, 10000.0, 1, 7225500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 6" },
                    { 23, 21, "https://file/1", 0, 50000.0, 1, 7275500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 7" },
                    { 24, 22, "https://file/1", 0, 10000.0, 1, 7285500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 1" },
                    { 25, 22, "https://file/1", 0, 5000.0, 1, 7290500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 2" },
                    { 26, 22, "https://file/1", 0, 10000.0, 1, 7300500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 3" },
                    { 27, 22, "https://file/1", 0, 50000.0, 1, 7350500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 4" },
                    { 28, 22, "https://file/1", 0, 50000.0, 1, 7400500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 5" },
                    { 29, 22, "https://file/1", 0, 100000.0, 1, 7500500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 6" },
                    { 30, 22, "https://file/1", 0, 10000.0, 1, 7510500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 7" },
                    { 31, 22, "https://file/1", 0, 10000.0, 1, 7520500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 8" },
                    { 32, 22, "https://file/1", 0, 10000.0, 1, 7530500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 9" },
                    { 33, 22, "https://file/1", 0, 10000.0, 1, 7540500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 10" },
                    { 34, 50, "https://file/1", 0, 50000.0, 1, 7590500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Oktovianus Metboki Rayon 5" },
                    { 35, 50, "https://file/1", 0, 77000.0, 1, 7667500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Elisabeth Tualaka Rayon 7" },
                    { 36, 50, "https://file/1", 0, 72000.0, 1, 7739500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel AS Rayon 2" },
                    { 37, 50, "https://file/1", 0, 10000.0, 1, 7749500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Aranci Suek Rayon 4" },
                    { 38, 50, "https://file/1", 0, 50000.0, 1, 7799500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Bpk. Dominggus Kole Rayon 7" },
                    { 39, 50, "https://file/1", 0, 300000.0, 1, 8099500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel. IB Rayon 4" },
                    { 40, 50, "https://file/1", 0, 50000.0, 1, 8149500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Naomi A. Henuk Rayon 2" },
                    { 41, 50, "https://file/1", 0, 100000.0, 1, 8249500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 42, 50, "https://file/1", 0, 69000.0, 1, 8318500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marcus Baria Rayon 7" },
                    { 43, 50, "https://file/1", 0, 150000.0, 1, 8468500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Annie M. Malonda Rayon 7" },
                    { 44, 50, "https://file/1", 0, 50000.0, 1, 8518500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Mikhael Nenotek Rayon 5" },
                    { 45, 50, "https://file/1", 0, 50000.0, 1, 8568500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 46, 50, "https://file/1", 0, 50000.0, 1, 8618500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 47, 50, "https://file/1", 0, 30000.0, 1, 8648500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 48, 50, "https://file/1", 0, 10000.0, 1, 8658500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Melkisedek Kasse Rayon 4" },
                    { 49, 50, "https://file/1", 0, 57000.0, 1, 8715500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Nur M. Tasrap Rayon 5" },
                    { 50, 50, "https://file/1", 0, 16000.0, 1, 8731500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marthen Patipellohy Rayon 5" },
                    { 51, 50, "https://file/1", 0, 60000.0, 1, 8791500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Benyamin Sua Rayon 3" },
                    { 52, 50, "https://file/1", 0, 100000.0, 1, 8891500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama Rayon 7" },
                    { 53, 50, "https://file/1", 0, 50000.0, 1, 8941500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Daud Ludji Rayon 4" },
                    { 54, 50, "https://file/1", 0, 10000.0, 1, 8951500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 1" },
                    { 55, 50, "https://file/1", 0, 111000.0, 1, 9062500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 2" },
                    { 56, 50, "https://file/1", 0, 10000.0, 1, 9072500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 3" },
                    { 57, 50, "https://file/1", 0, 10000.0, 1, 9082500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 4" },
                    { 58, 50, "https://file/1", 0, 10000.0, 1, 9092500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 5" },
                    { 59, 50, "https://file/1", 0, 20000.0, 1, 9112500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 6" },
                    { 60, 50, "https://file/1", 0, 2000.0, 1, 9114500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 7" },
                    { 61, 50, "https://file/1", 0, 64000.0, 1, 9178500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 8" },
                    { 62, 50, "https://file/1", 0, 10000.0, 1, 9188500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 9" },
                    { 63, 50, "https://file/1", 0, 10000.0, 1, 9198500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 10" },
                    { 64, 50, "https://file/1", 0, 10000.0, 1, 9208500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 11" },
                    { 65, 44, "https://file/1", 0, 100000.0, 1, 9308500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama" },
                    { 66, 44, "https://file/1", 0, 30000.0, 1, 9338500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 67, 44, "https://file/1", 0, 25000.0, 1, 9363500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibu. Febei Nuban Rayon 7" },
                    { 68, 44, "https://file/1", 0, 100000.0, 1, 9463500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Kristian Walu Logo Rayon 1" },
                    { 69, 44, "https://file/1", 0, 250000.0, 1, 9713500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Max Warruw Rayon 7" },
                    { 70, 14, "https://file/1", 0, 100000.0, 1, 9813500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur ULTAH ke-79" },
                    { 71, 44, "https://file/1", 0, 400000.0, 1, 10213500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4" },
                    { 72, 10, "https://file/1", 0, 791000.0, 1, 10354500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 73, 81, "https://file/1", 0, 643000.0, 1, 10997500.0, new DateOnly(2024, 1, 3), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 74, 14, "https://file/1", 0, 329000.0, 1, 11326500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPJAw2Kh9EmphLUGntc8hIbCH79oAsPUzsH8rx+kiBs0fBFHHMDBeDkRC3iRKNc71g==");

            migrationBuilder.CreateIndex(
                name: "IX_TblTransaksi_AkunId",
                table: "TblTransaksi",
                column: "AkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTransaksi_KasId",
                table: "TblTransaksi",
                column: "KasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblTransaksi");

            migrationBuilder.CreateTable(
                name: "TblBelanja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AkunId = table.Column<int>(type: "integer", nullable: false),
                    KasId = table.Column<int>(type: "integer", nullable: false),
                    FileBukti = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<double>(type: "double precision", nullable: false),
                    SaldoKas = table.Column<double>(type: "double precision", nullable: false),
                    Tanggal = table.Column<DateOnly>(type: "date", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Uraian = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBelanja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblBelanja_TblAkun_AkunId",
                        column: x => x.AkunId,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblBelanja_TblKas_KasId",
                        column: x => x.KasId,
                        principalTable: "TblKas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPenerimaan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AkunId = table.Column<int>(type: "integer", nullable: false),
                    KasId = table.Column<int>(type: "integer", nullable: false),
                    FileBukti = table.Column<string>(type: "text", nullable: false),
                    Jumlah = table.Column<double>(type: "double precision", nullable: false),
                    SaldoKas = table.Column<double>(type: "double precision", nullable: false),
                    Tanggal = table.Column<DateOnly>(type: "date", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Uraian = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPenerimaan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPenerimaan_TblAkun_AkunId",
                        column: x => x.AkunId,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblPenerimaan_TblKas_KasId",
                        column: x => x.KasId,
                        principalTable: "TblKas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblBelanja",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 1, 171, "https://file/1", 500000.0, 1, 9713500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diakonia Duka Alm. An. Ezra Sioh Rayon 7" },
                    { 2, 101, "https://file/1", 150000.0, 1, 9563500.0, new DateOnly(2024, 1, 2), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-" },
                    { 3, 109, "https://file/1", 40000.0, 1, 11286500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs MCB Broco 6A" },
                    { 4, 109, "https://file/1", 5000.0, 1, 11281500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs Box MCB" },
                    { 5, 100, "https://file/1", 71600.0, 1, 11209900.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 4 kg gula pasir timbang @Rp. 17.900,-" },
                    { 6, 100, "https://file/1", 12500.0, 1, 11197400.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs teh sariwangi (50P)" },
                    { 7, 100, "https://file/1", 59900.0, 1, 11137500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs tugu buaya spesial (1 kg)" },
                    { 8, 100, "https://file/1", 30000.0, 1, 11107500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 30 potong kue @Rp. 1.000,-" },
                    { 9, 101, "https://file/1", 255000.0, 1, 10852500.0, new DateOnly(2024, 1, 6), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-" }
                });

            migrationBuilder.InsertData(
                table: "TblPenerimaan",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 1, 51, "https://file/1", 930000.0, 1, 6961500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolekte" },
                    { 2, 16, "https://file/1", 5000.0, 1, 6966500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 1" },
                    { 3, 16, "https://file/1", 10000.0, 1, 6976500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 2" },
                    { 4, 18, "https://file/1", 100000.0, 1, 7076500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 3" },
                    { 5, 19, "https://file/1", 10000.0, 1, 7086500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 4" },
                    { 6, 16, "https://file/1", 5000.0, 1, 7091500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 5" },
                    { 7, 17, "https://file/1", 20000.0, 1, 7111500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 6" },
                    { 8, 21, "https://file/1", 30000.0, 1, 7141500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 1" },
                    { 9, 21, "https://file/1", 50000.0, 1, 7191500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 2" },
                    { 10, 21, "https://file/1", 10000.0, 1, 7201500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 3" },
                    { 11, 21, "https://file/1", 9000.0, 1, 7210500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 4" },
                    { 12, 21, "https://file/1", 5000.0, 1, 7215500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 5" },
                    { 13, 21, "https://file/1", 10000.0, 1, 7225500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 6" },
                    { 14, 21, "https://file/1", 50000.0, 1, 7275500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 7" },
                    { 15, 22, "https://file/1", 10000.0, 1, 7285500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 1" },
                    { 16, 22, "https://file/1", 5000.0, 1, 7290500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 2" },
                    { 17, 22, "https://file/1", 10000.0, 1, 7300500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 3" },
                    { 18, 22, "https://file/1", 50000.0, 1, 7350500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 4" },
                    { 19, 22, "https://file/1", 50000.0, 1, 7400500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 5" },
                    { 20, 22, "https://file/1", 100000.0, 1, 7500500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 6" },
                    { 21, 22, "https://file/1", 10000.0, 1, 7510500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 7" },
                    { 22, 22, "https://file/1", 10000.0, 1, 7520500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 8" },
                    { 23, 22, "https://file/1", 10000.0, 1, 7530500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 9" },
                    { 24, 22, "https://file/1", 10000.0, 1, 7540500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 10" },
                    { 25, 50, "https://file/1", 50000.0, 1, 7590500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Oktovianus Metboki Rayon 5" },
                    { 26, 50, "https://file/1", 77000.0, 1, 7667500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Elisabeth Tualaka Rayon 7" },
                    { 27, 50, "https://file/1", 72000.0, 1, 7739500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel AS Rayon 2" },
                    { 28, 50, "https://file/1", 10000.0, 1, 7749500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Aranci Suek Rayon 4" },
                    { 29, 50, "https://file/1", 50000.0, 1, 7799500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Bpk. Dominggus Kole Rayon 7" },
                    { 30, 50, "https://file/1", 300000.0, 1, 8099500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel. IB Rayon 4" },
                    { 31, 50, "https://file/1", 50000.0, 1, 8149500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Naomi A. Henuk Rayon 2" },
                    { 32, 50, "https://file/1", 100000.0, 1, 8249500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 33, 50, "https://file/1", 69000.0, 1, 8318500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marcus Baria Rayon 7" },
                    { 34, 50, "https://file/1", 150000.0, 1, 8468500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Annie M. Malonda Rayon 7" },
                    { 35, 50, "https://file/1", 50000.0, 1, 8518500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Mikhael Nenotek Rayon 5" },
                    { 36, 50, "https://file/1", 50000.0, 1, 8568500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 37, 50, "https://file/1", 50000.0, 1, 8618500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 38, 50, "https://file/1", 30000.0, 1, 8648500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 39, 50, "https://file/1", 10000.0, 1, 8658500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Melkisedek Kasse Rayon 4" },
                    { 40, 50, "https://file/1", 57000.0, 1, 8715500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Nur M. Tasrap Rayon 5" },
                    { 41, 50, "https://file/1", 16000.0, 1, 8731500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marthen Patipellohy Rayon 5" },
                    { 42, 50, "https://file/1", 60000.0, 1, 8791500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Benyamin Sua Rayon 3" },
                    { 43, 50, "https://file/1", 100000.0, 1, 8891500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama Rayon 7" },
                    { 44, 50, "https://file/1", 50000.0, 1, 8941500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Daud Ludji Rayon 4" },
                    { 45, 50, "https://file/1", 10000.0, 1, 8951500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 1" },
                    { 46, 50, "https://file/1", 111000.0, 1, 9062500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 2" },
                    { 47, 50, "https://file/1", 10000.0, 1, 9072500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 3" },
                    { 48, 50, "https://file/1", 10000.0, 1, 9082500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 4" },
                    { 49, 50, "https://file/1", 10000.0, 1, 9092500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 5" },
                    { 50, 50, "https://file/1", 20000.0, 1, 9112500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 6" },
                    { 51, 50, "https://file/1", 2000.0, 1, 9114500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 7" },
                    { 52, 50, "https://file/1", 64000.0, 1, 9178500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 8" },
                    { 53, 50, "https://file/1", 10000.0, 1, 9188500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 9" },
                    { 54, 50, "https://file/1", 10000.0, 1, 9198500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 10" },
                    { 55, 50, "https://file/1", 10000.0, 1, 9208500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 11" },
                    { 56, 44, "https://file/1", 100000.0, 1, 9308500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama" },
                    { 57, 44, "https://file/1", 30000.0, 1, 9338500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 58, 44, "https://file/1", 25000.0, 1, 9363500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibu. Febei Nuban Rayon 7" },
                    { 59, 44, "https://file/1", 100000.0, 1, 9463500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Kristian Walu Logo Rayon 1" },
                    { 60, 44, "https://file/1", 250000.0, 1, 9713500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Max Warruw Rayon 7" },
                    { 61, 14, "https://file/1", 100000.0, 1, 9813500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur ULTAH ke-79" },
                    { 62, 44, "https://file/1", 400000.0, 1, 10213500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4" },
                    { 63, 10, "https://file/1", 791000.0, 1, 10354500.0, new DateOnly(2024, 1, 1), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 64, 81, "https://file/1", 643000.0, 1, 10997500.0, new DateOnly(2024, 1, 3), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 65, 14, "https://file/1", 329000.0, 1, 11326500.0, new DateOnly(2024, 1, 5), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" }
                });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEHJDAl3RsNVKJsGq7Z4eBufrbA3c/p+baMokBvphLbgR4nWSF0T48SIDpsxKIXxD3w==");

            migrationBuilder.CreateIndex(
                name: "IX_TblBelanja_AkunId",
                table: "TblBelanja",
                column: "AkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBelanja_KasId",
                table: "TblBelanja",
                column: "KasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPenerimaan_AkunId",
                table: "TblPenerimaan",
                column: "AkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPenerimaan_KasId",
                table: "TblPenerimaan",
                column: "KasId");
        }
    }
}
