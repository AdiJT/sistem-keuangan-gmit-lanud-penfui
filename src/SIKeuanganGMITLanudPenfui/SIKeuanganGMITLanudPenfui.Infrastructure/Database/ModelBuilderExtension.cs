using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database;

internal static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        #region JenisAkun
        var daftarJenisAkun = new JenisAkun[]
        {
            new()
            {
                Id = 1,
                Uraian = "Sisa lebih perhitungan tahun (Surplus)",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 2,
                Uraian = "Kolekte/Persembahan",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 3,
                Uraian = "Kolekte Ibadah Syukur",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 4,
                Uraian = "Nazar",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 5,
                Uraian = "Persepuluhan dan Syukur",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 6,
                Uraian = "Pembangunan",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 7,
                Uraian = "Penerimaan Lain-Lain",
                Jenis = Jenis.Penerimaan
            },
            new()
            {
                Id = 8,
                Uraian = "Belanja Rutin",
                Jenis = Jenis.Belanja,
            },
            new()
            {
                Id = 9,
                Uraian = "Belanja Program Pelayanan",
                Jenis = Jenis.Belanja
            },
            new()
            {
                Id = 10,
                Uraian = "Belanja Lain-Lain",
                Jenis = Jenis.Belanja
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
                JenisAkunId = 2
            },
            new
            {
                Id = 2,
                Uraian = "Kolekte Kebaktian Sakramen Perjamuan Kudus",
                JenisAkunId = 2
            },
            new
            {
                Id = 3,
                Uraian = "Kolekte Kebaktian Baptisan Kudus",
                JenisAkunId = 2
            },
            new
            {
                Id = 4,
                Uraian = "Kolekte Kebaktian Peneguhan Sidi Baru",
                JenisAkunId = 2
            },
            new
            {
                Id = 5,
                Uraian = "Kolekte Kebaktian Peneguhan Sidi Baru",
                JenisAkunId = 2
            },
            new
            {
                Id = 6,
                Uraian = "Kolekte Ibadah Rumah Tangga",
                JenisAkunId = 2
            },
            new
            {
                Id = 7,
                Uraian = "Kolekte Ibadah Kategorial/Fungsional, dll",
                JenisAkunId = 2
            },
            new
            {
                Id = 8,
                Uraian = "Pos Penghasilan Pendeta dan MJH",
                JenisAkunId = 8,
            },
            new
            {
                Id = 9,
                Uraian = "Belanja BPPPJ",
                JenisAkunId = 8,
            },
            new
            {
                Id = 10,
                Uraian = "Belanja Karyawan",
                JenisAkunId = 8,
            },
            new
            {
                Id = 11,
                Uraian = "Tunjangan Khusus Karyawan/Presbiter",
                JenisAkunId = 8,
            },
            new
            {
                Id = 12,
                Uraian = "Belanja Kantor",
                JenisAkunId = 8,
            },
            new
            {
                Id = 13,
                Uraian = "Belanja Pengadaan & Pemeliharaan",
                JenisAkunId = 8,
            },
            new
            {
                Id = 14,
                Uraian = "Belanja Perjalanan",
                JenisAkunId = 8,
            },
            new
            {
                Id = 15,
                Uraian = "Belanja Tanggungan Rutin Jemaat",
                JenisAkunId = 8,
            },
            new
            {
                Id = 16,
                Uraian = "Bidang Koinonia",
                JenisAkunId = 9,
            },
            new
            {
                Id = 17,
                Uraian = "Bidang Marturia",
                JenisAkunId = 9,
            },
            new
            {
                Id = 18,
                Uraian = "Bidang Liturgia",
                JenisAkunId = 9,
            },
            new
            {
                Id = 19,
                Uraian = "Bidang Diakonia",
                JenisAkunId = 9,
            },
            new
            {
                Id = 20,
                Uraian = "Bidang Oikonomia",
                JenisAkunId = 9,
            },
            new
            {
                Id = 21,
                Uraian = "Bidang Umum dan Rekomendasi",
                JenisAkunId = 9,
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
                KelompokAkunId = 8
            },
            new
            {
                Id = 2,
                Uraian = "Insentif MJH",
                KelompokAkunId = 8
            },
            new
            {
                Id = 3,
                Uraian = "Tunjangan Khusus MJH",
                KelompokAkunId = 8
            },
            new
            {
                Id = 4,
                Uraian = "Gaji Ke-13",
                KelompokAkunId = 8
            },
            new
            {
                Id = 5,
                Uraian = "Biaya Konsumsi",
                KelompokAkunId = 12
            },
            new
            {
                Id = 6,
                Uraian = "Biaya Perjalanan Dinas Pendeta",
                KelompokAkunId = 14
            },
            new
            {
                Id = 7,
                Uraian = "Renovasi Gedung Ibadah",
                KelompokAkunId = 20
            },
            new
            {
                Id = 8,
                Uraian = "Renovasi Gedung Pusat Kegiatan PART, Pemuda dan Serba Guna",
                KelompokAkunId = 20
            },
            new
            {
                Id = 9,
                Uraian = "Renovasi Rumah Pastori",
                KelompokAkunId = 20
            },
            new
            {
                Id = 10,
                Uraian = "Renovasi Pertamanan",
                KelompokAkunId = 20
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
        };
        #endregion

        return modelBuilder;
    }
}
