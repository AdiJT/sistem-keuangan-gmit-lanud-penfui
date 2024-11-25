using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UbahTanggalTransaksiJadiDateTime2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 12500.0, 11197400.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs teh sariwangi (50P)" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 59900.0, 11137500.0, new DateTime(2024, 1, 6, 0, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs tugu buaya spesial (1 kg)" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 30000.0, 11107500.0, new DateTime(2024, 1, 6, 0, 0, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 30 potong kue @Rp. 1.000,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 101, 255000.0, 10852500.0, new DateTime(2024, 1, 6, 0, 0, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 51, 0, 930000.0, 6961500.0, new DateTime(2024, 1, 1, 0, 0, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolekte" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 16, 0, 5000.0, 6966500.0, new DateTime(2024, 1, 1, 0, 0, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 16, 0, 10000.0, 6976500.0, new DateTime(2024, 1, 1, 0, 0, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 18, 0, 100000.0, 7076500.0, new DateTime(2024, 1, 1, 0, 0, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 19, 0, 10000.0, 7086500.0, new DateTime(2024, 1, 1, 0, 0, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 16, 5000.0, 7091500.0, new DateTime(2024, 1, 1, 0, 0, 9, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 17, 20000.0, 7111500.0, new DateTime(2024, 1, 1, 0, 0, 10, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 30000.0, 7141500.0, new DateTime(2024, 1, 1, 0, 0, 11, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 50000.0, 7191500.0, new DateTime(2024, 1, 1, 0, 0, 12, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 7201500.0, new DateTime(2024, 1, 1, 0, 0, 13, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 9000.0, 7210500.0, new DateTime(2024, 1, 1, 0, 0, 14, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 5000.0, 7215500.0, new DateTime(2024, 1, 1, 0, 0, 15, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 7225500.0, new DateTime(2024, 1, 1, 0, 0, 16, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 7275500.0, new DateTime(2024, 1, 1, 0, 0, 17, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 7285500.0, new DateTime(2024, 1, 1, 0, 0, 18, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 5000.0, 7290500.0, new DateTime(2024, 1, 1, 0, 0, 19, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 10000.0, 7300500.0, new DateTime(2024, 1, 1, 0, 0, 20, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 50000.0, 7350500.0, new DateTime(2024, 1, 1, 0, 0, 21, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 7400500.0, new DateTime(2024, 1, 1, 0, 0, 22, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 100000.0, 7500500.0, new DateTime(2024, 1, 1, 0, 0, 23, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 7510500.0, new DateTime(2024, 1, 1, 0, 0, 24, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 7520500.0, new DateTime(2024, 1, 1, 0, 0, 25, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 8" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 7530500.0, new DateTime(2024, 1, 1, 0, 0, 26, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 9" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 7540500.0, new DateTime(2024, 1, 1, 0, 0, 27, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 10" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 50000.0, 7590500.0, new DateTime(2024, 1, 1, 0, 0, 28, 0, DateTimeKind.Unspecified), "Bpk. Oktovianus Metboki Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 77000.0, 7667500.0, new DateTime(2024, 1, 1, 0, 0, 29, 0, DateTimeKind.Unspecified), "Oma. Elisabeth Tualaka Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 72000.0, 7739500.0, new DateTime(2024, 1, 1, 0, 0, 30, 0, DateTimeKind.Unspecified), "Kel AS Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 7749500.0, new DateTime(2024, 1, 1, 0, 0, 31, 0, DateTimeKind.Unspecified), "Oma. Aranci Suek Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 50000.0, 7799500.0, new DateTime(2024, 1, 1, 0, 0, 32, 0, DateTimeKind.Unspecified), " Bpk. Dominggus Kole Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 300000.0, 8099500.0, new DateTime(2024, 1, 1, 0, 0, 33, 0, DateTimeKind.Unspecified), "Kel. IB Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8149500.0, new DateTime(2024, 1, 1, 0, 0, 34, 0, DateTimeKind.Unspecified), "Oma. Naomi A. Henuk Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 100000.0, 8249500.0, new DateTime(2024, 1, 1, 0, 0, 35, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 69000.0, 8318500.0, new DateTime(2024, 1, 1, 0, 0, 36, 0, DateTimeKind.Unspecified), "Bpk. Marcus Baria Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 150000.0, 8468500.0, new DateTime(2024, 1, 1, 0, 0, 37, 0, DateTimeKind.Unspecified), "Oma. Annie M. Malonda Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8518500.0, new DateTime(2024, 1, 1, 0, 0, 38, 0, DateTimeKind.Unspecified), "Bpk. Mikhael Nenotek Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 8568500.0, new DateTime(2024, 1, 1, 0, 0, 39, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal" },
                values: new object[] { 50000.0, 8618500.0, new DateTime(2024, 1, 1, 0, 0, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 30000.0, 8648500.0, new DateTime(2024, 1, 1, 0, 0, 41, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 8658500.0, new DateTime(2024, 1, 1, 0, 0, 42, 0, DateTimeKind.Unspecified), "Bpk. Melkisedek Kasse Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 57000.0, 8715500.0, new DateTime(2024, 1, 1, 0, 0, 43, 0, DateTimeKind.Unspecified), "Bpk. Nur M. Tasrap Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 16000.0, 8731500.0, new DateTime(2024, 1, 1, 0, 0, 44, 0, DateTimeKind.Unspecified), "Bpk. Marthen Patipellohy Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 60000.0, 8791500.0, new DateTime(2024, 1, 1, 0, 0, 45, 0, DateTimeKind.Unspecified), "Bpk. Benyamin Sua Rayon 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 100000.0, 8891500.0, new DateTime(2024, 1, 1, 0, 0, 46, 0, DateTimeKind.Unspecified), "Tanpa Nama Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8941500.0, new DateTime(2024, 1, 1, 0, 0, 47, 0, DateTimeKind.Unspecified), "Bpk. Daud Ludji Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 8951500.0, new DateTime(2024, 1, 1, 0, 0, 48, 0, DateTimeKind.Unspecified), "Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 111000.0, 9062500.0, new DateTime(2024, 1, 1, 0, 0, 49, 0, DateTimeKind.Unspecified), "Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 9072500.0, new DateTime(2024, 1, 1, 0, 0, 50, 0, DateTimeKind.Unspecified), "Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 9082500.0, new DateTime(2024, 1, 1, 0, 0, 51, 0, DateTimeKind.Unspecified), "Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 9092500.0, new DateTime(2024, 1, 1, 0, 0, 52, 0, DateTimeKind.Unspecified), "Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 20000.0, 9112500.0, new DateTime(2024, 1, 1, 0, 0, 53, 0, DateTimeKind.Unspecified), "Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 2000.0, 9114500.0, new DateTime(2024, 1, 1, 0, 0, 54, 0, DateTimeKind.Unspecified), "Tanpa Nama 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 64000.0, 9178500.0, new DateTime(2024, 1, 1, 0, 0, 55, 0, DateTimeKind.Unspecified), "Tanpa Nama 8" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 9188500.0, new DateTime(2024, 1, 1, 0, 0, 56, 0, DateTimeKind.Unspecified), "Tanpa Nama 9" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 9198500.0, new DateTime(2024, 1, 1, 0, 0, 57, 0, DateTimeKind.Unspecified), "Tanpa Nama 10" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 9208500.0, new DateTime(2024, 1, 1, 0, 0, 58, 0, DateTimeKind.Unspecified), "Tanpa Nama 11" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 100000.0, 9308500.0, new DateTime(2024, 1, 1, 0, 0, 59, 0, DateTimeKind.Unspecified), "Tanpa Nama" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 30000.0, 9338500.0, new DateTime(2024, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 25000.0, 9363500.0, new DateTime(2024, 1, 1, 0, 1, 1, 0, DateTimeKind.Unspecified), "Ibu. Febei Nuban Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 100000.0, 9463500.0, new DateTime(2024, 1, 1, 0, 1, 2, 0, DateTimeKind.Unspecified), "Bpk. Kristian Walu Logo Rayon 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 250000.0, 9713500.0, new DateTime(2024, 1, 1, 0, 1, 3, 0, DateTimeKind.Unspecified), "Bpk. Max Warruw Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 14, 9813500.0, new DateTime(2024, 1, 1, 0, 1, 4, 0, DateTimeKind.Unspecified), "Terima persembahan syukur ULTAH ke-79" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 400000.0, 10213500.0, new DateTime(2024, 1, 1, 0, 1, 5, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 171, 1, 500000.0, 9713500.0, new DateTime(2024, 1, 1, 0, 1, 6, 0, DateTimeKind.Unspecified), "Diakonia Duka Alm. An. Ezra Sioh Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 101, 1, 150000.0, 9563500.0, new DateTime(2024, 1, 2, 0, 1, 7, 0, DateTimeKind.Unspecified), "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 10, 791000.0, 10354500.0, new DateTime(2024, 1, 1, 0, 1, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 81, 643000.0, 10997500.0, new DateTime(2024, 1, 3, 0, 1, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 14, 329000.0, 11326500.0, new DateTime(2024, 1, 5, 0, 1, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 109, 1, 40000.0, 11286500.0, new DateTime(2024, 1, 5, 0, 1, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs MCB Broco 6A" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 109, 1, 5000.0, 11281500.0, new DateTime(2024, 1, 5, 0, 1, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs Box MCB" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 1, 71600.0, 11209900.0, new DateTime(2024, 1, 6, 0, 1, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 4 kg gula pasir timbang @Rp. 17.900,-" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM6/iHKQRzoqw7TIyIBBus8hpsYZVENWH9QVabOFyTA1VBZG/sBk8j2cCw424HGnTA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 171, 500000.0, 9713500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diakonia Duka Alm. An. Ezra Sioh Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 101, 150000.0, 9563500.0, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 109, 40000.0, 11286500.0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs MCB Broco 6A" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 109, 5000.0, 11281500.0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs Box MCB" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 1, 71600.0, 11209900.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 4 kg gula pasir timbang @Rp. 17.900,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 1, 12500.0, 11197400.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs teh sariwangi (50P)" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 1, 59900.0, 11137500.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs tugu buaya spesial (1 kg)" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 100, 1, 30000.0, 11107500.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 30 potong kue @Rp. 1.000,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 101, 1, 255000.0, 10852500.0, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 51, 930000.0, 6961500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolekte" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 16, 5000.0, 6966500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 16, 10000.0, 6976500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 18, 100000.0, 7076500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 19, 7086500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 16, 5000.0, 7091500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 17, 20000.0, 7111500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 30000.0, 7141500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 7191500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 7201500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 9000.0, 7210500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 5000.0, 7215500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 10000.0, 7225500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 21, 7275500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 7285500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 5000.0, 7290500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 7300500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 7350500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 7400500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 100000.0, 7500500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 10000.0, 7510500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 10000.0, 7520500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 8" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 7530500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 9" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 22, 10000.0, 7540500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 10" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 7590500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Oktovianus Metboki Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 77000.0, 7667500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Elisabeth Tualaka Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 72000.0, 7739500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel AS Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 7749500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Aranci Suek Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 7799500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Bpk. Dominggus Kole Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 300000.0, 8099500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel. IB Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 8149500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Naomi A. Henuk Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal" },
                values: new object[] { 100000.0, 8249500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 69000.0, 8318500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marcus Baria Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 150000.0, 8468500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Annie M. Malonda Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8518500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Mikhael Nenotek Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8568500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8618500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 30000.0, 8648500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 8658500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Melkisedek Kasse Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 57000.0, 8715500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Nur M. Tasrap Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 16000.0, 8731500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marthen Patipellohy Rayon 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 60000.0, 8791500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Benyamin Sua Rayon 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 100000.0, 8891500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50000.0, 8941500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Daud Ludji Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 8951500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 111000.0, 9062500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 10000.0, 9072500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 3" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 9082500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 9092500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 5" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 20000.0, 9112500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 6" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 2000.0, 9114500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 64000.0, 9178500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 8" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 10000.0, 9188500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 9" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 10000.0, 9198500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 10" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 50, 10000.0, 9208500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 11" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AkunId", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 9308500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 30000.0, 9338500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 0, 25000.0, 9363500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibu. Febei Nuban Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 44, 0, 100000.0, 9463500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Kristian Walu Logo Rayon 1" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 44, 250000.0, 9713500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Max Warruw Rayon 7" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 14, 100000.0, 9813500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur ULTAH ke-79" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AkunId", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 44, 400000.0, 10213500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 10, 0, 791000.0, 10354500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 81, 0, 643000.0, 10997500.0, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" });

            migrationBuilder.UpdateData(
                table: "TblTransaksi",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AkunId", "Jenis", "Jumlah", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 14, 0, 329000.0, 11326500.0, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" });

            migrationBuilder.UpdateData(
                table: "TblUser",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEOFmNVP85C/54FfHlf5CoIpfodDUjak6UW0CjG8SFIZXIvLhcYYA3x/bOJKk2yMs4w==");
        }
    }
}
