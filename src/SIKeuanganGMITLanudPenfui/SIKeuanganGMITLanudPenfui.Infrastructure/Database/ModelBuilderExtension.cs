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
                Uraian = "Biaya Konsumsi",
                KelompokAkunId = 12
            },
            new
            {
                Id = 5,
                Uraian = "Biaya Perjalanan Dinas Pendeta",
                KelompokAkunId = 14
            },
            new
            {
                Id = 6,
                Uraian = "Renovasi Gedung Ibadah",
                KelompokAkunId = 20
            },
            new
            {
                Id = 7,
                Uraian = "Renovasi Gedung Pusat Kegiatan PART, Pemuda dan Serba Guna",
                KelompokAkunId = 20
            },
            new
            {
                Id = 8,
                Uraian = "Renovasi Rumah Pastori",
                KelompokAkunId = 20
            },
            new
            {
                Id = 9,
                Uraian = "Renovasi Pertamanan",
                KelompokAkunId = 20
            },
        };
        #endregion

        #region Akun

        #endregion

        return modelBuilder;
    }
}
