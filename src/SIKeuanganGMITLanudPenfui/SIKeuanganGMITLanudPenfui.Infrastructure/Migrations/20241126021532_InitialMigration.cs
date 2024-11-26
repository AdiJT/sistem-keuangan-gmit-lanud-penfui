using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblJenisAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Tahun = table.Column<int>(type: "integer", nullable: false),
                    Jenis = table.Column<int>(type: "integer", nullable: false),
                    Kode = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblJenisAkun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblKas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Saldo = table.Column<double>(type: "double precision", nullable: false),
                    TanggalDitambahkan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TanggalDiubah = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblRAPBJ",
                columns: table => new
                {
                    Tahun = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRAPBJ", x => x.Tahun);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblKelompokAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Tahun = table.Column<int>(type: "integer", nullable: false),
                    Kode = table.Column<int>(type: "integer", nullable: false),
                    JenisAkunId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblKelompokAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblKelompokAkun_TblJenisAkun_JenisAkunId",
                        column: x => x.JenisAkunId,
                        principalTable: "TblJenisAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblGolonganAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Tahun = table.Column<int>(type: "integer", nullable: false),
                    Kode = table.Column<int>(type: "integer", nullable: false),
                    KelompokAkunId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGolonganAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblGolonganAkun_TblKelompokAkun_KelompokAkunId",
                        column: x => x.KelompokAkunId,
                        principalTable: "TblKelompokAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblAkun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uraian = table.Column<string>(type: "text", nullable: false),
                    Tahun = table.Column<int>(type: "integer", nullable: false),
                    PresentaseSetoran = table.Column<double>(type: "double precision", nullable: true),
                    Kode = table.Column<int>(type: "integer", nullable: false),
                    JenisAkunId = table.Column<int>(type: "integer", nullable: false),
                    KelompokAkunId = table.Column<int>(type: "integer", nullable: true),
                    GolonganAkunId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAkun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblAkun_TblGolonganAkun_GolonganAkunId",
                        column: x => x.GolonganAkunId,
                        principalTable: "TblGolonganAkun",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TblAkun_TblJenisAkun_JenisAkunId",
                        column: x => x.JenisAkunId,
                        principalTable: "TblJenisAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblAkun_TblKelompokAkun_KelompokAkunId",
                        column: x => x.KelompokAkunId,
                        principalTable: "TblKelompokAkun",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TblDetailRAPBJ",
                columns: table => new
                {
                    TahunRAPBJ = table.Column<int>(type: "integer", nullable: false),
                    KodeAkun = table.Column<int>(type: "integer", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Satuan = table.Column<string>(type: "text", nullable: false),
                    HargaSatuan = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDetailRAPBJ", x => new { x.TahunRAPBJ, x.KodeAkun });
                    table.ForeignKey(
                        name: "FK_TblDetailRAPBJ_TblAkun_KodeAkun",
                        column: x => x.KodeAkun,
                        principalTable: "TblAkun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblDetailRAPBJ_TblRAPBJ_TahunRAPBJ",
                        column: x => x.TahunRAPBJ,
                        principalTable: "TblRAPBJ",
                        principalColumn: "Tahun",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblTransaksi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tanggal = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                table: "TblJenisAkun",
                columns: new[] { "Id", "Jenis", "Kode", "Tahun", "Uraian" },
                values: new object[,]
                {
                    { 1, 0, 1, 2024, "Sisa lebih perhitungan tahun (Surplus)" },
                    { 2, 0, 2, 2024, "Kolekte/Persembahan" },
                    { 3, 0, 3, 2024, "Kolekte Ibadah Syukur" },
                    { 4, 0, 4, 2024, "Nazar" },
                    { 5, 0, 5, 2024, "Persepuluhan dan Syukur" },
                    { 6, 0, 6, 2024, "Pembangunan" },
                    { 7, 0, 7, 2024, "Penerimaan Lain-Lain" },
                    { 8, 1, 1, 2024, "Belanja Rutin" },
                    { 9, 1, 2, 2024, "Belanja Program Pelayanan" },
                    { 10, 1, 3, 2024, "Belanja Lain-Lain" }
                });

            migrationBuilder.InsertData(
                table: "TblKas",
                columns: new[] { "Id", "Saldo", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[] { 1, 10852500.0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kas Bank GMIT Lanud" });

            migrationBuilder.InsertData(
                table: "TblRAPBJ",
                column: "Tahun",
                value: 2024);

            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "Id", "PasswordHash", "Role", "UserName" },
                values: new object[] { 1, "AQAAAAIAAYagAAAAEJfanTsw/M6qQDf0NTJiEc+QSw0Fsw/b2AhwlXL3eCwggRDGZblUBndJU+1cxw5+hQ==", "Bendahara", "Bendahara" });

            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "Kode", "PresentaseSetoran", "Tahun", "Uraian" },
                values: new object[,]
                {
                    { 1, null, 1, null, 1, 0.5, 2024, "Rutin" },
                    { 2, null, 1, null, 2, 0.5, 2024, "Pembangunan" },
                    { 3, null, 1, null, 3, 0.5, 2024, "Dana Cadangan" },
                    { 4, null, 2, null, 1, 0.5, 2024, "Kolekte Kebaktian Utama Minggu (2 kali/minggu)" },
                    { 5, null, 3, null, 1, 0.5, 2024, "Kolekte Ibadah Syukur Kelulusan" },
                    { 6, null, 3, null, 2, 0.5, 2024, "Kolekte Ibadah Syukur NATAL Rayon" },
                    { 7, null, 3, null, 3, 0.5, 2024, "Kolekte Ibadah Syukur NATAL Keluarga" },
                    { 8, null, 3, null, 4, 0.5, 2024, "Kolekte Ibadah Syukur NATAL Kategorial Lainnya" },
                    { 9, null, 3, null, 5, 0.5, 2024, "Kolekte Ibadah Syukur Pernikahan" },
                    { 10, null, 3, null, 6, 0.5, 2024, "Kolekte Ibadah Syukur Lepas Kabung" },
                    { 11, null, 3, null, 7, 0.5, 2024, "Kolekte Ibadah Syukur Kelahiran" },
                    { 12, null, 3, null, 8, 0.5, 2024, "Kolekte Ibadah HUT Perempuan GMIT JLET Penfui" },
                    { 13, null, 3, null, 9, 0.5, 2024, "Kolekte Ibadah HUT GMIT JLET Penfui" },
                    { 14, null, 3, null, 10, 0.5, 2024, "Kolekte Ibadah Syukur Lainnya" },
                    { 15, null, 4, null, 1, 0.5, 2024, "Nazar Kebaktian Minggu" },
                    { 16, null, 4, null, 2, 0.5, 2024, "Nazar Baptisan Kudus" },
                    { 17, null, 4, null, 3, 0.5, 2024, "Nazar Peneguhan Sidi Baru" },
                    { 18, null, 4, null, 4, 0.5, 2024, "Nazar Pemberkatan Nikah" },
                    { 19, null, 4, null, 5, 0.5, 2024, "Nazar Khusus" },
                    { 20, null, 5, null, 1, 0.5, 2024, "Persepuluhan Kebaktian Minggu" },
                    { 21, null, 5, null, 2, 0.5, 2024, "Persepuluhan Lainnya" },
                    { 22, null, 5, null, 3, 0.5, 2024, "Nazar, Persepuluhan dan Syukur Lainnya" },
                    { 23, null, 5, null, 4, 0.5, 2024, "Syukur Kebaktian Minggu" },
                    { 24, null, 6, null, 1, 0.5, 2024, "10% Tangguk Kolekte Pembangunan" },
                    { 25, null, 6, null, 2, 0.5, 2024, "Tangguk Persembahan di Kebaktian Utama Minggu" },
                    { 26, null, 6, null, 3, 0.5, 2024, "Sumbangan Spontanitas Jemaat" },
                    { 27, null, 6, null, 4, 0.5, 2024, "Hasil Usaha Panitia/Tim Kerja" },
                    { 28, null, 6, null, 5, 0.5, 2024, "Sumbangan Pembangunan Wajib KK (200KK x 12 bln)" },
                    { 29, null, 6, null, 6, 0.5, 2024, "Tunggakan Sumbangan" },
                    { 30, null, 6, null, 7, 0.5, 2024, "Hasil Lelang Natura" },
                    { 31, null, 6, null, 8, 0.5, 2024, "Sumbangan Pembangunan Pihak Lain" },
                    { 32, null, 10, null, 1, null, 2024, "Dana Cadangan" },
                    { 33, null, 10, null, 2, null, 2024, "Administrasi Bank" },
                    { 34, null, 10, null, 3, null, 2024, "Pajak Bunga Bank" },
                    { 35, null, 10, null, 4, null, 2024, "Biaya cetak rekening giro" },
                    { 36, null, 10, null, 5, null, 2024, "Pajak Mobil Pelayanan" },
                    { 37, null, 10, null, 6, null, 2024, "Belanja Pisah/Sambut Pendeta" },
                    { 38, null, 10, null, 7, null, 2024, "Sumbangan Rutin Teritori II K3T" },
                    { 39, null, 10, null, 8, null, 2024, "Kontribusi Kegiatan" },
                    { 40, null, 10, null, 9, null, 2024, "Sumbangan Lainnya" },
                    { 41, null, 10, null, 10, null, 2024, "Belanja Lainnya" },
                    { 232, null, 7, null, 1, 0.5, 2024, "Administrasi Baptisan" },
                    { 233, null, 7, null, 2, 0.5, 2024, "Administrasi Peneguhan Sidi Baru" },
                    { 234, null, 7, null, 3, 0.5, 2024, "Administrasi Pemberkatan Nikah" },
                    { 235, null, 7, null, 4, 0.5, 2024, "Bunga Bank" },
                    { 236, null, 7, null, 5, 0.0, 2024, "Hasil Lelang" },
                    { 237, null, 7, null, 6, 0.5, 2024, "Penerimaan Lainnya" }
                });

            migrationBuilder.InsertData(
                table: "TblKelompokAkun",
                columns: new[] { "Id", "JenisAkunId", "Kode", "Tahun", "Uraian" },
                values: new object[,]
                {
                    { 1, 2, 2, 2024, "Kolekte Kebaktian Hari Raya Gerejawi" },
                    { 2, 2, 3, 2024, "Kolekte Kebaktian Sakramen Perjamuan Kudus" },
                    { 3, 2, 4, 2024, "Kolekte Kebaktian Baptisan Kudus" },
                    { 4, 2, 5, 2024, "Kolekte Kebaktian Peneguhan Sidi Baru" },
                    { 5, 2, 6, 2024, "Kolekte Kebaktian Pemberkatan Nikah" },
                    { 6, 2, 7, 2024, "Kolekte Ibadah Rumah Tangga" },
                    { 7, 2, 8, 2024, "Kolekte Ibadah Kategorial/Fungsional, dll" },
                    { 8, 8, 1, 2024, "Pos Penghasilan Pendeta dan MJH" },
                    { 9, 8, 2, 2024, "Belanja BPPPJ" },
                    { 10, 8, 3, 2024, "Belanja Karyawan" },
                    { 11, 8, 4, 2024, "Tunjangan Khusus Karyawan/Presbiter" },
                    { 12, 8, 5, 2024, "Belanja Kantor" },
                    { 13, 8, 6, 2024, "Belanja Pengadaan & Pemeliharaan" },
                    { 14, 8, 7, 2024, "Belanja Perjalanan" },
                    { 15, 8, 8, 2024, "Belanja Tanggungan Rutin Jemaat" },
                    { 16, 9, 1, 2024, "Bidang Koinonia" },
                    { 17, 9, 2, 2024, "Bidang Marturia" },
                    { 18, 9, 3, 2024, "Bidang Liturgia" },
                    { 19, 9, 4, 2024, "Bidang Diakonia" },
                    { 20, 9, 5, 2024, "Bidang Oikonomia" },
                    { 21, 9, 6, 2024, "Bidang Umum dan Rekomendasi" }
                });

            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "Kode", "PresentaseSetoran", "Tahun", "Uraian" },
                values: new object[,]
                {
                    { 42, null, 2, 1, 1, 0.5, 2024, "Kebaktian Hari Reformasi & HUT GMIT" },
                    { 43, null, 2, 1, 2, 0.5, 2024, "Kebaktian Malam NATAL" },
                    { 44, null, 2, 1, 3, 0.5, 2024, "Kebaktian Malam NATAL (Keluarga)" },
                    { 45, null, 2, 1, 4, 0.5, 2024, "Kebaktian NATAL" },
                    { 46, null, 2, 1, 5, 0.5, 2024, "Kebaktian Syukur NATAL" },
                    { 47, null, 2, 1, 6, 0.5, 2024, "Kebaktian NATAL JLET" },
                    { 48, null, 2, 1, 7, 0.5, 2024, "Kebaktian NATAL PAR" },
                    { 49, null, 2, 1, 8, 0.5, 2024, "Kebaktian Kunci Tahun" },
                    { 50, null, 2, 1, 9, 0.5, 2024, "Kebaktian Kunci Tahun (Keluarga)" },
                    { 51, null, 2, 1, 10, 0.5, 2024, "Kebaktian Tahun Baru " },
                    { 52, null, 2, 1, 11, 0.5, 2024, "Kebaktian Jumat Agung" },
                    { 53, null, 2, 1, 12, 0.5, 2024, "Kebaktian Paskah" },
                    { 54, null, 2, 1, 13, 0.5, 2024, "Kebaktian Syukur Paskah" },
                    { 55, null, 2, 2, 1, 0.5, 2024, "Kebaktian Persiapan Perjamuan Kudus" },
                    { 56, null, 2, 2, 2, 0.5, 2024, "Kebaktian Sakramen Perjamuan Kudus" },
                    { 57, null, 2, 3, 1, 0.5, 2024, "Kebaktian Persiapan Baptisan Kudus" },
                    { 58, null, 2, 3, 2, 0.5, 2024, "Kebaktian Sakramen Baptisan Kudus" },
                    { 59, null, 2, 4, 1, 0.5, 2024, "Kebaktian Persiapan Peneguhan Sidi Baru" },
                    { 60, null, 2, 4, 2, 0.5, 2024, "Kebaktian Peneguhan Anggota Sidi Baru" },
                    { 61, null, 2, 5, 1, 0.5, 2024, "Pastoral" },
                    { 62, null, 2, 5, 2, 0.5, 2024, "Kebaktian Persiapan/Penggembalaan" },
                    { 63, null, 2, 5, 3, 0.5, 2024, "Kebaktian Pemberkatan Nikah" },
                    { 64, null, 2, 6, 1, 0.5, 2024, "Rayon 1" },
                    { 65, null, 2, 6, 2, 0.5, 2024, "Rayon 2" },
                    { 66, null, 2, 6, 3, 0.5, 2024, "Rayon 3" },
                    { 67, null, 2, 6, 4, 0.5, 2024, "Rayon 4" },
                    { 68, null, 2, 6, 5, 0.5, 2024, "Rayon 5" },
                    { 69, null, 2, 6, 6, 0.5, 2024, "Rayon 6" },
                    { 70, null, 2, 6, 7, 0.5, 2024, "Rayon 7" },
                    { 71, null, 2, 7, 1, 0.5, 2024, "Kolekte Ibadah PAR" },
                    { 72, null, 2, 7, 2, 0.5, 2024, "Kolekte Ibadah Pemuda" },
                    { 73, null, 2, 7, 3, 0.5, 2024, "Kolekte Ibadah Kaum Perempuan" },
                    { 74, null, 2, 7, 4, 0.5, 2024, "Kolekte Ibadah Kaum Bapak" },
                    { 75, null, 2, 7, 5, 0.5, 2024, "Kolekte Ibadah Lansia" },
                    { 76, null, 2, 7, 6, 0.5, 2024, "Kolekte Ibadah Kunci Usbuh" },
                    { 77, null, 2, 7, 7, 0.5, 2024, "Kolekte Ibadah Katekasasi Reguler" },
                    { 78, null, 2, 7, 8, 0.5, 2024, "Kolekte Ibadah Katekasasi Pra Nikah" },
                    { 79, null, 2, 7, 9, 0.5, 2024, "Kolekte Ibadah Persekutuan Doa" },
                    { 80, null, 2, 7, 10, 0.5, 2024, "Kolekte Ibadah PS/VG" },
                    { 81, null, 2, 7, 11, 0.5, 2024, "Kolekte Ibadah Lainnya" },
                    { 82, null, 8, 9, 1, null, 2024, "Uang Harian" },
                    { 83, null, 8, 9, 2, null, 2024, "Konsumsi Rapat" },
                    { 84, null, 8, 9, 3, null, 2024, "Pembuatan LHPP" },
                    { 85, null, 8, 10, 1, null, 2024, "Gaji Koster" },
                    { 86, null, 8, 10, 2, null, 2024, "Gaji Tata Usaha (TU) Gereja" },
                    { 87, null, 8, 10, 3, null, 2024, "Gaji Sopir" },
                    { 88, null, 8, 10, 4, null, 2024, "Insentif Calon Vicaris (CAVIK)" },
                    { 89, null, 8, 10, 5, null, 2024, "Insentif Song Leader/Prokantor (2 orang)" },
                    { 90, null, 8, 10, 6, null, 2024, "Insentif Organis/Sound System (2 orang)" },
                    { 91, null, 8, 10, 7, null, 2024, "Insentif Operator LCD" },
                    { 92, null, 8, 10, 8, null, 2024, "Jasa sopir tidak tetap" },
                    { 93, null, 8, 11, 1, null, 2024, "Tunjangan Khusus Koster" },
                    { 94, null, 8, 11, 2, null, 2024, "Tunjangan Khusus TU Gereja" },
                    { 95, null, 8, 11, 3, null, 2024, "Tunjangan Khusus Sopir" },
                    { 96, null, 8, 11, 4, null, 2024, "Tunjangan Khusus Calon Vicaris (CAVIK)" },
                    { 97, null, 8, 11, 5, null, 2024, "Tunjangan Khusus Organis/Sound Systim" },
                    { 98, null, 8, 11, 6, null, 2024, "Tunjangan Khusus Operator LCD" },
                    { 99, null, 8, 11, 7, null, 2024, "Tunjangan Khusus Presbiter" },
                    { 100, null, 8, 12, 1, null, 2024, "Alat Tulis Kantor (ATK) dan Bahan Habis Pakai Lainnya " },
                    { 101, null, 8, 12, 2, null, 2024, "Biaya Penggandaan dan Cetak" },
                    { 102, null, 8, 12, 3, null, 2024, "ATK, Biaya Penggandaan dan Cetak kegiatan sidang program tahun pelayanan 2025" },
                    { 103, null, 8, 12, 4, null, 2024, "Biaya Listrik (Gereja dan Pastori)" },
                    { 104, null, 8, 12, 5, null, 2024, "Air" },
                    { 105, null, 8, 12, 6, null, 2024, "Telepon/Indihome/Wifi" },
                    { 106, null, 8, 12, 7, null, 2024, "Alat & Bahan Kebersihan/Kesehatan" },
                    { 107, null, 8, 13, 1, null, 2024, "Pengadaan Barang Inventaris (Keyboard)" },
                    { 108, null, 8, 13, 2, null, 2024, "Pemeliharaan Barang Inventaris" },
                    { 109, null, 8, 13, 3, null, 2024, "Pemeliharaan Gedung (Gereja, Pastori, dll)" },
                    { 110, null, 8, 13, 4, null, 2024, "Pemeliharaan Mobil Pelayanan" },
                    { 111, null, 8, 13, 5, null, 2024, "Pemeliharaan Instalasi Air dan Instalasi Listrik" },
                    { 112, null, 8, 13, 6, null, 2024, "Bahan Bakar" },
                    { 113, null, 8, 13, 7, null, 2024, "Pengadaan Buku Pedoman Organisasi & Buku Lainnya" },
                    { 114, null, 8, 13, 8, null, 2024, "Pengadaan Surat Gerejawi" },
                    { 115, null, 8, 13, 9, null, 2024, "Pengadaan poni gorden jendela gereja warna hijau" },
                    { 116, null, 8, 13, 10, null, 2024, "Pengadaan meja" },
                    { 117, null, 8, 13, 11, null, 2024, "Pengadaan CCTV" },
                    { 118, null, 8, 13, 12, null, 2024, "Pengadaan gitar akustik" },
                    { 119, null, 8, 13, 13, null, 2024, "Pengadaan Alat Musik (Kajon)" },
                    { 120, null, 8, 14, 2, null, 2024, "Transport Pendeta & (MJH) mengikuti Rapat/Sidang" },
                    { 121, null, 8, 14, 3, null, 2024, "Transport Pendeta Tamu" },
                    { 122, null, 8, 14, 4, null, 2024, "Transport MKH/MSH atas undangan jemaat" },
                    { 123, null, 8, 14, 5, null, 2024, "Transport Presbiter/BP/UPP, dll" },
                    { 124, null, 8, 14, 6, null, 2024, "Transport MJH ke kantor Klasis/Sinode" },
                    { 125, null, 8, 14, 7, null, 2024, "Transport Bendahara/TU ke Bank" },
                    { 126, null, 8, 14, 8, null, 2024, "Transport Pemateri" },
                    { 127, null, 8, 14, 9, null, 2024, "Transport Lainnya" },
                    { 128, null, 8, 15, 1, null, 2024, "Setoran Sentralisasi Gaji Pokok (SGP)" },
                    { 129, null, 8, 15, 2, null, 2024, "Setoran 10% Penerimaan (Dana Rutin)" },
                    { 130, null, 8, 15, 3, null, 2024, "Setoran 10% Dana Pembangunan" },
                    { 131, null, 8, 15, 4, null, 2024, "Setoran 2% Dana Pendidikan" },
                    { 132, null, 8, 15, 5, null, 2024, "Setoran Dana Kebersamaan" },
                    { 133, null, 9, 16, 1, null, 2024, "Perayaan Hari Ibu dan Natal" },
                    { 134, null, 9, 16, 2, null, 2024, "Ibadah Gabungan LANSIA Teritori 2" },
                    { 135, null, 9, 16, 3, null, 2024, "Ibadah Gabungan Persekutuan Doa Teritori 2" },
                    { 136, null, 9, 16, 4, null, 2024, "Ibadah Kreatif Persekutuan Doa" },
                    { 137, null, 9, 16, 5, null, 2024, "Ibadah Syukur Natal Pemuda Teritori 2" },
                    { 138, null, 9, 16, 6, null, 2024, "Ibadah Gabungan Kaum Perempuan Teritori 2" },
                    { 139, null, 9, 16, 7, null, 2024, "Ibadah Pemuda Teritori-dalam klasis-luar klasis" },
                    { 140, null, 9, 16, 8, null, 2024, "Ibadah NATAL PART" },
                    { 141, null, 9, 16, 9, null, 2024, "Ibadah PASUTRI JLET" },
                    { 142, null, 9, 16, 10, null, 2024, "Ibadah Padang memperingati HUT Reformasi dan GMIT" },
                    { 143, null, 9, 16, 11, null, 2024, "Ibadah syukur HUT JLET" },
                    { 144, null, 9, 16, 12, null, 2024, "Ibadah syukur Natal JLET" },
                    { 145, null, 9, 16, 13, null, 2024, "Ibadah Kreatif BP, UPP dan BP JLET" },
                    { 146, null, 9, 16, 14, null, 2024, "Ibadah Kreatif Pemuda 3" },
                    { 147, null, 9, 16, 15, null, 2024, "Ibadah Kreatif Pemuda 4" },
                    { 148, null, 9, 16, 16, null, 2024, "Ibadah ke Rote (UPP Perempuan)" },
                    { 149, null, 9, 17, 1, null, 2024, "Bakti Sosial PART" },
                    { 150, null, 9, 17, 2, null, 2024, "Lomba PASKAH PART" },
                    { 151, null, 9, 17, 3, null, 2024, "Lomba HUT RI PART" },
                    { 152, null, 9, 17, 4, null, 2024, "Perayaan NATAL PART" },
                    { 153, null, 9, 17, 5, null, 2024, "Pelatihan Kepemimpinan Pemuda" },
                    { 154, null, 9, 17, 6, null, 2024, "Lomba Kreasi Salib memperingati PASKAH 2024" },
                    { 155, null, 9, 17, 7, null, 2024, "Malam puji-pujian menyambut PASKAH" },
                    { 156, null, 9, 17, 8, null, 2024, "Pawai PASKAH JLET" },
                    { 157, null, 9, 17, 9, null, 2024, "Lomba voly Putra-Putri antar Rayon memperingati Bulan keluarga" },
                    { 158, null, 9, 17, 10, null, 2024, "Lomba memasak nasi goreng antar keluarga dari tiap rayon memperingati Bulan Keluarga" },
                    { 159, null, 9, 17, 11, null, 2024, "Lomba VG Kaum Bapak Memperingati HUT JLET" },
                    { 160, null, 9, 17, 12, null, 2024, "Lomba CCA Keluarga antar Rayon" },
                    { 161, null, 9, 17, 13, null, 2024, "Lomba Pohon Natal antar rayon di lingkungan gereja" },
                    { 162, null, 9, 17, 14, null, 2024, "Insentif Pengajar Katekasasi (2 orang)" },
                    { 163, null, 9, 17, 15, null, 2024, "Insentif Pengajar UPP PAR" },
                    { 164, null, 9, 17, 16, null, 2024, "Memberikan Apresiasi kepada anak-anak (Sertifikat Naik Kelas, dll)" },
                    { 165, null, 9, 18, 1, null, 2024, "Pengadaan Bahan Perjamuan Kudus" },
                    { 166, null, 9, 18, 2, null, 2024, "Perbaikan peti keyboard" },
                    { 167, null, 9, 18, 3, null, 2024, "Pengadaan meja operator slide" },
                    { 168, null, 9, 18, 4, null, 2024, "Insentif songlider, musik dan operator slide " },
                    { 169, null, 9, 18, 5, null, 2024, "Insentif Soundman" },
                    { 170, null, 9, 19, 1, null, 2024, "Diakonia Sakit" },
                    { 171, null, 9, 19, 2, null, 2024, "Diakonia Duka Cita" },
                    { 172, null, 9, 19, 3, null, 2024, "Diakonia bagi jemaat JLET yang tidak mampu" },
                    { 173, null, 9, 19, 4, null, 2024, "Pemeriksaan Kesehatan bagi LANSIA" },
                    { 174, null, 9, 19, 5, null, 2024, "Bingkisan Kasih Majelis Jemaat" },
                    { 175, null, 9, 19, 6, null, 2024, "Pelatihan peningkatan kapasitas diaken dalam pelayanan diakonia holistik" },
                    { 176, null, 9, 19, 7, null, 2024, "Pelatihan Ketrampilan (Vokasi) Bagi Jemaat (PEMUDA)" },
                    { 177, null, 9, 19, 8, null, 2024, "Beasiswa pendidikan kepada anak berprestasi  yang kurang mampu." },
                    { 178, null, 9, 19, 9, null, 2024, "Pemberian bantuan dana pendidikan untuk calon mahasiswa musik gerejawi" },
                    { 179, null, 9, 19, 10, null, 2024, "Bantuan bagi warga JLET yang mengalami bencana alam dan Non Alam" },
                    { 180, null, 9, 19, 11, null, 2024, "Diakonia Lain-Lain" },
                    { 181, null, 9, 20, 5, null, 2024, "Pemanfaatan pekarangan gereja (dapur hidup, apotik hidup)" },
                    { 182, null, 9, 20, 6, null, 2024, "Pelatihan musik Kaum Bapak (transportasi pelatih)" },
                    { 183, null, 9, 21, 1, null, 2024, "Pengurusan Sertifikat Tanah (Balik Nama)" },
                    { 184, null, 9, 21, 2, null, 2024, "Pemasangan Identitas Mobil Pelayanan JLET" }
                });

            migrationBuilder.InsertData(
                table: "TblDetailRAPBJ",
                columns: new[] { "KodeAkun", "TahunRAPBJ", "HargaSatuan", "Satuan", "Volume" },
                values: new object[,]
                {
                    { 1, 2024, 10000.0, "kali", 1 },
                    { 2, 2024, 10000.0, "kali", 1 },
                    { 3, 2024, 10000.0, "kali", 1 },
                    { 4, 2024, 10000.0, "kali", 1 },
                    { 5, 2024, 10000.0, "kali", 1 },
                    { 6, 2024, 10000.0, "kali", 1 },
                    { 7, 2024, 10000.0, "kali", 1 },
                    { 8, 2024, 10000.0, "kali", 1 },
                    { 9, 2024, 10000.0, "kali", 1 },
                    { 10, 2024, 10000.0, "kali", 1 },
                    { 11, 2024, 10000.0, "kali", 1 },
                    { 12, 2024, 10000.0, "kali", 1 },
                    { 13, 2024, 10000.0, "kali", 1 },
                    { 14, 2024, 10000.0, "kali", 1 },
                    { 15, 2024, 10000.0, "kali", 1 },
                    { 16, 2024, 10000.0, "kali", 1 },
                    { 17, 2024, 10000.0, "kali", 1 },
                    { 18, 2024, 10000.0, "kali", 1 },
                    { 19, 2024, 10000.0, "kali", 1 },
                    { 20, 2024, 10000.0, "kali", 1 },
                    { 21, 2024, 10000.0, "kali", 1 },
                    { 22, 2024, 10000.0, "kali", 1 },
                    { 23, 2024, 10000.0, "kali", 1 },
                    { 24, 2024, 10000.0, "kali", 1 },
                    { 25, 2024, 10000.0, "kali", 1 },
                    { 26, 2024, 10000.0, "kali", 1 },
                    { 27, 2024, 10000.0, "kali", 1 },
                    { 28, 2024, 10000.0, "kali", 1 },
                    { 29, 2024, 10000.0, "kali", 1 },
                    { 30, 2024, 10000.0, "kali", 1 },
                    { 31, 2024, 10000.0, "kali", 1 },
                    { 32, 2024, 10000.0, "kali", 1 },
                    { 33, 2024, 10000.0, "kali", 1 },
                    { 34, 2024, 10000.0, "kali", 1 },
                    { 35, 2024, 10000.0, "kali", 1 },
                    { 36, 2024, 10000.0, "kali", 1 },
                    { 37, 2024, 10000.0, "kali", 1 },
                    { 38, 2024, 10000.0, "kali", 1 },
                    { 39, 2024, 10000.0, "kali", 1 },
                    { 40, 2024, 10000.0, "kali", 1 },
                    { 41, 2024, 10000.0, "kali", 1 },
                    { 232, 2024, 10000.0, "kali", 1 },
                    { 233, 2024, 10000.0, "kali", 1 },
                    { 234, 2024, 10000.0, "kali", 1 },
                    { 235, 2024, 10000.0, "kali", 1 },
                    { 236, 2024, 10000.0, "kali", 1 },
                    { 237, 2024, 10000.0, "kali", 1 }
                });

            migrationBuilder.InsertData(
                table: "TblGolonganAkun",
                columns: new[] { "Id", "KelompokAkunId", "Kode", "Tahun", "Uraian" },
                values: new object[,]
                {
                    { 1, 8, 1, 2024, "Tunjangan Ketua Majelis Jemaat (KMJ)" },
                    { 2, 8, 2, 2024, "Insentif MJH" },
                    { 3, 8, 4, 2024, "Tunjangan Khusus MJH" },
                    { 4, 8, 3, 2024, "Gaji Ke-13" },
                    { 5, 12, 8, 2024, "Biaya Konsumsi" },
                    { 6, 14, 1, 2024, "Biaya Perjalanan Dinas Pendeta" },
                    { 7, 20, 1, 2024, "Renovasi Gedung Ibadah" },
                    { 8, 20, 2, 2024, "Renovasi Gedung Pusat Kegiatan PART, Pemuda dan Serba Guna" },
                    { 9, 20, 3, 2024, "Renovasi Rumah Pastori" },
                    { 10, 20, 4, 2024, "Renovasi Pertamanan" }
                });

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 2, 16, "https://file/1", 0, 5000.0, 1, 6966500.0, new DateTime(2024, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 1" },
                    { 3, 16, "https://file/1", 0, 10000.0, 1, 6976500.0, new DateTime(2024, 1, 1, 0, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 2" },
                    { 4, 18, "https://file/1", 0, 100000.0, 1, 7076500.0, new DateTime(2024, 1, 1, 0, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 3" },
                    { 5, 19, "https://file/1", 0, 10000.0, 1, 7086500.0, new DateTime(2024, 1, 1, 0, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 4" },
                    { 6, 16, "https://file/1", 0, 5000.0, 1, 7091500.0, new DateTime(2024, 1, 1, 0, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 5" },
                    { 7, 17, "https://file/1", 0, 20000.0, 1, 7111500.0, new DateTime(2024, 1, 1, 0, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima nazar Tanpa Nama 6" },
                    { 8, 21, "https://file/1", 0, 30000.0, 1, 7141500.0, new DateTime(2024, 1, 1, 0, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 1" },
                    { 9, 21, "https://file/1", 0, 50000.0, 1, 7191500.0, new DateTime(2024, 1, 1, 0, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 2" },
                    { 10, 21, "https://file/1", 0, 10000.0, 1, 7201500.0, new DateTime(2024, 1, 1, 0, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 3" },
                    { 11, 21, "https://file/1", 0, 9000.0, 1, 7210500.0, new DateTime(2024, 1, 1, 0, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 4" },
                    { 12, 21, "https://file/1", 0, 5000.0, 1, 7215500.0, new DateTime(2024, 1, 1, 0, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 5" },
                    { 13, 21, "https://file/1", 0, 10000.0, 1, 7225500.0, new DateTime(2024, 1, 1, 0, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 6" },
                    { 14, 21, "https://file/1", 0, 50000.0, 1, 7275500.0, new DateTime(2024, 1, 1, 0, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima perpuluhan tidak tetap Tanpa Nama 7" },
                    { 15, 22, "https://file/1", 0, 10000.0, 1, 7285500.0, new DateTime(2024, 1, 1, 0, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 1" },
                    { 16, 22, "https://file/1", 0, 5000.0, 1, 7290500.0, new DateTime(2024, 1, 1, 0, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 2" },
                    { 17, 22, "https://file/1", 0, 10000.0, 1, 7300500.0, new DateTime(2024, 1, 1, 0, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 3" },
                    { 18, 22, "https://file/1", 0, 50000.0, 1, 7350500.0, new DateTime(2024, 1, 1, 0, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 4" },
                    { 19, 22, "https://file/1", 0, 50000.0, 1, 7400500.0, new DateTime(2024, 1, 1, 0, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 5" },
                    { 20, 22, "https://file/1", 0, 100000.0, 1, 7500500.0, new DateTime(2024, 1, 1, 0, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 6" },
                    { 21, 22, "https://file/1", 0, 10000.0, 1, 7510500.0, new DateTime(2024, 1, 1, 0, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 7" },
                    { 22, 22, "https://file/1", 0, 10000.0, 1, 7520500.0, new DateTime(2024, 1, 1, 0, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 8" },
                    { 23, 22, "https://file/1", 0, 10000.0, 1, 7530500.0, new DateTime(2024, 1, 1, 0, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 9" },
                    { 24, 22, "https://file/1", 0, 10000.0, 1, 7540500.0, new DateTime(2024, 1, 1, 0, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur Tanpa Nama 10" },
                    { 61, 14, "https://file/1", 0, 100000.0, 1, 9813500.0, new DateTime(2024, 1, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima persembahan syukur ULTAH ke-79" },
                    { 65, 10, "https://file/1", 0, 791000.0, 1, 10354500.0, new DateTime(2024, 1, 1, 1, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 67, 14, "https://file/1", 0, 329000.0, 1, 11326500.0, new DateTime(2024, 1, 5, 1, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" }
                });

            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "Kode", "PresentaseSetoran", "Tahun", "Uraian" },
                values: new object[,]
                {
                    { 185, 1, 8, null, 1, null, 2024, "Tunjangan Struktural" },
                    { 186, 1, 8, null, 2, null, 2024, "Tunjangan Kesejahteraan (Kesra)" },
                    { 187, 1, 8, null, 3, null, 2024, "Tunjangan Kesehatan" },
                    { 188, 1, 8, null, 4, null, 2024, "Tunjangan Lainnya" },
                    { 189, 2, 8, null, 1, null, 2024, "Wakil Ketua" },
                    { 190, 2, 8, null, 2, null, 2024, "Sekretaris" },
                    { 191, 2, 8, null, 3, null, 2024, "Wakil Sekretaris" },
                    { 192, 2, 8, null, 4, null, 2024, "Bendahara" },
                    { 193, 2, 8, null, 5, null, 2024, "Wakil Bendahara" },
                    { 194, 3, 8, null, 1, null, 2024, "Gaji Ke-13 KMJ" },
                    { 195, 4, 8, null, 1, null, 2024, "Ketua Majelis Jemaat (KMJ)" },
                    { 196, 4, 8, null, 2, null, 2024, "Wakil Ketua" },
                    { 197, 4, 8, null, 3, null, 2024, "Sekretaris" },
                    { 198, 4, 8, null, 4, null, 2024, "Wakil Sekretaris" },
                    { 199, 4, 8, null, 5, null, 2024, "Bendahara" },
                    { 200, 4, 8, null, 6, null, 2024, "Wakil Bendahara" },
                    { 201, 5, 8, null, 1, null, 2024, "Konsumsi Pertemuan/Rapat Pendeta" },
                    { 202, 5, 8, null, 2, null, 2024, "Konsumsi Pendeta Tamu dan Tamu Pendeta" },
                    { 203, 5, 8, null, 3, null, 2024, "Konsumsi Lembur MJH" },
                    { 204, 5, 8, null, 4, null, 2024, "Konsumsi UPP/BP/Tim Kerja, dll" },
                    { 205, 5, 8, null, 5, null, 2024, "Rapat evaluasi program dan kegiatan lainnya" },
                    { 206, 5, 8, null, 6, null, 2024, "Sidang Program Tahun Pelayanan 2025" },
                    { 207, 5, 8, null, 7, null, 2024, "Konsumsi Lainnya" },
                    { 209, 6, 8, null, 1, null, 2024, "Lumpsum Luar Daerah" },
                    { 210, 6, 8, null, 2, null, 2024, "Penginapan" },
                    { 211, 6, 8, null, 3, null, 2024, "Transportasi (luar daerah)" },
                    { 212, 6, 8, null, 4, null, 2024, "Transportasi (dalam daerah)" },
                    { 213, 6, 8, null, 5, null, 2024, "Lumpsum dalam Daerah" },
                    { 214, 6, 8, null, 6, null, 2024, "Rekoleksi (Kupang - Siangapore PP)" },
                    { 215, 7, 9, null, 1, null, 2024, "Pembangunan" },
                    { 216, 7, 9, null, 2, null, 2024, "Pasang Ganti Penutup Atap" },
                    { 217, 7, 9, null, 3, null, 2024, "Pasang Ganti Kuda - kuda" },
                    { 218, 7, 9, null, 4, null, 2024, "Pasang Ganti Plafond" },
                    { 219, 8, 9, null, 1, null, 2024, "Finishing Dinding" },
                    { 220, 8, 9, null, 2, null, 2024, "Finishing Lantai" },
                    { 221, 8, 9, null, 3, null, 2024, "Finishing Atap" },
                    { 222, 8, 9, null, 4, null, 2024, "Pasang Baru Plafond" },
                    { 223, 8, 9, null, 5, null, 2024, "Pasang Baru Penerangan dan Kelistrikan" },
                    { 224, 8, 9, null, 6, null, 2024, "Pasang Baru Toilet dan Kelengkapan" },
                    { 225, 9, 9, null, 1, null, 2024, "Perbaikan Atap" },
                    { 226, 9, 9, null, 2, null, 2024, "Perbaikan Listrik" },
                    { 227, 10, 9, null, 1, null, 2024, "Pasang Baru Penutup Gerbang" },
                    { 228, 10, 9, null, 2, null, 2024, "Pasang Baru Railing Tangga Talud" },
                    { 229, 10, 9, null, 3, null, 2024, "Pasang Baru Kanopi Parkiran" },
                    { 230, 10, 9, null, 4, null, 2024, "Pasang Baru Pos Jaga" },
                    { 231, 10, 9, null, 5, null, 2024, "Normalisasi Area Parkir" }
                });

            migrationBuilder.InsertData(
                table: "TblDetailRAPBJ",
                columns: new[] { "KodeAkun", "TahunRAPBJ", "HargaSatuan", "Satuan", "Volume" },
                values: new object[,]
                {
                    { 42, 2024, 10000.0, "kali", 1 },
                    { 43, 2024, 10000.0, "kali", 1 },
                    { 44, 2024, 10000.0, "kali", 1 },
                    { 45, 2024, 10000.0, "kali", 1 },
                    { 46, 2024, 10000.0, "kali", 1 },
                    { 47, 2024, 10000.0, "kali", 1 },
                    { 48, 2024, 10000.0, "kali", 1 },
                    { 49, 2024, 10000.0, "kali", 1 },
                    { 50, 2024, 10000.0, "kali", 1 },
                    { 51, 2024, 10000.0, "kali", 1 },
                    { 52, 2024, 10000.0, "kali", 1 },
                    { 53, 2024, 10000.0, "kali", 1 },
                    { 54, 2024, 10000.0, "kali", 1 },
                    { 55, 2024, 10000.0, "kali", 1 },
                    { 56, 2024, 10000.0, "kali", 1 },
                    { 57, 2024, 10000.0, "kali", 1 },
                    { 58, 2024, 10000.0, "kali", 1 },
                    { 59, 2024, 10000.0, "kali", 1 },
                    { 60, 2024, 10000.0, "kali", 1 },
                    { 61, 2024, 10000.0, "kali", 1 },
                    { 62, 2024, 10000.0, "kali", 1 },
                    { 63, 2024, 10000.0, "kali", 1 },
                    { 64, 2024, 10000.0, "kali", 1 },
                    { 65, 2024, 10000.0, "kali", 1 },
                    { 66, 2024, 10000.0, "kali", 1 },
                    { 67, 2024, 10000.0, "kali", 1 },
                    { 68, 2024, 10000.0, "kali", 1 },
                    { 69, 2024, 10000.0, "kali", 1 },
                    { 70, 2024, 10000.0, "kali", 1 },
                    { 71, 2024, 10000.0, "kali", 1 },
                    { 72, 2024, 10000.0, "kali", 1 },
                    { 73, 2024, 10000.0, "kali", 1 },
                    { 74, 2024, 10000.0, "kali", 1 },
                    { 75, 2024, 10000.0, "kali", 1 },
                    { 76, 2024, 10000.0, "kali", 1 },
                    { 77, 2024, 10000.0, "kali", 1 },
                    { 78, 2024, 10000.0, "kali", 1 },
                    { 79, 2024, 10000.0, "kali", 1 },
                    { 80, 2024, 10000.0, "kali", 1 },
                    { 81, 2024, 10000.0, "kali", 1 },
                    { 82, 2024, 10000.0, "kali", 1 },
                    { 83, 2024, 10000.0, "kali", 1 },
                    { 84, 2024, 10000.0, "kali", 1 },
                    { 85, 2024, 10000.0, "kali", 1 },
                    { 86, 2024, 10000.0, "kali", 1 },
                    { 87, 2024, 10000.0, "kali", 1 },
                    { 88, 2024, 10000.0, "kali", 1 },
                    { 89, 2024, 10000.0, "kali", 1 },
                    { 90, 2024, 10000.0, "kali", 1 },
                    { 91, 2024, 10000.0, "kali", 1 },
                    { 92, 2024, 10000.0, "kali", 1 },
                    { 93, 2024, 10000.0, "kali", 1 },
                    { 94, 2024, 10000.0, "kali", 1 },
                    { 95, 2024, 10000.0, "kali", 1 },
                    { 96, 2024, 10000.0, "kali", 1 },
                    { 97, 2024, 10000.0, "kali", 1 },
                    { 98, 2024, 10000.0, "kali", 1 },
                    { 99, 2024, 10000.0, "kali", 1 },
                    { 100, 2024, 10000.0, "kali", 1 },
                    { 101, 2024, 10000.0, "kali", 1 },
                    { 102, 2024, 10000.0, "kali", 1 },
                    { 103, 2024, 10000.0, "kali", 1 },
                    { 104, 2024, 10000.0, "kali", 1 },
                    { 105, 2024, 10000.0, "kali", 1 },
                    { 106, 2024, 10000.0, "kali", 1 },
                    { 107, 2024, 10000.0, "kali", 1 },
                    { 108, 2024, 10000.0, "kali", 1 },
                    { 109, 2024, 10000.0, "kali", 1 },
                    { 110, 2024, 10000.0, "kali", 1 },
                    { 111, 2024, 10000.0, "kali", 1 },
                    { 112, 2024, 10000.0, "kali", 1 },
                    { 113, 2024, 10000.0, "kali", 1 },
                    { 114, 2024, 10000.0, "kali", 1 },
                    { 115, 2024, 10000.0, "kali", 1 },
                    { 116, 2024, 10000.0, "kali", 1 },
                    { 117, 2024, 10000.0, "kali", 1 },
                    { 118, 2024, 10000.0, "kali", 1 },
                    { 119, 2024, 10000.0, "kali", 1 },
                    { 120, 2024, 10000.0, "kali", 1 },
                    { 121, 2024, 10000.0, "kali", 1 },
                    { 122, 2024, 10000.0, "kali", 1 },
                    { 123, 2024, 10000.0, "kali", 1 },
                    { 124, 2024, 10000.0, "kali", 1 },
                    { 125, 2024, 10000.0, "kali", 1 },
                    { 126, 2024, 10000.0, "kali", 1 },
                    { 127, 2024, 10000.0, "kali", 1 },
                    { 128, 2024, 10000.0, "kali", 1 },
                    { 129, 2024, 10000.0, "kali", 1 },
                    { 130, 2024, 10000.0, "kali", 1 },
                    { 131, 2024, 10000.0, "kali", 1 },
                    { 132, 2024, 10000.0, "kali", 1 },
                    { 133, 2024, 10000.0, "kali", 1 },
                    { 134, 2024, 10000.0, "kali", 1 },
                    { 135, 2024, 10000.0, "kali", 1 },
                    { 136, 2024, 10000.0, "kali", 1 },
                    { 137, 2024, 10000.0, "kali", 1 },
                    { 138, 2024, 10000.0, "kali", 1 },
                    { 139, 2024, 10000.0, "kali", 1 },
                    { 140, 2024, 10000.0, "kali", 1 },
                    { 141, 2024, 10000.0, "kali", 1 },
                    { 142, 2024, 10000.0, "kali", 1 },
                    { 143, 2024, 10000.0, "kali", 1 },
                    { 144, 2024, 10000.0, "kali", 1 },
                    { 145, 2024, 10000.0, "kali", 1 },
                    { 146, 2024, 10000.0, "kali", 1 },
                    { 147, 2024, 10000.0, "kali", 1 },
                    { 148, 2024, 10000.0, "kali", 1 },
                    { 149, 2024, 10000.0, "kali", 1 },
                    { 150, 2024, 10000.0, "kali", 1 },
                    { 151, 2024, 10000.0, "kali", 1 },
                    { 152, 2024, 10000.0, "kali", 1 },
                    { 153, 2024, 10000.0, "kali", 1 },
                    { 154, 2024, 10000.0, "kali", 1 },
                    { 155, 2024, 10000.0, "kali", 1 },
                    { 156, 2024, 10000.0, "kali", 1 },
                    { 157, 2024, 10000.0, "kali", 1 },
                    { 158, 2024, 10000.0, "kali", 1 },
                    { 159, 2024, 10000.0, "kali", 1 },
                    { 160, 2024, 10000.0, "kali", 1 },
                    { 161, 2024, 10000.0, "kali", 1 },
                    { 162, 2024, 10000.0, "kali", 1 },
                    { 163, 2024, 10000.0, "kali", 1 },
                    { 164, 2024, 10000.0, "kali", 1 },
                    { 165, 2024, 10000.0, "kali", 1 },
                    { 166, 2024, 10000.0, "kali", 1 },
                    { 167, 2024, 10000.0, "kali", 1 },
                    { 168, 2024, 10000.0, "kali", 1 },
                    { 169, 2024, 10000.0, "kali", 1 },
                    { 170, 2024, 10000.0, "kali", 1 },
                    { 171, 2024, 10000.0, "kali", 1 },
                    { 172, 2024, 10000.0, "kali", 1 },
                    { 173, 2024, 10000.0, "kali", 1 },
                    { 174, 2024, 10000.0, "kali", 1 },
                    { 175, 2024, 10000.0, "kali", 1 },
                    { 176, 2024, 10000.0, "kali", 1 },
                    { 177, 2024, 10000.0, "kali", 1 },
                    { 178, 2024, 10000.0, "kali", 1 },
                    { 179, 2024, 10000.0, "kali", 1 },
                    { 180, 2024, 10000.0, "kali", 1 },
                    { 181, 2024, 10000.0, "kali", 1 },
                    { 182, 2024, 10000.0, "kali", 1 },
                    { 183, 2024, 10000.0, "kali", 1 },
                    { 184, 2024, 10000.0, "kali", 1 }
                });

            migrationBuilder.InsertData(
                table: "TblTransaksi",
                columns: new[] { "Id", "AkunId", "FileBukti", "Jenis", "Jumlah", "KasId", "SaldoKas", "Tanggal", "TanggalDitambahkan", "TanggalDiubah", "Uraian" },
                values: new object[,]
                {
                    { 1, 51, "https://file/1", 0, 930000.0, 1, 6961500.0, new DateTime(2024, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolekte" },
                    { 25, 50, "https://file/1", 0, 50000.0, 1, 7590500.0, new DateTime(2024, 1, 1, 0, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Oktovianus Metboki Rayon 5" },
                    { 26, 50, "https://file/1", 0, 77000.0, 1, 7667500.0, new DateTime(2024, 1, 1, 0, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Elisabeth Tualaka Rayon 7" },
                    { 27, 50, "https://file/1", 0, 72000.0, 1, 7739500.0, new DateTime(2024, 1, 1, 0, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel AS Rayon 2" },
                    { 28, 50, "https://file/1", 0, 10000.0, 1, 7749500.0, new DateTime(2024, 1, 1, 0, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Aranci Suek Rayon 4" },
                    { 29, 50, "https://file/1", 0, 50000.0, 1, 7799500.0, new DateTime(2024, 1, 1, 0, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Bpk. Dominggus Kole Rayon 7" },
                    { 30, 50, "https://file/1", 0, 300000.0, 1, 8099500.0, new DateTime(2024, 1, 1, 0, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kel. IB Rayon 4" },
                    { 31, 50, "https://file/1", 0, 50000.0, 1, 8149500.0, new DateTime(2024, 1, 1, 0, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Naomi A. Henuk Rayon 2" },
                    { 32, 50, "https://file/1", 0, 100000.0, 1, 8249500.0, new DateTime(2024, 1, 1, 0, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 33, 50, "https://file/1", 0, 69000.0, 1, 8318500.0, new DateTime(2024, 1, 1, 0, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marcus Baria Rayon 7" },
                    { 34, 50, "https://file/1", 0, 150000.0, 1, 8468500.0, new DateTime(2024, 1, 1, 0, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oma. Annie M. Malonda Rayon 7" },
                    { 35, 50, "https://file/1", 0, 50000.0, 1, 8518500.0, new DateTime(2024, 1, 1, 0, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Mikhael Nenotek Rayon 5" },
                    { 36, 50, "https://file/1", 0, 50000.0, 1, 8568500.0, new DateTime(2024, 1, 1, 0, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 37, 50, "https://file/1", 0, 50000.0, 1, 8618500.0, new DateTime(2024, 1, 1, 0, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa nama Rayon 7" },
                    { 38, 50, "https://file/1", 0, 30000.0, 1, 8648500.0, new DateTime(2024, 1, 1, 0, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 39, 50, "https://file/1", 0, 10000.0, 1, 8658500.0, new DateTime(2024, 1, 1, 0, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Melkisedek Kasse Rayon 4" },
                    { 40, 50, "https://file/1", 0, 57000.0, 1, 8715500.0, new DateTime(2024, 1, 1, 0, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Nur M. Tasrap Rayon 5" },
                    { 41, 50, "https://file/1", 0, 16000.0, 1, 8731500.0, new DateTime(2024, 1, 1, 0, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Marthen Patipellohy Rayon 5" },
                    { 42, 50, "https://file/1", 0, 60000.0, 1, 8791500.0, new DateTime(2024, 1, 1, 0, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Benyamin Sua Rayon 3" },
                    { 43, 50, "https://file/1", 0, 100000.0, 1, 8891500.0, new DateTime(2024, 1, 1, 0, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama Rayon 7" },
                    { 44, 50, "https://file/1", 0, 50000.0, 1, 8941500.0, new DateTime(2024, 1, 1, 0, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Daud Ludji Rayon 4" },
                    { 45, 50, "https://file/1", 0, 10000.0, 1, 8951500.0, new DateTime(2024, 1, 1, 0, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 1" },
                    { 46, 50, "https://file/1", 0, 111000.0, 1, 9062500.0, new DateTime(2024, 1, 1, 0, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 2" },
                    { 47, 50, "https://file/1", 0, 10000.0, 1, 9072500.0, new DateTime(2024, 1, 1, 0, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 3" },
                    { 48, 50, "https://file/1", 0, 10000.0, 1, 9082500.0, new DateTime(2024, 1, 1, 0, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 4" },
                    { 49, 50, "https://file/1", 0, 10000.0, 1, 9092500.0, new DateTime(2024, 1, 1, 0, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 5" },
                    { 50, 50, "https://file/1", 0, 20000.0, 1, 9112500.0, new DateTime(2024, 1, 1, 0, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 6" },
                    { 51, 50, "https://file/1", 0, 2000.0, 1, 9114500.0, new DateTime(2024, 1, 1, 0, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 7" },
                    { 52, 50, "https://file/1", 0, 64000.0, 1, 9178500.0, new DateTime(2024, 1, 1, 0, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 8" },
                    { 53, 50, "https://file/1", 0, 10000.0, 1, 9188500.0, new DateTime(2024, 1, 1, 0, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 9" },
                    { 54, 50, "https://file/1", 0, 10000.0, 1, 9198500.0, new DateTime(2024, 1, 1, 0, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 10" },
                    { 55, 50, "https://file/1", 0, 10000.0, 1, 9208500.0, new DateTime(2024, 1, 1, 0, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama 11" },
                    { 56, 44, "https://file/1", 0, 100000.0, 1, 9308500.0, new DateTime(2024, 1, 1, 0, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanpa Nama" },
                    { 57, 44, "https://file/1", 0, 30000.0, 1, 9338500.0, new DateTime(2024, 1, 1, 0, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. A.J. Sinaga Rayon 2" },
                    { 58, 44, "https://file/1", 0, 25000.0, 1, 9363500.0, new DateTime(2024, 1, 1, 0, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibu. Febei Nuban Rayon 7" },
                    { 59, 44, "https://file/1", 0, 100000.0, 1, 9463500.0, new DateTime(2024, 1, 1, 0, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Kristian Walu Logo Rayon 1" },
                    { 60, 44, "https://file/1", 0, 250000.0, 1, 9713500.0, new DateTime(2024, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bpk. Max Warruw Rayon 7" },
                    { 62, 44, "https://file/1", 0, 400000.0, 1, 10213500.0, new DateTime(2024, 1, 1, 1, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4" },
                    { 63, 171, "https://file/1", 1, 500000.0, 1, 9713500.0, new DateTime(2024, 1, 1, 1, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diakonia Duka Alm. An. Ezra Sioh Rayon 7" },
                    { 64, 101, "https://file/1", 1, 150000.0, 1, 9563500.0, new DateTime(2024, 1, 2, 1, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-" },
                    { 66, 81, "https://file/1", 0, 643000.0, 1, 10997500.0, new DateTime(2024, 1, 3, 1, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th" },
                    { 68, 109, "https://file/1", 1, 40000.0, 1, 11286500.0, new DateTime(2024, 1, 5, 1, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs MCB Broco 6A" },
                    { 69, 109, "https://file/1", 1, 5000.0, 1, 11281500.0, new DateTime(2024, 1, 5, 1, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs Box MCB" },
                    { 70, 100, "https://file/1", 1, 71600.0, 1, 11209900.0, new DateTime(2024, 1, 6, 1, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 4 kg gula pasir timbang @Rp. 17.900,-" },
                    { 71, 100, "https://file/1", 1, 12500.0, 1, 11197400.0, new DateTime(2024, 1, 6, 1, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs teh sariwangi (50P)" },
                    { 72, 100, "https://file/1", 1, 59900.0, 1, 11137500.0, new DateTime(2024, 1, 6, 1, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 1 pcs tugu buaya spesial (1 kg)" },
                    { 73, 100, "https://file/1", 1, 30000.0, 1, 11107500.0, new DateTime(2024, 1, 6, 1, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beli 30 potong kue @Rp. 1.000,-" },
                    { 74, 101, "https://file/1", 1, 255000.0, 1, 10852500.0, new DateTime(2024, 1, 6, 1, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-" }
                });

            migrationBuilder.InsertData(
                table: "TblDetailRAPBJ",
                columns: new[] { "KodeAkun", "TahunRAPBJ", "HargaSatuan", "Satuan", "Volume" },
                values: new object[,]
                {
                    { 185, 2024, 10000.0, "kali", 1 },
                    { 186, 2024, 10000.0, "kali", 1 },
                    { 187, 2024, 10000.0, "kali", 1 },
                    { 188, 2024, 10000.0, "kali", 1 },
                    { 189, 2024, 10000.0, "kali", 1 },
                    { 190, 2024, 10000.0, "kali", 1 },
                    { 191, 2024, 10000.0, "kali", 1 },
                    { 192, 2024, 10000.0, "kali", 1 },
                    { 193, 2024, 10000.0, "kali", 1 },
                    { 194, 2024, 10000.0, "kali", 1 },
                    { 195, 2024, 10000.0, "kali", 1 },
                    { 196, 2024, 10000.0, "kali", 1 },
                    { 197, 2024, 10000.0, "kali", 1 },
                    { 198, 2024, 10000.0, "kali", 1 },
                    { 199, 2024, 10000.0, "kali", 1 },
                    { 200, 2024, 10000.0, "kali", 1 },
                    { 201, 2024, 10000.0, "kali", 1 },
                    { 202, 2024, 10000.0, "kali", 1 },
                    { 203, 2024, 10000.0, "kali", 1 },
                    { 204, 2024, 10000.0, "kali", 1 },
                    { 205, 2024, 10000.0, "kali", 1 },
                    { 206, 2024, 10000.0, "kali", 1 },
                    { 207, 2024, 10000.0, "kali", 1 },
                    { 209, 2024, 10000.0, "kali", 1 },
                    { 210, 2024, 10000.0, "kali", 1 },
                    { 211, 2024, 10000.0, "kali", 1 },
                    { 212, 2024, 10000.0, "kali", 1 },
                    { 213, 2024, 10000.0, "kali", 1 },
                    { 214, 2024, 10000.0, "kali", 1 },
                    { 215, 2024, 10000.0, "kali", 1 },
                    { 216, 2024, 10000.0, "kali", 1 },
                    { 217, 2024, 10000.0, "kali", 1 },
                    { 218, 2024, 10000.0, "kali", 1 },
                    { 219, 2024, 10000.0, "kali", 1 },
                    { 220, 2024, 10000.0, "kali", 1 },
                    { 221, 2024, 10000.0, "kali", 1 },
                    { 222, 2024, 10000.0, "kali", 1 },
                    { 223, 2024, 10000.0, "kali", 1 },
                    { 224, 2024, 10000.0, "kali", 1 },
                    { 225, 2024, 10000.0, "kali", 1 },
                    { 226, 2024, 10000.0, "kali", 1 },
                    { 227, 2024, 10000.0, "kali", 1 },
                    { 228, 2024, 10000.0, "kali", 1 },
                    { 229, 2024, 10000.0, "kali", 1 },
                    { 230, 2024, 10000.0, "kali", 1 },
                    { 231, 2024, 10000.0, "kali", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblAkun_GolonganAkunId",
                table: "TblAkun",
                column: "GolonganAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblAkun_JenisAkunId",
                table: "TblAkun",
                column: "JenisAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblAkun_KelompokAkunId",
                table: "TblAkun",
                column: "KelompokAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblDetailRAPBJ_KodeAkun",
                table: "TblDetailRAPBJ",
                column: "KodeAkun");

            migrationBuilder.CreateIndex(
                name: "IX_TblGolonganAkun_KelompokAkunId",
                table: "TblGolonganAkun",
                column: "KelompokAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblKelompokAkun_JenisAkunId",
                table: "TblKelompokAkun",
                column: "JenisAkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTransaksi_AkunId",
                table: "TblTransaksi",
                column: "AkunId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTransaksi_KasId",
                table: "TblTransaksi",
                column: "KasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblUser_UserName",
                table: "TblUser",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblDetailRAPBJ");

            migrationBuilder.DropTable(
                name: "TblTransaksi");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblRAPBJ");

            migrationBuilder.DropTable(
                name: "TblAkun");

            migrationBuilder.DropTable(
                name: "TblKas");

            migrationBuilder.DropTable(
                name: "TblGolonganAkun");

            migrationBuilder.DropTable(
                name: "TblKelompokAkun");

            migrationBuilder.DropTable(
                name: "TblJenisAkun");
        }
    }
}
