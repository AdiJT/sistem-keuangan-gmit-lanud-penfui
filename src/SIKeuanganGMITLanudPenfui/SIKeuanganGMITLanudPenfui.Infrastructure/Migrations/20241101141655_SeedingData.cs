using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tahun",
                table: "TblRAPBJ",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.InsertData(
                table: "TblJenisAkun",
                columns: new[] { "Id", "Jenis", "Uraian" },
                values: new object[,]
                {
                    { 1, 0, "Sisa lebih perhitungan tahun (Surplus)" },
                    { 2, 0, "Kolekte/Persembahan" },
                    { 3, 0, "Kolekte Ibadah Syukur" },
                    { 4, 0, "Nazar" },
                    { 5, 0, "Persepuluhan dan Syukur" },
                    { 6, 0, "Pembangunan" },
                    { 7, 0, "Penerimaan Lain-Lain" },
                    { 8, 1, "Belanja Rutin" },
                    { 9, 1, "Belanja Program Pelayanan" },
                    { 10, 1, "Belanja Lain-Lain" }
                });

            migrationBuilder.InsertData(
                table: "TblRAPBJ",
                column: "Tahun",
                value: 2024);

            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "PresentaseSetoran", "Uraian" },
                values: new object[,]
                {
                    { 1, null, 1, null, null, "Rutin" },
                    { 2, null, 1, null, null, "Pembangunan" },
                    { 3, null, 1, null, null, "Dana Cadangan" },
                    { 4, null, 2, null, null, "Kolekte Kebaktian Utama Minggu (2 kali/minggu)" },
                    { 5, null, 3, null, null, "Kolekte Ibadah Syukur Kelulusan" },
                    { 6, null, 3, null, null, "Kolekte Ibadah Syukur NATAL Rayon" },
                    { 7, null, 3, null, null, "Kolekte Ibadah Syukur NATAL Keluarga" },
                    { 8, null, 3, null, null, "Kolekte Ibadah Syukur NATAL Kategorial Lainnya" },
                    { 9, null, 3, null, null, "Kolekte Ibadah Syukur Pernikahan" },
                    { 10, null, 3, null, null, "Kolekte Ibadah Syukur Lepas Kabung" },
                    { 11, null, 3, null, null, "Kolekte Ibadah Syukur Kelahiran" },
                    { 12, null, 3, null, null, "Kolekte Ibadah HUT Perempuan GMIT JLET Penfui" },
                    { 13, null, 3, null, null, "Kolekte Ibadah HUT GMIT JLET Penfui" },
                    { 14, null, 3, null, null, "Kolekte Ibadah Syukur Lainnya" },
                    { 15, null, 4, null, null, "Nazar Kebaktian Minggu" },
                    { 16, null, 4, null, null, "Nazar Baptisan Kudus" },
                    { 17, null, 4, null, null, "Nazar Peneguhan Sidi Baru" },
                    { 18, null, 4, null, null, "Nazar Pemberkatan Nikah" },
                    { 19, null, 4, null, null, "Nazar Khusus" },
                    { 20, null, 5, null, null, "Persepuluhan Kebaktian Minggu" },
                    { 21, null, 5, null, null, "Persepuluhan Lainnya" },
                    { 22, null, 5, null, null, "Nazar, Persepuluhan dan Syukur Lainnya" },
                    { 23, null, 5, null, null, "Syukur Kebaktian Minggu" },
                    { 24, null, 6, null, null, "10% Tangguk Kolekte Pembangunan" },
                    { 25, null, 6, null, null, "Tangguk Persembahan di Kebaktian Utama Minggu" },
                    { 26, null, 6, null, null, "Sumbangan Spontanitas Jemaat" },
                    { 27, null, 6, null, null, "Hasil Usaha Panitia/Tim Kerja" },
                    { 28, null, 6, null, null, "Sumbangan Pembangunan Wajib KK (200KK x 12 bln)" },
                    { 29, null, 6, null, null, "Tunggakan Sumbangan" },
                    { 30, null, 6, null, null, "Hasil Lelang Natura" },
                    { 31, null, 6, null, null, "Sumbangan Pembangunan Pihak Lain" },
                    { 32, null, 10, null, null, "Dana Cadangan" },
                    { 33, null, 10, null, null, "Administrasi Bank" },
                    { 34, null, 10, null, null, "Pajak Bunga Bank" },
                    { 35, null, 10, null, null, "Biaya cetak rekening giro" },
                    { 36, null, 10, null, null, "Pajak Mobil Pelayanan" },
                    { 37, null, 10, null, null, "Belanja Pisah/Sambut Pendeta" },
                    { 38, null, 10, null, null, "Sumbangan Rutin Teritori II K3T" },
                    { 39, null, 10, null, null, "Kontribusi Kegiatan" },
                    { 40, null, 10, null, null, "Sumbangan Lainnya" },
                    { 41, null, 10, null, null, "Belanja Lainnya" }
                });

            migrationBuilder.InsertData(
                table: "TblKelompokAkun",
                columns: new[] { "Id", "JenisAkunId", "Uraian" },
                values: new object[,]
                {
                    { 1, 2, "Kolekte Kebaktian Hari Raya Gerejawi" },
                    { 2, 2, "Kolekte Kebaktian Sakramen Perjamuan Kudus" },
                    { 3, 2, "Kolekte Kebaktian Baptisan Kudus" },
                    { 4, 2, "Kolekte Kebaktian Peneguhan Sidi Baru" },
                    { 5, 2, "Kolekte Kebaktian Peneguhan Sidi Baru" },
                    { 6, 2, "Kolekte Ibadah Rumah Tangga" },
                    { 7, 2, "Kolekte Ibadah Kategorial/Fungsional, dll" },
                    { 8, 8, "Pos Penghasilan Pendeta dan MJH" },
                    { 9, 8, "Belanja BPPPJ" },
                    { 10, 8, "Belanja Karyawan" },
                    { 11, 8, "Tunjangan Khusus Karyawan/Presbiter" },
                    { 12, 8, "Belanja Kantor" },
                    { 13, 8, "Belanja Pengadaan & Pemeliharaan" },
                    { 14, 8, "Belanja Perjalanan" },
                    { 15, 8, "Belanja Tanggungan Rutin Jemaat" },
                    { 16, 9, "Bidang Koinonia" },
                    { 17, 9, "Bidang Marturia" },
                    { 18, 9, "Bidang Liturgia" },
                    { 19, 9, "Bidang Diakonia" },
                    { 20, 9, "Bidang Oikonomia" },
                    { 21, 9, "Bidang Umum dan Rekomendasi" }
                });

            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "PresentaseSetoran", "Uraian" },
                values: new object[,]
                {
                    { 42, null, 2, 1, null, "Kebaktian Hari Reformasi & HUT GMIT" },
                    { 43, null, 2, 1, null, "Kebaktian Malam NATAL" },
                    { 44, null, 2, 1, null, "Kebaktian Malam NATAL (Keluarga)" },
                    { 45, null, 2, 1, null, "Kebaktian NATAL" },
                    { 46, null, 2, 1, null, "Kebaktian Syukur NATAL" },
                    { 47, null, 2, 1, null, "Kebaktian NATAL JLET" },
                    { 48, null, 2, 1, null, "Kebaktian NATAL PAR" },
                    { 49, null, 2, 1, null, "Kebaktian Kunci Tahun" },
                    { 50, null, 2, 1, null, "Kebaktian Kunci Tahun (Keluarga)" },
                    { 51, null, 2, 1, null, "Kebaktian Tahun Baru " },
                    { 52, null, 2, 1, null, "Kebaktian Jumat Agung" },
                    { 53, null, 2, 1, null, "Kebaktian Paskah" },
                    { 54, null, 2, 1, null, "Kebaktian Syukur Paskah" },
                    { 55, null, 2, 2, null, "Kebaktian Persiapan Perjamuan Kudus" },
                    { 56, null, 2, 2, null, "Kebaktian Sakramen Perjamuan Kudus" },
                    { 57, null, 2, 3, null, "Kebaktian Persiapan Baptisan Kudus" },
                    { 58, null, 2, 3, null, "Kebaktian Sakramen Baptisan Kudus" },
                    { 59, null, 2, 4, null, "Kebaktian Persiapan Peneguhan Sidi Baru" },
                    { 60, null, 2, 4, null, "Kebaktian Peneguhan Anggota Sidi Baru" },
                    { 61, null, 2, 5, null, "Pastoral" },
                    { 62, null, 2, 5, null, "Kebaktian Persiapan/Penggembalaan" },
                    { 63, null, 2, 5, null, "Kebaktian Pemberkatan Nikah" },
                    { 64, null, 2, 6, null, "Rayon 1" },
                    { 65, null, 2, 6, null, "Rayon 2" },
                    { 66, null, 2, 6, null, "Rayon 3" },
                    { 67, null, 2, 6, null, "Rayon 4" },
                    { 68, null, 2, 6, null, "Rayon 5" },
                    { 69, null, 2, 6, null, "Rayon 6" },
                    { 70, null, 2, 6, null, "Rayon 7" },
                    { 71, null, 2, 7, null, "Kolekte Ibadah PAR" },
                    { 72, null, 2, 7, null, "Kolekte Ibadah Pemuda" },
                    { 73, null, 2, 7, null, "Kolekte Ibadah Kaum Perempuan" },
                    { 74, null, 2, 7, null, "Kolekte Ibadah Kaum Bapak" },
                    { 75, null, 2, 7, null, "Kolekte Ibadah Lansia" },
                    { 76, null, 2, 7, null, "Kolekte Ibadah Kunci Usbuh" },
                    { 77, null, 2, 7, null, "Kolekte Ibadah Katekasasi Reguler" },
                    { 78, null, 2, 7, null, "Kolekte Ibadah Katekasasi Pra Nikah" },
                    { 79, null, 2, 7, null, "Kolekte Ibadah Persekutuan Doa" },
                    { 80, null, 2, 7, null, "Kolekte Ibadah PS/VG" },
                    { 81, null, 2, 7, null, "Kolekte Ibadah Lainnya" },
                    { 82, null, 8, 9, null, "Uang Harian" },
                    { 83, null, 8, 9, null, "Konsumsi Rapat" },
                    { 84, null, 8, 9, null, "Pembuatan LHPP" },
                    { 85, null, 8, 10, null, "Gaji Koster" },
                    { 86, null, 8, 10, null, "Gaji Tata Usaha (TU) Gereja" },
                    { 87, null, 8, 10, null, "Gaji Sopir" },
                    { 88, null, 8, 10, null, "Insentif Calon Vicaris (CAVIK)" },
                    { 89, null, 8, 10, null, "Insentif Song Leader/Prokantor (2 orang)" },
                    { 90, null, 8, 10, null, "Insentif Organis/Sound System (2 orang)" },
                    { 91, null, 8, 10, null, "Insentif Operator LCD" },
                    { 92, null, 8, 10, null, "Jasa sopir tidak tetap" },
                    { 93, null, 8, 11, null, "Tunjangan Khusus Koster" },
                    { 94, null, 8, 11, null, "Tunjangan Khusus TU Gereja" },
                    { 95, null, 8, 11, null, "Tunjangan Khusus Sopir" },
                    { 96, null, 8, 11, null, "Tunjangan Khusus Calon Vicaris (CAVIK)" },
                    { 97, null, 8, 11, null, "Tunjangan Khusus Organis/Sound Systim" },
                    { 98, null, 8, 11, null, "Tunjangan Khusus Operator LCD" },
                    { 99, null, 8, 11, null, "Tunjangan Khusus Presbiter" },
                    { 100, null, 8, 12, null, "Alat Tulis Kantor (ATK) dan Bahan Habis Pakai Lainnya " },
                    { 101, null, 8, 12, null, "Biaya Penggandaan dan Cetak" },
                    { 102, null, 8, 12, null, "ATK, Biaya Penggandaan dan Cetak kegiatan sidang program tahun pelayanan 2025" },
                    { 103, null, 8, 12, null, "Biaya Listrik (Gereja dan Pastori)" },
                    { 104, null, 8, 12, null, "Air" },
                    { 105, null, 8, 12, null, "Telepon/Indihome/Wifi" },
                    { 106, null, 8, 12, null, "Alat & Bahan Kebersihan/Kesehatan" },
                    { 107, null, 8, 13, null, "Pengadaan Barang Inventaris (Keyboard)" },
                    { 108, null, 8, 13, null, "Pemeliharaan Barang Inventaris" },
                    { 109, null, 8, 13, null, "Pemeliharaan Gedung (Gereja, Pastori, dll)" },
                    { 110, null, 8, 13, null, "Pemeliharaan Mobil Pelayanan" },
                    { 111, null, 8, 13, null, "Pemeliharaan Instalasi Air dan Instalasi Listrik" },
                    { 112, null, 8, 13, null, "Bahan Bakar" },
                    { 113, null, 8, 13, null, "Pengadaan Buku Pedoman Organisasi & Buku Lainnya" },
                    { 114, null, 8, 13, null, "Pengadaan Surat Gerejawi" },
                    { 115, null, 8, 13, null, "Pengadaan poni gorden jendela gereja warna hijau" },
                    { 116, null, 8, 13, null, "Pengadaan meja" },
                    { 117, null, 8, 13, null, "Pengadaan CCTV" },
                    { 118, null, 8, 13, null, "Pengadaan gitar akustik" },
                    { 119, null, 8, 13, null, "Pengadaan Alat Musik (Kajon)" },
                    { 120, null, 8, 14, null, "Transport Pendeta & (MJH) mengikuti Rapat/Sidang" },
                    { 121, null, 8, 14, null, "Transport Pendeta Tamu" },
                    { 122, null, 8, 14, null, "Transport MKH/MSH atas undangan jemaat" },
                    { 123, null, 8, 14, null, "Transport Presbiter/BP/UPP, dll" },
                    { 124, null, 8, 14, null, "Transport MJH ke kantor Klasis/Sinode" },
                    { 125, null, 8, 14, null, "Transport Bendahara/TU ke Bank" },
                    { 126, null, 8, 14, null, "Transport Pemateri" },
                    { 127, null, 8, 14, null, "Transport Lainnya" },
                    { 128, null, 8, 15, null, "Setoran Sentralisasi Gaji Pokok (SGP)" },
                    { 129, null, 8, 15, null, "Setoran 10% Penerimaan (Dana Rutin)" },
                    { 130, null, 8, 15, null, "Setoran 10% Dana Pembangunan" },
                    { 131, null, 8, 15, null, "Setoran 2% Dana Pendidikan" },
                    { 132, null, 8, 15, null, "Setoran Dana Kebersamaan" },
                    { 133, null, 9, 16, null, "Perayaan Hari Ibu dan Natal" },
                    { 134, null, 9, 16, null, "Ibadah Gabungan LANSIA Teritori 2" },
                    { 135, null, 9, 16, null, "Ibadah Gabungan Persekutuan Doa Teritori 2" },
                    { 136, null, 9, 16, null, "Ibadah Kreatif Persekutuan Doa" },
                    { 137, null, 9, 16, null, "Ibadah Syukur Natal Pemuda Teritori 2" },
                    { 138, null, 9, 16, null, "Ibadah Gabungan Kaum Perempuan Teritori 2" },
                    { 139, null, 9, 16, null, "Ibadah Pemuda Teritori-dalam klasis-luar klasis" },
                    { 140, null, 9, 16, null, "Ibadah NATAL PART" },
                    { 141, null, 9, 16, null, "Ibadah PASUTRI JLET" },
                    { 142, null, 9, 16, null, "Ibadah Padang memperingati HUT Reformasi dan GMIT" },
                    { 143, null, 9, 16, null, "Ibadah syukur HUT JLET" },
                    { 144, null, 9, 16, null, "Ibadah syukur Natal JLET" },
                    { 145, null, 9, 16, null, "Ibadah Kreatif BP, UPP dan BP JLET" },
                    { 146, null, 9, 16, null, "Ibadah Kreatif Pemuda 3" },
                    { 147, null, 9, 16, null, "Ibadah Kreatif Pemuda 4" },
                    { 148, null, 9, 16, null, "Ibadah ke Rote (UPP Perempuan)" },
                    { 149, null, 9, 17, null, "Bakti Sosial PART" },
                    { 150, null, 9, 17, null, "Lomba PASKAH PART" },
                    { 151, null, 9, 17, null, "Lomba HUT RI PART" },
                    { 152, null, 9, 17, null, "Perayaan NATAL PART" },
                    { 153, null, 9, 17, null, "Pelatihan Kepemimpinan Pemuda" },
                    { 154, null, 9, 17, null, "Lomba Kreasi Salib memperingati PASKAH 2024" },
                    { 155, null, 9, 17, null, "Malam puji-pujian menyambut PASKAH" },
                    { 156, null, 9, 17, null, "Pawai PASKAH JLET" },
                    { 157, null, 9, 17, null, "Lomba voly Putra-Putri antar Rayon memperingati Bulan keluarga" },
                    { 158, null, 9, 17, null, "Lomba memasak nasi goreng antar keluarga dari tiap rayon memperingati Bulan Keluarga" },
                    { 159, null, 9, 17, null, "Lomba VG Kaum Bapak Memperingati HUT JLET" },
                    { 160, null, 9, 17, null, "Lomba CCA Keluarga antar Rayon" },
                    { 161, null, 9, 17, null, "Lomba Pohon Natal antar rayon di lingkungan gereja" },
                    { 162, null, 9, 17, null, "Insentif Pengajar Katekasasi (2 orang)" },
                    { 163, null, 9, 17, null, "Insentif Pengajar UPP PAR" },
                    { 164, null, 9, 17, null, "Memberikan Apresiasi kepada anak-anak (Sertifikat Naik Kelas, dll)" },
                    { 165, null, 9, 18, null, "Pengadaan Bahan Perjamuan Kudus" },
                    { 166, null, 9, 18, null, "Perbaikan peti keyboard" },
                    { 167, null, 9, 18, null, "Pengadaan meja operator slide" },
                    { 168, null, 9, 18, null, "Insentif songlider, musik dan operator slide " },
                    { 169, null, 9, 18, null, "Insentif Soundman" },
                    { 170, null, 9, 19, null, "Diakonia Sakit" },
                    { 171, null, 9, 19, null, "Diakonia Duka Cita" },
                    { 172, null, 9, 19, null, "Diakonia bagi jemaat JLET yang tidak mampu" },
                    { 173, null, 9, 19, null, "Pemeriksaan Kesehatan bagi LANSIA" },
                    { 174, null, 9, 19, null, "Bingkisan Kasih Majelis Jemaat" },
                    { 175, null, 9, 19, null, "Pelatihan peningkatan kapasitas diaken dalam pelayanan diakonia holistik" },
                    { 176, null, 9, 19, null, "Pelatihan Ketrampilan (Vokasi) Bagi Jemaat (PEMUDA)" },
                    { 177, null, 9, 19, null, "Beasiswa pendidikan kepada anak berprestasi  yang kurang mampu." },
                    { 178, null, 9, 19, null, "Pemberian bantuan dana pendidikan untuk calon mahasiswa musik gerejawi" },
                    { 179, null, 9, 19, null, "Bantuan bagi warga JLET yang mengalami bencana alam dan Non Alam" },
                    { 180, null, 9, 19, null, "Diakonia Lain-Lain" },
                    { 181, null, 9, 20, null, "Pemanfaatan pekarangan gereja (dapur hidup, apotik hidup)" },
                    { 182, null, 9, 20, null, "Pelatihan musik Kaum Bapak (transportasi pelatih)" },
                    { 183, null, 9, 21, null, "Pengurusan Sertifikat Tanah (Balik Nama)" },
                    { 184, null, 9, 21, null, "Pemasangan Identitas Mobil Pelayanan JLET" }
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
                    { 41, 2024, 10000.0, "kali", 1 }
                });

            migrationBuilder.InsertData(
                table: "TblGolonganAkun",
                columns: new[] { "Id", "KelompokAkunId", "Uraian" },
                values: new object[,]
                {
                    { 1, 8, "Tunjangan Ketua Majelis Jemaat (KMJ)" },
                    { 2, 8, "Insentif MJH" },
                    { 3, 8, "Tunjangan Khusus MJH" },
                    { 4, 8, "Gaji Ke-13" },
                    { 5, 12, "Biaya Konsumsi" },
                    { 6, 14, "Biaya Perjalanan Dinas Pendeta" },
                    { 7, 20, "Renovasi Gedung Ibadah" },
                    { 8, 20, "Renovasi Gedung Pusat Kegiatan PART, Pemuda dan Serba Guna" },
                    { 9, 20, "Renovasi Rumah Pastori" },
                    { 10, 20, "Renovasi Pertamanan" }
                });

            migrationBuilder.InsertData(
                table: "TblPenerimaan",
                columns: new[] { "Id", "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 2, 21, 30000.0, 7141000.0, new DateOnly(2024, 1, 1), "Terima perpuluhan tidak tetap Tanpa Nama 1" });

            migrationBuilder.InsertData(
                table: "TblAkun",
                columns: new[] { "Id", "GolonganAkunId", "JenisAkunId", "KelompokAkunId", "PresentaseSetoran", "Uraian" },
                values: new object[,]
                {
                    { 185, 1, 8, null, null, "Tunjangan Struktural" },
                    { 186, 1, 8, null, null, "Tunjangan Kesejahteraan (Kesra)" },
                    { 187, 1, 8, null, null, "Tunjangan Kesehatan" },
                    { 188, 1, 8, null, null, "Tunjangan Lainnya" },
                    { 189, 2, 8, null, null, "Wakil Ketua" },
                    { 190, 2, 8, null, null, "Sekretaris" },
                    { 191, 2, 8, null, null, "Wakil Sekretaris" },
                    { 192, 2, 8, null, null, "Bendahara" },
                    { 193, 2, 8, null, null, "Wakil Bendahara" },
                    { 194, 3, 8, null, null, "Gaji Ke-13 KMJ" },
                    { 195, 4, 8, null, null, "Ketua Majelis Jemaat (KMJ)" },
                    { 196, 4, 8, null, null, "Wakil Ketua" },
                    { 197, 4, 8, null, null, "Sekretaris" },
                    { 198, 4, 8, null, null, "Wakil Sekretaris" },
                    { 199, 4, 8, null, null, "Bendahara" },
                    { 200, 4, 8, null, null, "Wakil Bendahara" },
                    { 201, 5, 8, null, null, "Konsumsi Pertemuan/Rapat Pendeta" },
                    { 202, 5, 8, null, null, "Konsumsi Pendeta Tamu dan Tamu Pendeta" },
                    { 203, 5, 8, null, null, "Konsumsi Lembur MJH" },
                    { 204, 5, 8, null, null, "Konsumsi UPP/BP/Tim Kerja, dll" },
                    { 205, 5, 8, null, null, "Rapat evaluasi program dan kegiatan lainnya" },
                    { 206, 5, 8, null, null, "Sidang Program Tahun Pelayanan 2025" },
                    { 207, 5, 8, null, null, "Konsumsi Lainnya" },
                    { 209, 6, 8, null, null, "Lumpsum Luar Daerah" },
                    { 210, 6, 8, null, null, "Penginapan" },
                    { 211, 6, 8, null, null, "Transportasi (luar daerah)" },
                    { 212, 6, 8, null, null, "Transportasi (dalam daerah)" },
                    { 213, 6, 8, null, null, "Lumpsum dalam Daerah" },
                    { 214, 6, 8, null, null, "Rekoleksi (Kupang - Siangapore PP)" },
                    { 215, 7, 9, null, null, "Pembangunan" },
                    { 216, 7, 9, null, null, "Pasang Ganti Penutup Atap" },
                    { 217, 7, 9, null, null, "Pasang Ganti Kuda - kuda" },
                    { 218, 7, 9, null, null, "Pasang Ganti Plafond" },
                    { 219, 8, 9, null, null, "Finishing Dinding" },
                    { 220, 8, 9, null, null, "Finishing Lantai" },
                    { 221, 8, 9, null, null, "Finishing Atap" },
                    { 222, 8, 9, null, null, "Pasang Baru Plafond" },
                    { 223, 8, 9, null, null, "Pasang Baru Penerangan dan Kelistrikan" },
                    { 224, 8, 9, null, null, "Pasang Baru Toilet dan Kelengkapan" },
                    { 225, 9, 9, null, null, "Perbaikan Atap" },
                    { 226, 9, 9, null, null, "Perbaikan Listrik" },
                    { 227, 10, 9, null, null, "Pasang Baru Penutup Gerbang" },
                    { 228, 10, 9, null, null, "Pasang Baru Railing Tangga Talud" },
                    { 229, 10, 9, null, null, "Pasang Baru Kanopi Parkiran" },
                    { 230, 10, 9, null, null, "Pasang Baru Pos Jaga" },
                    { 231, 10, 9, null, null, "Normalisasi Area Parkir" }
                });

            migrationBuilder.InsertData(
                table: "TblBelanja",
                columns: new[] { "Id", "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[,]
                {
                    { 1, 171, 500000.0, 9713500.0, new DateOnly(2024, 1, 1), "Diakonia Duka Alm. An. Ezra Sioh Rayon 7" },
                    { 2, 141, 150000.0, 9563500.0, new DateOnly(2024, 1, 2), "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-" }
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
                table: "TblPenerimaan",
                columns: new[] { "Id", "AkunId", "Jumlah", "SaldoKas", "Tanggal", "Uraian" },
                values: new object[] { 1, 51, 930000.0, 6961500.0, new DateOnly(2024, 1, 1), "Kolekte" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblBelanja",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 1, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 2, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 3, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 4, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 5, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 6, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 7, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 8, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 9, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 10, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 11, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 12, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 13, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 14, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 15, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 16, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 17, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 18, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 19, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 20, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 21, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 22, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 23, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 24, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 25, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 26, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 27, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 28, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 29, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 30, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 31, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 32, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 33, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 34, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 35, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 36, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 37, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 38, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 39, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 40, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 41, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 42, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 43, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 44, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 45, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 46, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 47, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 48, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 49, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 50, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 51, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 52, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 53, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 54, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 55, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 56, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 57, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 58, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 59, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 60, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 61, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 62, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 63, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 64, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 65, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 66, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 67, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 68, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 69, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 70, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 71, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 72, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 73, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 74, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 75, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 76, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 77, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 78, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 79, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 80, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 81, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 82, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 83, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 84, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 85, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 86, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 87, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 88, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 89, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 90, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 91, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 92, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 93, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 94, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 95, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 96, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 97, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 98, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 99, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 100, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 101, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 102, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 103, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 104, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 105, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 106, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 107, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 108, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 109, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 110, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 111, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 112, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 113, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 114, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 115, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 116, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 117, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 118, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 119, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 120, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 121, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 122, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 123, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 124, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 125, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 126, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 127, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 128, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 129, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 130, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 131, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 132, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 133, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 134, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 135, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 136, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 137, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 138, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 139, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 140, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 141, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 142, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 143, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 144, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 145, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 146, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 147, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 148, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 149, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 150, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 151, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 152, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 153, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 154, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 155, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 156, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 157, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 158, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 159, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 160, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 161, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 162, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 163, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 164, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 165, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 166, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 167, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 168, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 169, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 170, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 171, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 172, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 173, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 174, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 175, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 176, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 177, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 178, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 179, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 180, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 181, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 182, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 183, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 184, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 185, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 186, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 187, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 188, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 189, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 190, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 191, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 192, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 193, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 194, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 195, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 196, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 197, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 198, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 199, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 200, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 201, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 202, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 203, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 204, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 205, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 206, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 207, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 209, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 210, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 211, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 212, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 213, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 214, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 215, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 216, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 217, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 218, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 219, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 220, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 221, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 222, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 223, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 224, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 225, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 226, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 227, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 228, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 229, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 230, 2024 });

            migrationBuilder.DeleteData(
                table: "TblDetailRAPBJ",
                keyColumns: new[] { "KodeAkun", "TahunRAPBJ" },
                keyValues: new object[] { 231, 2024 });

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblPenerimaan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TblAkun",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TblRAPBJ",
                keyColumn: "Tahun",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblGolonganAkun",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblKelompokAkun",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblJenisAkun",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<int>(
                name: "Tahun",
                table: "TblRAPBJ",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
