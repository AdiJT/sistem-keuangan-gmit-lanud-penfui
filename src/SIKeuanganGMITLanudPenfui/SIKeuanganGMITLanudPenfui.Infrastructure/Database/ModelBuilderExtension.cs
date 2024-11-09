using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database;

internal static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        var tahun = Tahun.Create(2024).Value;

        #region JenisAkun
        var daftarJenisAkun = new JenisAkun[]
        {
            new()
            {
                Id = 1,
                Uraian = "Sisa lebih perhitungan tahun (Surplus)",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 2,
                Uraian = "Kolekte/Persembahan",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 3,
                Uraian = "Kolekte Ibadah Syukur",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 4,
                Uraian = "Nazar",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 5,
                Uraian = "Persepuluhan dan Syukur",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 6,
                Uraian = "Pembangunan",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 7,
                Uraian = "Penerimaan Lain-Lain",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun
            },
            new()
            {
                Id = 8,
                Uraian = "Belanja Rutin",
                Jenis = Jenis.Belanja,
                Tahun = tahun
            },
            new()
            {
                Id = 9,
                Uraian = "Belanja Program Pelayanan",
                Jenis = Jenis.Belanja,
                Tahun = tahun
            },
            new()
            {
                Id = 10,
                Uraian = "Belanja Lain-Lain",
                Jenis = Jenis.Belanja,
                Tahun = tahun
            }
        };

        modelBuilder.Entity<JenisAkun>().HasData(daftarJenisAkun);
        #endregion

        #region KelompokAkun
        var daftarKelompokAkun = new[]
        {
            new
            {
                Id = 1,
                Uraian = "Kolekte Kebaktian Hari Raya Gerejawi",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 2,
                Uraian = "Kolekte Kebaktian Sakramen Perjamuan Kudus",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 3,
                Uraian = "Kolekte Kebaktian Baptisan Kudus",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 4,
                Uraian = "Kolekte Kebaktian Peneguhan Sidi Baru",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 5,
                Uraian = "Kolekte Kebaktian Peneguhan Sidi Baru",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 6,
                Uraian = "Kolekte Ibadah Rumah Tangga",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 7,
                Uraian = "Kolekte Ibadah Kategorial/Fungsional, dll",
                JenisAkunId = 2,
                Tahun = tahun
            },
            new
            {
                Id = 8,
                Uraian = "Pos Penghasilan Pendeta dan MJH",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 9,
                Uraian = "Belanja BPPPJ",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 10,
                Uraian = "Belanja Karyawan",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 11,
                Uraian = "Tunjangan Khusus Karyawan/Presbiter",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 12,
                Uraian = "Belanja Kantor",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 13,
                Uraian = "Belanja Pengadaan & Pemeliharaan",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 14,
                Uraian = "Belanja Perjalanan",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 15,
                Uraian = "Belanja Tanggungan Rutin Jemaat",
                JenisAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 16,
                Uraian = "Bidang Koinonia",
                JenisAkunId = 9,
                Tahun = tahun
            },
            new
            {
                Id = 17,
                Uraian = "Bidang Marturia",
                JenisAkunId = 9,
                Tahun = tahun
            },
            new
            {
                Id = 18,
                Uraian = "Bidang Liturgia",
                JenisAkunId = 9,
                Tahun = tahun
            },
            new
            {
                Id = 19,
                Uraian = "Bidang Diakonia",
                JenisAkunId = 9,
                Tahun = tahun
            },
            new
            {
                Id = 20,
                Uraian = "Bidang Oikonomia",
                JenisAkunId = 9,
                Tahun = tahun
            },
            new
            {
                Id = 21,
                Uraian = "Bidang Umum dan Rekomendasi",
                JenisAkunId = 9,
                Tahun = tahun
            },
        };
        modelBuilder.Entity<KelompokAkun>().HasData(daftarKelompokAkun);
        #endregion

        #region GolonganAkun
        var daftarGolonganAkun = new[]
        {
            new
            {
                Id = 1,
                Uraian = "Tunjangan Ketua Majelis Jemaat (KMJ)",
                KelompokAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 2,
                Uraian = "Insentif MJH",
                KelompokAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 3,
                Uraian = "Tunjangan Khusus MJH",
                KelompokAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 4,
                Uraian = "Gaji Ke-13",
                KelompokAkunId = 8,
                Tahun = tahun
            },
            new
            {
                Id = 5,
                Uraian = "Biaya Konsumsi",
                KelompokAkunId = 12,
                Tahun = tahun
            },
            new
            {
                Id = 6,
                Uraian = "Biaya Perjalanan Dinas Pendeta",
                KelompokAkunId = 14,
                Tahun = tahun
            },
            new
            {
                Id = 7,
                Uraian = "Renovasi Gedung Ibadah",
                KelompokAkunId = 20,
                Tahun = tahun
            },
            new
            {
                Id = 8,
                Uraian = "Renovasi Gedung Pusat Kegiatan PART, Pemuda dan Serba Guna",
                KelompokAkunId = 20,
                Tahun = tahun
            },
            new
            {
                Id = 9,
                Uraian = "Renovasi Rumah Pastori",
                KelompokAkunId = 20,
                Tahun = tahun
            },
            new
            {
                Id = 10,
                Uraian = "Renovasi Pertamanan",
                KelompokAkunId = 20,
                Tahun = tahun
            },
        };
        modelBuilder.Entity<GolonganAkun>().HasData(daftarGolonganAkun);
        #endregion

        #region Akun
        var daftarAkunDenganJenisAkun = new[]
        {
            new
            {
                Id = 1,
                Uraian = "Rutin",
                JenisAkunId = 1
            },
            new
            {
                Id = 2,
                Uraian = "Pembangunan",
                JenisAkunId = 1
            },
            new
            {
                Id = 3,
                Uraian = "Dana Cadangan",
                JenisAkunId = 1
            },
            new
            {
                Id = 4,
                Uraian = "Kolekte Kebaktian Utama Minggu (2 kali/minggu)",
                JenisAkunId = 2
            },
            new
            {
                Id = 5,
                Uraian = "Kolekte Ibadah Syukur Kelulusan",
                JenisAkunId = 3
            },
            new
            {
                Id = 6,
                Uraian = "Kolekte Ibadah Syukur NATAL Rayon",
                JenisAkunId = 3
            },
            new
            {
                Id = 7,
                Uraian = "Kolekte Ibadah Syukur NATAL Keluarga",
                JenisAkunId = 3
            },
            new
            {
                Id = 8,
                Uraian = "Kolekte Ibadah Syukur NATAL Kategorial Lainnya",
                JenisAkunId = 3
            },
            new
            {
                Id = 9,
                Uraian = "Kolekte Ibadah Syukur Pernikahan",
                JenisAkunId = 3
            },
            new
            {
                Id = 10,
                Uraian = "Kolekte Ibadah Syukur Lepas Kabung",
                JenisAkunId = 3
            },
            new
            {
                Id = 11,
                Uraian = "Kolekte Ibadah Syukur Kelahiran",
                JenisAkunId = 3
            },
            new
            {
                Id = 12,
                Uraian = "Kolekte Ibadah HUT Perempuan GMIT JLET Penfui",
                JenisAkunId = 3
            },
            new
            {
                Id = 13,
                Uraian = "Kolekte Ibadah HUT GMIT JLET Penfui",
                JenisAkunId = 3
            },
            new
            {
                Id = 14,
                Uraian = "Kolekte Ibadah Syukur Lainnya",
                JenisAkunId = 3
            },
            new
            {
                Id = 15,
                Uraian  = "Nazar Kebaktian Minggu",
                JenisAkunId = 4,
            },
            new
            {
                Id = 16,
                Uraian  = "Nazar Baptisan Kudus",
                JenisAkunId = 4,
            },
            new
            {
                Id = 17,
                Uraian  = "Nazar Peneguhan Sidi Baru",
                JenisAkunId = 4,
            },
            new
            {
                Id = 18,
                Uraian  = "Nazar Pemberkatan Nikah",
                JenisAkunId = 4,
            },
            new
            {
                Id = 19,
                Uraian  = "Nazar Khusus",
                JenisAkunId = 4,
            },
            new
            {
                Id = 20,
                Uraian = "Persepuluhan Kebaktian Minggu",
                JenisAkunId = 5,
            },
            new
            {
                Id = 21,
                Uraian = "Persepuluhan Lainnya",
                JenisAkunId = 5,
            },
            new
            {
                Id = 22,
                Uraian = "Nazar, Persepuluhan dan Syukur Lainnya",
                JenisAkunId = 5,
            },
            new
            {
                Id = 23,
                Uraian = "Syukur Kebaktian Minggu",
                JenisAkunId = 5,
            },
            new
            {
                Id = 24,
                Uraian = "10% Tangguk Kolekte Pembangunan",
                JenisAkunId = 6,
            },
            new
            {
                Id = 25,
                Uraian = "Tangguk Persembahan di Kebaktian Utama Minggu",
                JenisAkunId = 6,
            },
            new
            {
                Id = 26,
                Uraian = "Sumbangan Spontanitas Jemaat",
                JenisAkunId = 6,
            },
            new
            {
                Id = 27,
                Uraian = "Hasil Usaha Panitia/Tim Kerja",
                JenisAkunId = 6,
            },
            new
            {
                Id = 28,
                Uraian = "Sumbangan Pembangunan Wajib KK (200KK x 12 bln)",
                JenisAkunId = 6,
            },
            new
            {
                Id = 29,
                Uraian = "Tunggakan Sumbangan",
                JenisAkunId = 6,
            },
            new
            {
                Id = 30,
                Uraian = "Hasil Lelang Natura",
                JenisAkunId = 6,
            },
            new
            {
                Id = 31,
                Uraian = "Sumbangan Pembangunan Pihak Lain",
                JenisAkunId = 6,
            },
            new
            {
                Id = 32,
                Uraian = "Dana Cadangan",
                JenisAkunId = 10,
            },
            new
            {
                Id = 33,
                Uraian = "Administrasi Bank",
                JenisAkunId = 10,
            },
            new
            {
                Id = 34,
                Uraian = "Pajak Bunga Bank",
                JenisAkunId = 10,
            },
            new
            {
                Id = 35,
                Uraian = "Biaya cetak rekening giro",
                JenisAkunId = 10,
            },
            new
            {
                Id = 36,
                Uraian = "Pajak Mobil Pelayanan",
                JenisAkunId = 10,
            },
            new
            {
                Id = 37,
                Uraian = "Belanja Pisah/Sambut Pendeta",
                JenisAkunId = 10,
            },
            new
            {
                Id = 38,
                Uraian = "Sumbangan Rutin Teritori II K3T",
                JenisAkunId = 10,
            },
            new
            {
                Id = 39,
                Uraian = "Kontribusi Kegiatan",
                JenisAkunId = 10,
            },
            new
            {
                Id = 40,
                Uraian = "Sumbangan Lainnya",
                JenisAkunId = 10,
            },
            new
            {
                Id = 41,
                Uraian = "Belanja Lainnya",
                JenisAkunId = 10,
            },
            new
            {
                Id = 232,
                Uraian = "Administrasi Baptisan",
                JenisAkunId = 7,
            },
            new
            {
                Id = 233,
                Uraian = "Administrasi Peneguhan Sidi Baru",
                JenisAkunId = 7,
            },
            new
            {
                Id = 234,
                Uraian = "Administrasi Pemberkatan Nikah",
                JenisAkunId = 7,
            },
            new
            {
                Id = 235,
                Uraian = "Bunga Bank",
                JenisAkunId = 7,
            },
            new
            {
                Id = 236,
                Uraian = "Hasil Lelang",
                JenisAkunId = 7,
            },
            new
            {
                Id = 237,
                Uraian = "Penerimaan Lainnya",
                JenisAkunId = 7,
            }
        };

        var daftarAkunDenganKelompokAkun = new[]
        {
            new
            {
                Id = 42,
                Uraian = "Kebaktian Hari Reformasi & HUT GMIT",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 43,
                Uraian = "Kebaktian Malam NATAL",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 44,
                Uraian = "Kebaktian Malam NATAL (Keluarga)",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 45,
                Uraian = "Kebaktian NATAL",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 46,
                Uraian = "Kebaktian Syukur NATAL",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 47,
                Uraian = "Kebaktian NATAL JLET",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 48,
                Uraian = "Kebaktian NATAL PAR",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 49,
                Uraian = "Kebaktian Kunci Tahun",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 50,
                Uraian = "Kebaktian Kunci Tahun (Keluarga)",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 51,
                Uraian = "Kebaktian Tahun Baru ",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 52,
                Uraian = "Kebaktian Jumat Agung",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 53,
                Uraian = "Kebaktian Paskah",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 54,
                Uraian = "Kebaktian Syukur Paskah",
                JenisAkunId = 2,
                KelompokAkunId = 1
            },
            new
            {
                Id = 55,
                Uraian = "Kebaktian Persiapan Perjamuan Kudus",
                JenisAkunId = 2,
                KelompokAkunId = 2
            },
            new
            {
                Id = 56,
                Uraian = "Kebaktian Sakramen Perjamuan Kudus",
                JenisAkunId = 2,
                KelompokAkunId = 2
            },
            new
            {
                Id = 57,
                Uraian = "Kebaktian Persiapan Baptisan Kudus",
                JenisAkunId = 2,
                KelompokAkunId = 3
            },
            new
            {
                Id = 58,
                Uraian = "Kebaktian Sakramen Baptisan Kudus",
                JenisAkunId = 2,
                KelompokAkunId = 3
            },
            new
            {
                Id = 59,
                Uraian = "Kebaktian Persiapan Peneguhan Sidi Baru",
                JenisAkunId = 2,
                KelompokAkunId = 4
            },
            new
            {
                Id = 60,
                Uraian = "Kebaktian Peneguhan Anggota Sidi Baru",
                JenisAkunId = 2,
                KelompokAkunId = 4
            },
            new
            {
                Id = 61,
                Uraian = "Pastoral",
                JenisAkunId = 2,
                KelompokAkunId = 5
            },
            new
            {
                Id = 62,
                Uraian = "Kebaktian Persiapan/Penggembalaan",
                JenisAkunId = 2,
                KelompokAkunId = 5
            },
            new
            {
                Id = 63,
                Uraian = "Kebaktian Pemberkatan Nikah",
                JenisAkunId = 2,
                KelompokAkunId = 5
            },
            new
            {
                Id = 64,
                Uraian = "Rayon 1",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 65,
                Uraian = "Rayon 2",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 66,
                Uraian = "Rayon 3",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 67,
                Uraian = "Rayon 4",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 68,
                Uraian = "Rayon 5",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 69,
                Uraian = "Rayon 6",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 70,
                Uraian = "Rayon 7",
                JenisAkunId = 2,
                KelompokAkunId = 6
            },
            new
            {
                Id = 71,
                Uraian = "Kolekte Ibadah PAR",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 72,
                Uraian = "Kolekte Ibadah Pemuda",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 73,
                Uraian = "Kolekte Ibadah Kaum Perempuan",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 74,
                Uraian = "Kolekte Ibadah Kaum Bapak",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 75,
                Uraian = "Kolekte Ibadah Lansia",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 76,
                Uraian = "Kolekte Ibadah Kunci Usbuh",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 77,
                Uraian = "Kolekte Ibadah Katekasasi Reguler",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 78,
                Uraian = "Kolekte Ibadah Katekasasi Pra Nikah",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 79,
                Uraian = "Kolekte Ibadah Persekutuan Doa",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 80,
                Uraian = "Kolekte Ibadah PS/VG",
                JenisAkunId = 2,
                KelompokAkunId = 7
            },
            new
            {
                Id = 81,
                Uraian = "Kolekte Ibadah Lainnya",
                JenisAkunId = 2,
                KelompokAkunId = 7,
            },
            new
            {
                Id = 82,
                Uraian = "Uang Harian",
                JenisAkunId = 8,
                KelompokAkunId = 9,
            },
            new
            {
                Id = 83,
                Uraian = "Konsumsi Rapat",
                JenisAkunId = 8,
                KelompokAkunId = 9,
            },
            new
            {
                Id = 84,
                Uraian = "Pembuatan LHPP",
                JenisAkunId = 8,
                KelompokAkunId = 9,
            },
            new
            {
                Id = 85,
                Uraian = "Gaji Koster",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 86,
                Uraian = "Gaji Tata Usaha (TU) Gereja",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 87,
                Uraian = "Gaji Sopir",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 88,
                Uraian = "Insentif Calon Vicaris (CAVIK)",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 89,
                Uraian = "Insentif Song Leader/Prokantor (2 orang)",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 90,
                Uraian = "Insentif Organis/Sound System (2 orang)",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 91,
                Uraian = "Insentif Operator LCD",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 92,
                Uraian = "Jasa sopir tidak tetap",
                JenisAkunId = 8,
                KelompokAkunId = 10,
            },
            new
            {
                Id = 93,
                Uraian = "Tunjangan Khusus Koster",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 94,
                Uraian = "Tunjangan Khusus TU Gereja",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 95,
                Uraian = "Tunjangan Khusus Sopir",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 96,
                Uraian = "Tunjangan Khusus Calon Vicaris (CAVIK)",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 97,
                Uraian = "Tunjangan Khusus Organis/Sound Systim",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 98,
                Uraian = "Tunjangan Khusus Operator LCD",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 99,
                Uraian = "Tunjangan Khusus Presbiter",
                JenisAkunId = 8,
                KelompokAkunId = 11,
            },
            new
            {
                Id = 100,
                Uraian = "Alat Tulis Kantor (ATK) dan Bahan Habis Pakai Lainnya ",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 101,
                Uraian = "Biaya Penggandaan dan Cetak",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 102,
                Uraian = "ATK, Biaya Penggandaan dan Cetak kegiatan sidang program tahun pelayanan 2025",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 103,
                Uraian = "Biaya Listrik (Gereja dan Pastori)",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 104,
                Uraian = "Air",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 105,
                Uraian = "Telepon/Indihome/Wifi",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 106,
                Uraian = "Alat & Bahan Kebersihan/Kesehatan",
                JenisAkunId = 8,
                KelompokAkunId = 12,
            },
            new
            {
                Id = 107,
                Uraian = "Pengadaan Barang Inventaris (Keyboard)",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 108,
                Uraian = "Pemeliharaan Barang Inventaris",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 109,
                Uraian = "Pemeliharaan Gedung (Gereja, Pastori, dll)",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 110,
                Uraian = "Pemeliharaan Mobil Pelayanan",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 111,
                Uraian = "Pemeliharaan Instalasi Air dan Instalasi Listrik",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 112,
                Uraian = "Bahan Bakar",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 113,
                Uraian = "Pengadaan Buku Pedoman Organisasi & Buku Lainnya",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 114,
                Uraian = "Pengadaan Surat Gerejawi",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 115,
                Uraian = "Pengadaan poni gorden jendela gereja warna hijau",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 116,
                Uraian = "Pengadaan meja",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 117,
                Uraian = "Pengadaan CCTV",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 118,
                Uraian = "Pengadaan gitar akustik",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 119,
                Uraian = "Pengadaan Alat Musik (Kajon)",
                JenisAkunId = 8,
                KelompokAkunId = 13,
            },
            new
            {
                Id = 120,
                Uraian = "Transport Pendeta & (MJH) mengikuti Rapat/Sidang",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 121,
                Uraian = "Transport Pendeta Tamu",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 122,
                Uraian = "Transport MKH/MSH atas undangan jemaat",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 123,
                Uraian = "Transport Presbiter/BP/UPP, dll",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 124,
                Uraian = "Transport MJH ke kantor Klasis/Sinode",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 125,
                Uraian = "Transport Bendahara/TU ke Bank",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 126,
                Uraian = "Transport Pemateri",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 127,
                Uraian = "Transport Lainnya",
                JenisAkunId = 8,
                KelompokAkunId = 14,
            },
            new
            {
                Id = 128,
                Uraian = "Setoran Sentralisasi Gaji Pokok (SGP)",
                JenisAkunId = 8,
                KelompokAkunId = 15,
            },
            new
            {
                Id = 129,
                Uraian = "Setoran 10% Penerimaan (Dana Rutin)",
                JenisAkunId = 8,
                KelompokAkunId = 15,
            },
            new
            {
                Id = 130,
                Uraian = "Setoran 10% Dana Pembangunan",
                JenisAkunId = 8,
                KelompokAkunId = 15,
            },
            new
            {
                Id = 131,
                Uraian = "Setoran 2% Dana Pendidikan",
                JenisAkunId = 8,
                KelompokAkunId = 15,
            },
            new
            {
                Id = 132,
                Uraian = "Setoran Dana Kebersamaan",
                JenisAkunId = 8,
                KelompokAkunId = 15,
            },
            new
            {
                Id = 133,
                Uraian = "Perayaan Hari Ibu dan Natal",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 134,
                Uraian = "Ibadah Gabungan LANSIA Teritori 2",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 135,
                Uraian = "Ibadah Gabungan Persekutuan Doa Teritori 2",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 136,
                Uraian = "Ibadah Kreatif Persekutuan Doa",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 137,
                Uraian = "Ibadah Syukur Natal Pemuda Teritori 2",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 138,
                Uraian = "Ibadah Gabungan Kaum Perempuan Teritori 2",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 139,
                Uraian = "Ibadah Pemuda Teritori-dalam klasis-luar klasis",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 140,
                Uraian = "Ibadah NATAL PART",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 141,
                Uraian = "Ibadah PASUTRI JLET",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 142,
                Uraian = "Ibadah Padang memperingati HUT Reformasi dan GMIT",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 143,
                Uraian = "Ibadah syukur HUT JLET",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 144,
                Uraian = "Ibadah syukur Natal JLET",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 145,
                Uraian = "Ibadah Kreatif BP, UPP dan BP JLET",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 146,
                Uraian = "Ibadah Kreatif Pemuda 3",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 147,
                Uraian = "Ibadah Kreatif Pemuda 4",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 148,
                Uraian = "Ibadah ke Rote (UPP Perempuan)",
                JenisAkunId = 9,
                KelompokAkunId = 16,
            },
            new
            {
                Id = 149,
                Uraian = "Bakti Sosial PART",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 150,
                Uraian = "Lomba PASKAH PART",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 151,
                Uraian = "Lomba HUT RI PART",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 152,
                Uraian = "Perayaan NATAL PART",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 153,
                Uraian = "Pelatihan Kepemimpinan Pemuda",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 154,
                Uraian = "Lomba Kreasi Salib memperingati PASKAH 2024",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 155,
                Uraian = "Malam puji-pujian menyambut PASKAH",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 156,
                Uraian = "Pawai PASKAH JLET",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 157,
                Uraian = "Lomba voly Putra-Putri antar Rayon memperingati Bulan keluarga",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 158,
                Uraian = "Lomba memasak nasi goreng antar keluarga dari tiap rayon memperingati Bulan Keluarga",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 159,
                Uraian = "Lomba VG Kaum Bapak Memperingati HUT JLET",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 160,
                Uraian = "Lomba CCA Keluarga antar Rayon",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 161,
                Uraian = "Lomba Pohon Natal antar rayon di lingkungan gereja",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 162,
                Uraian = "Insentif Pengajar Katekasasi (2 orang)",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 163,
                Uraian = "Insentif Pengajar UPP PAR",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 164,
                Uraian = "Memberikan Apresiasi kepada anak-anak (Sertifikat Naik Kelas, dll)",
                JenisAkunId = 9,
                KelompokAkunId = 17,
            },
            new
            {
                Id = 165,
                Uraian = "Pengadaan Bahan Perjamuan Kudus",
                JenisAkunId = 9,
                KelompokAkunId = 18,
            },
            new
            {
                Id = 166,
                Uraian = "Perbaikan peti keyboard",
                JenisAkunId = 9,
                KelompokAkunId = 18,
            },
            new
            {
                Id = 167,
                Uraian = "Pengadaan meja operator slide",
                JenisAkunId = 9,
                KelompokAkunId = 18,
            },
            new
            {
                Id = 168,
                Uraian = "Insentif songlider, musik dan operator slide ",
                JenisAkunId = 9,
                KelompokAkunId = 18,
            },
            new
            {
                Id = 169,
                Uraian = "Insentif Soundman",
                JenisAkunId = 9,
                KelompokAkunId = 18,
            },
            new
            {
                Id = 170,
                Uraian = "Diakonia Sakit",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 171,
                Uraian = "Diakonia Duka Cita",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 172,
                Uraian = "Diakonia bagi jemaat JLET yang tidak mampu",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 173,
                Uraian = "Pemeriksaan Kesehatan bagi LANSIA",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 174,
                Uraian = "Bingkisan Kasih Majelis Jemaat",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 175,
                Uraian = "Pelatihan peningkatan kapasitas diaken dalam pelayanan diakonia holistik",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 176,
                Uraian = "Pelatihan Ketrampilan (Vokasi) Bagi Jemaat (PEMUDA)",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 177,
                Uraian = "Beasiswa pendidikan kepada anak berprestasi  yang kurang mampu.",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 178,
                Uraian = "Pemberian bantuan dana pendidikan untuk calon mahasiswa musik gerejawi",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 179,
                Uraian = "Bantuan bagi warga JLET yang mengalami bencana alam dan Non Alam",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 180,
                Uraian = "Diakonia Lain-Lain",
                JenisAkunId = 9,
                KelompokAkunId = 19,
            },
            new
            {
                Id = 181,
                Uraian = "Pemanfaatan pekarangan gereja (dapur hidup, apotik hidup)",
                JenisAkunId = 9,
                KelompokAkunId = 20,
            },
            new
            {
                Id = 182,
                Uraian = "Pelatihan musik Kaum Bapak (transportasi pelatih)",
                JenisAkunId = 9,
                KelompokAkunId = 20,
            },
            new
            {
                Id = 183,
                Uraian = "Pengurusan Sertifikat Tanah (Balik Nama)",
                JenisAkunId = 9,
                KelompokAkunId = 21,
            },
            new
            {
                Id = 184,
                Uraian = "Pemasangan Identitas Mobil Pelayanan JLET",
                JenisAkunId = 9,
                KelompokAkunId = 21,
            },
        };

        var daftarAkunDenganGolonganAkun = new[]
        {
            new
            {
                Id = 185,
                Uraian = "Tunjangan Struktural",
                JenisAkunId = 8,
                GolonganAkunId = 1,
            },
            new
            {
                Id = 186,
                Uraian = "Tunjangan Kesejahteraan (Kesra)",
                JenisAkunId = 8,
                GolonganAkunId = 1,
            },
            new
            {
                Id = 187,
                Uraian = "Tunjangan Kesehatan",
                JenisAkunId = 8,
                GolonganAkunId = 1,
            },
            new
            {
                Id = 188,
                Uraian = "Tunjangan Lainnya",
                JenisAkunId = 8,
                GolonganAkunId = 1,
            },
            new
            {
                Id = 189,
                Uraian = "Wakil Ketua",
                JenisAkunId = 8,
                GolonganAkunId = 2,
            },
            new
            {
                Id = 190,
                Uraian = "Sekretaris",
                JenisAkunId = 8,
                GolonganAkunId = 2,
            },
            new
            {
                Id = 191,
                Uraian = "Wakil Sekretaris",
                JenisAkunId = 8,
                GolonganAkunId = 2,
            },
            new
            {
                Id = 192,
                Uraian = "Bendahara",
                JenisAkunId = 8,
                GolonganAkunId = 2,
            },
            new
            {
                Id = 193,
                Uraian = "Wakil Bendahara",
                JenisAkunId = 8,
                GolonganAkunId = 2,
            },
            new
            {
                Id = 194,
                Uraian = "Gaji Ke-13 KMJ",
                JenisAkunId = 8,
                GolonganAkunId = 3,
            },
            new
            {
                Id = 195,
                Uraian = "Ketua Majelis Jemaat (KMJ)",
                JenisAkunId = 8,
                GolonganAkunId = 4,
            },
            new
            {
                Id = 196,
                Uraian = "Wakil Ketua",
                JenisAkunId = 8,
                GolonganAkunId = 4,
            },
            new
            {
                Id = 197,
                Uraian = "Sekretaris",
                JenisAkunId = 8,
                GolonganAkunId = 4,
            },
            new
            {
                Id = 198,
                Uraian = "Wakil Sekretaris",
                JenisAkunId = 8,
                GolonganAkunId = 4,
            },
            new
            {
                Id = 199,
                Uraian = "Bendahara",
                JenisAkunId = 8,
                GolonganAkunId = 4,
            },
            new
            {
                Id = 200,
                Uraian = "Wakil Bendahara",
                JenisAkunId = 8,
                GolonganAkunId = 4,
            },
            new
            {
                Id = 201,
                Uraian = "Konsumsi Pertemuan/Rapat Pendeta",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 202,
                Uraian = "Konsumsi Pendeta Tamu dan Tamu Pendeta",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 203,
                Uraian = "Konsumsi Lembur MJH",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 204,
                Uraian = "Konsumsi UPP/BP/Tim Kerja, dll",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 205,
                Uraian = "Rapat evaluasi program dan kegiatan lainnya",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 206,
                Uraian = "Sidang Program Tahun Pelayanan 2025",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 207,
                Uraian = "Konsumsi Lainnya",
                JenisAkunId = 8,
                GolonganAkunId = 5,
            },
            new
            {
                Id = 209,
                Uraian = "Lumpsum Luar Daerah",
                JenisAkunId = 8,
                GolonganAkunId = 6,
            },
            new
            {
                Id = 210,
                Uraian = "Penginapan",
                JenisAkunId = 8,
                GolonganAkunId = 6,
            },
            new
            {
                Id = 211,
                Uraian = "Transportasi (luar daerah)",
                JenisAkunId = 8,
                GolonganAkunId = 6,
            },
            new
            {
                Id = 212,
                Uraian = "Transportasi (dalam daerah)",
                JenisAkunId = 8,
                GolonganAkunId = 6,
            },
            new
            {
                Id = 213,
                Uraian = "Lumpsum dalam Daerah",
                JenisAkunId = 8,
                GolonganAkunId = 6,
            },
            new
            {
                Id = 214,
                Uraian = "Rekoleksi (Kupang - Siangapore PP)",
                JenisAkunId = 8,
                GolonganAkunId = 6,
            },
            new
            {
                Id = 215,
                Uraian = "Pembangunan",
                JenisAkunId = 9,
                GolonganAkunId = 7,
            },
            new
            {
                Id = 216,
                Uraian = "Pasang Ganti Penutup Atap",
                JenisAkunId = 9,
                GolonganAkunId = 7,
            },
            new
            {
                Id = 217,
                Uraian = "Pasang Ganti Kuda - kuda",
                JenisAkunId = 9,
                GolonganAkunId = 7,
            },
            new
            {
                Id = 218,
                Uraian = "Pasang Ganti Plafond",
                JenisAkunId = 9,
                GolonganAkunId = 7,
            },
            new
            {
                Id = 219,
                Uraian = "Finishing Dinding",
                JenisAkunId = 9,
                GolonganAkunId = 8,
            },
            new
            {
                Id = 220,
                Uraian = "Finishing Lantai",
                JenisAkunId = 9,
                GolonganAkunId = 8,
            },
            new
            {
                Id = 221,
                Uraian = "Finishing Atap",
                JenisAkunId = 9,
                GolonganAkunId = 8,
            },
            new
            {
                Id = 222,
                Uraian = "Pasang Baru Plafond",
                JenisAkunId = 9,
                GolonganAkunId = 8,
            },
            new
            {
                Id = 223,
                Uraian = "Pasang Baru Penerangan dan Kelistrikan",
                JenisAkunId = 9,
                GolonganAkunId = 8,
            },
            new
            {
                Id = 224,
                Uraian = "Pasang Baru Toilet dan Kelengkapan",
                JenisAkunId = 9,
                GolonganAkunId = 8,
            },
            new
            {
                Id = 225,
                Uraian = "Perbaikan Atap",
                JenisAkunId = 9,
                GolonganAkunId = 9,
            },
            new
            {
                Id = 226,
                Uraian = "Perbaikan Listrik",
                JenisAkunId = 9,
                GolonganAkunId = 9,
            },
            new
            {
                Id = 227,
                Uraian = "Pasang Baru Penutup Gerbang",
                JenisAkunId = 9,
                GolonganAkunId = 10,
            },
            new
            {
                Id = 228,
                Uraian = "Pasang Baru Railing Tangga Talud",
                JenisAkunId = 9,
                GolonganAkunId = 10,
            },
            new
            {
                Id = 229,
                Uraian = "Pasang Baru Kanopi Parkiran",
                JenisAkunId = 9,
                GolonganAkunId = 10,
            },
            new
            {
                Id = 230,
                Uraian = "Pasang Baru Pos Jaga",
                JenisAkunId = 9,
                GolonganAkunId = 10,
            },
            new
            {
                Id = 231,
                Uraian = "Normalisasi Area Parkir",
                JenisAkunId = 9,
                GolonganAkunId = 10,
            },
        };

        modelBuilder.Entity<Akun>().HasData(
            daftarAkunDenganJenisAkun.Select(a =>
            {
                if (a.JenisAkunId <= 7 && a.JenisAkunId >= 1)
                    if (a.Uraian != "Hasil Lelang")
                        return new { a.Id, a.Uraian, a.JenisAkunId, Tahun = tahun, PresentaseSetoran = (double?)0.5d };
                    else
                        return new { a.Id, a.Uraian, a.JenisAkunId, Tahun = tahun, PresentaseSetoran = (double?)0d };
                else
                    return new { a.Id, a.Uraian, a.JenisAkunId, Tahun = tahun, PresentaseSetoran = (double?)null };
            }).ToArray());

        modelBuilder.Entity<Akun>().HasData(
            daftarAkunDenganKelompokAkun.Select(a =>
            {
                if (a.JenisAkunId <= 7 && a.JenisAkunId >= 1)
                    return new { a.Id, a.Uraian, a.JenisAkunId, a.KelompokAkunId, Tahun = tahun, PresentaseSetoran = (double?)0.5d };
                else
                    return new { a.Id, a.Uraian, a.JenisAkunId, a.KelompokAkunId, Tahun = tahun, PresentaseSetoran = (double?)null };
            }).ToArray());

        modelBuilder.Entity<Akun>().HasData(
            daftarAkunDenganGolonganAkun.Select(a =>
            {
                if (a.JenisAkunId <= 7 && a.JenisAkunId >= 1)
                    return new { a.Id, a.Uraian, a.JenisAkunId, a.GolonganAkunId, Tahun = tahun, PresentaseSetoran = (double?)0.5d };
                else
                    return new { a.Id, a.Uraian, a.JenisAkunId, a.GolonganAkunId, Tahun = tahun, PresentaseSetoran = (double?)null };
            }).ToArray());
        #endregion

        #region RAPBJ
        modelBuilder.Entity<RAPBJ>().HasData(new RAPBJ { Tahun = 2024 });
        #endregion

        #region DetailRAPBJ
        modelBuilder.Entity<DetailRAPBJ>().HasData(
            daftarAkunDenganJenisAkun.Select(a => new DetailRAPBJ
            {
                TahunRAPBJ = 2024,
                KodeAkun = a.Id,
                Volume = 1,
                Satuan = "kali",
                HargaSatuan = 10000d
            })
        );

        modelBuilder.Entity<DetailRAPBJ>().HasData(
            daftarAkunDenganKelompokAkun.Select(a => new DetailRAPBJ
            {
                TahunRAPBJ = 2024,
                KodeAkun = a.Id,
                Volume = 1,
                Satuan = "kali",
                HargaSatuan = 10000d
            })
        );

        modelBuilder.Entity<DetailRAPBJ>().HasData(
            daftarAkunDenganGolonganAkun.Select(a => new DetailRAPBJ
            {
                TahunRAPBJ = 2024,
                KodeAkun = a.Id,
                Volume = 1,
                Satuan = "kali",
                HargaSatuan = 10000d
            })
        );
        #endregion

        #region Kas
        modelBuilder.Entity<Kas>().HasData(
            new Kas
            {
                Id = 1,
                Uraian = "Kas Bank GMIT Lanud",
                Saldo = 6031500d,
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 2)
            }
        );
        #endregion

        #region BuktiTransaksi
        modelBuilder.Entity<BuktiTransaksi>().HasData(
            new BuktiTransaksi
            {
                Id = 1,
                Uraian = "Bukti Transaksi Belanja 1",
                FileBukti = new UriBuilder
                {
                    Host = "locahost",
                    Port = 1704,
                    Path = "/file/1"
                }.Uri,
                Jenis = Jenis.Belanja,
                TanggalDitambahkan = new DateTime(2024, 1, 1)
            },
            new BuktiTransaksi
            {
                Id = 2,
                Uraian = "Bukti Transaksi Belanja 2",
                FileBukti = new UriBuilder
                {
                    Host = "locahost",
                    Port = 1704,
                    Path = "/file/2"
                }.Uri,
                Jenis = Jenis.Belanja,
                TanggalDitambahkan = new DateTime(2024, 1, 2)
            },
            new BuktiTransaksi
            {
                Id = 3,
                Uraian = "Bukti Transaksi Penerimaan 1",
                FileBukti = new UriBuilder
                {
                    Host = "locahost",
                    Port = 1704,
                    Path = "/file/3"
                }.Uri,
                Jenis = Jenis.Penerimaan,
                TanggalDitambahkan = new DateTime(2024, 1, 1)
            },
            new BuktiTransaksi
            {
                Id = 4,
                Uraian = "Bukti Transaksi Penerimaan 2",
                FileBukti = new UriBuilder
                {
                    Host = "locahost",
                    Port = 1704,
                    Path = "/file/4"
                }.Uri,
                Jenis = Jenis.Penerimaan,
                TanggalDitambahkan = new DateTime(2024, 1, 2)
            }
        );
        #endregion

        #region Belanja
        modelBuilder.Entity<Belanja>().HasData(
            new
            {
                Id = 1,
                Uraian = "Diakonia Duka Alm. An. Ezra Sioh Rayon 7",
                Jumlah = 500000d,
                SaldoKas = 9713500d,
                Tanggal = new DateOnly(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                AkunId = 171,
                KasId = 1,
                BuktiTransaksiId = 1,
            },
            new
            {
                Id = 2,
                Uraian = "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-",
                Jumlah = 150000d,
                SaldoKas = 9563500d,
                Tanggal = new DateOnly(2024, 1, 2),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                AkunId = 141,
                KasId = 1,
                BuktiTransaksiId = 2,
            }
        );
        #endregion

        #region Penerimaan
        modelBuilder.Entity<Penerimaan>().HasData(
            new
            {
                Id = 1,
                Uraian = "Kolekte",
                Jumlah = 930000d,
                SaldoKas = 6961500d,
                Tanggal = new DateOnly(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                AkunId = 51,
                KasId = 1,
                BuktiTransaksiId = 3
            },
            new
            {
                Id = 2,
                Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 1",
                Jumlah = 30000d,
                SaldoKas = 7141000d,
                Tanggal = new DateOnly(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                AkunId = 21,
                KasId = 1,
                BuktiTransaksiId = 4
            }
        );
        #endregion

        #region User
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                UserName = "Bendahara",
                Role = UserRoles.Bendahara,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Bendahara")
            }
        );
        #endregion

        return modelBuilder;
    }
}
