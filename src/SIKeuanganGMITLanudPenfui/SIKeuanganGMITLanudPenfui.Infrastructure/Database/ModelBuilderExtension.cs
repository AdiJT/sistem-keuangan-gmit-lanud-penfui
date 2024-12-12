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
        var daftarJenisAkun = new[]
        {
            new
            {
                Id = 1,
                Uraian = "BAGIAN SiLPA TAHUN ANGARAN LALU (POS RUTIN)",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 2,
                Uraian = "BAGIAN PENDAPATAN SENDIRI",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 2
            },
            new
            {
                Id = 3,
                Uraian = "BAGIAN PENERIMAAN PEMBANGUNAN",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 3
            },
            new
            {
                Id = 4,
                Uraian = "RK DI BENDAHARA",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 4
            },
            new
            {
                Id = 5,
                Uraian = "BAGIAN PENERIMAAN PENDIDIKAN",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 5
            },
            new
            {
                Id = 6,
                Uraian = "BAGIAN PENERIMAAN LAIN-LAIN",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 6
            },
            new
            {
                Id = 7,
                Uraian = "BAGIAN PENERIMAAN PEMBIAYAAN",
                Jenis = Jenis.Penerimaan,
                Tahun = tahun,
                Kode = 7
            },
            new
            {
                Id = 8,
                Uraian = "BAGIAN PELAYANAN BPPPJ",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 9,
                Uraian = "BAGIAN  PELAYANAN MAJELIS JEMAAT",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 2
            },
            new
            {
                Id = 10,
                Uraian = "BAGIAN BIAYA TANGGUNGAN JEMAAT",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 3
            },
            new
            {
                Id = 11,
                Uraian = "BAGIAN PELAYANAN DIAKONIA",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 4
            },
            new
            {
                Id = 12,
                Uraian = "BAGIAN PELAYANAN BANTUAN / SUMBANGAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 5
            },
            new
            {
                Id = 13,
                Uraian = "BAGIAN PENYERTAAN MODAL",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 6
            },
            new
            {
                Id = 14,
                Uraian = "BAGIAN PENGEMBALIAN PINJAMAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 7
            },
            new
            {
                Id = 15,
                Uraian = "POS BELANJA DANA CADANGAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 8
            },
            new
            {
                Id = 16,
                Uraian = "BAGIAN BIAYA TAK TERSANGKA",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 9
            },
            new
            {
                Id = 17,
                Uraian = "BAGIAN PANJAR KEGIATAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 10
            },
            new
            {
                Id = 18,
                Uraian = "BAGIAN BIAYA ADMINISTRASI KEUANGAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 11
            },
            new
            {
                Id = 19,
                Uraian = "BAGIAN PENGELUARAN PEMBIAYAAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 12
            },
            new
            {
                Id = 20,
                Uraian = "KEWAJIBAN",
                Jenis = Jenis.Belanja,
                Tahun = tahun,
                Kode = 13
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
                Uraian = "Pos SiLPA TAHUN ANGGARAN LALU (POS RUTIN)",
                JenisAkunId = 1,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 2,
                Uraian = "POS KOLEKTE PERSEMBAHAN",
                JenisAkunId = 2,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 3,
                Uraian = "POS PERSEMBAHAN DALAM BENTUK NATURA",
                JenisAkunId = 2,
                Tahun = tahun,
                Kode = 2
            },
            new
            {
                Id = 4,
                Uraian = "POS PERSEMBAHAN NAZAR DAN DERMA",
                JenisAkunId = 2,
                Tahun = tahun,
                Kode = 3
            },
            new
            {
                Id = 5,
                Uraian = "POS PERSEMBAHAN PERSEPULUHAN",
                JenisAkunId = 2,
                Tahun = tahun,
                Kode = 4
            },
            new
            {
                Id = 6,
                Uraian = "POS USAHA DANA",
                JenisAkunId = 2,
                Tahun = tahun,
                Kode = 5
            },
            new
            {
                Id = 7,
                Uraian = "POS PERSEMBAHAN DIAKONIA",
                JenisAkunId = 2,
                Tahun = tahun,
                Kode = 6
            },
            new
            {
                Id = 8,
                Uraian = "POS PENERIMAAN PEMBANGUNAN",
                JenisAkunId = 3,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 9,
                Uraian = "RK DI BENDAHARA",
                JenisAkunId = 4,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 10,
                Uraian = "POS PENERIMAAN PENDIDIKAN",
                JenisAkunId = 5,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 11,
                Uraian = "POS PENERIMAAN LAIN-LAIN",
                JenisAkunId = 6,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 12,
                Uraian = "POS PENERIMAAN JASA GIRO BANK/PINJAMAN ANTAR REKENING KAS JEL",
                JenisAkunId = 6,
                Tahun = tahun,
                Kode = 2
            },
            new
            {
                Id = 13,
                Uraian = "POS PENERIMAAN PEMBIAYAAN",
                JenisAkunId = 7,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 14,
                Uraian = "POS PENGHASILAN BPPPJ",
                JenisAkunId = 8,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 15,
                Uraian = "POS BELANJA PENGHASILAN PENDETA, MJH Non PENDETA DAN PENGAJAR",
                JenisAkunId = 9,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 16,
                Uraian = "POS BELANJA PENGHASILAN KARYAWAN",
                JenisAkunId = 9,
                Tahun = tahun,
                Kode = 2
            },
            new
            {
                Id = 17,
                Uraian = "POS BELANJA OPERASONAL KANTOR DAN KEGIATAN",
                JenisAkunId = 9,
                Tahun = tahun,
                Kode = 3
            },
            new
            {
                Id = 18,
                Uraian = "Pos Belanja Pemeliharaan",
                JenisAkunId = 9,
                Tahun = tahun,
                Kode = 4
            },
            new
            {
                Id = 19,
                Uraian = "POS BELANJA PERJALANAN PELAYANAN",
                JenisAkunId = 9,
                Tahun = tahun,
                Kode = 5
            },
            new
            {
                Id = 20,
                Uraian = "POS PENGADAAN BARANG INVETRAIS",
                JenisAkunId = 9,
                Tahun = tahun,
                Kode = 6
            },
            new
            {
                Id = 21,
                Uraian = "POS BELANJA TANGGUNGAN JEMAAT",
                JenisAkunId = 10,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 22,
                Uraian = "POS BELANJA PELAYANAN DIAKONIA",
                JenisAkunId = 11,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 23,
                Uraian = "POS BELANJA PELAYANAN BANTUAN / SUMBANGAN",
                JenisAkunId = 12,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 24,
                Uraian = "POS BELANJA PENYERTAAN MODAL",
                JenisAkunId = 13,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 25,
                Uraian = "POS BELANJA PENGEMBALIAN PINJAMAN",
                JenisAkunId = 14,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 26,
                Uraian = "POS BELANJA DANA CADANGAN",
                JenisAkunId = 15,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 27,
                Uraian = "POS BELANJA BIAYA TAK TERSANGKA",
                JenisAkunId = 16,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 28,
                Uraian = "POS BELANJA PANJAR KEGIATAN",
                JenisAkunId = 17,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 29,
                Uraian = "POS BELANJA BIAYA ADMINISTRASI KEUANGAN",
                JenisAkunId = 18,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 30,
                Uraian = "POS PENGELUARAN PEMBIAYAAN",
                JenisAkunId = 19,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 31,
                Uraian = "KEWAJIBAN JANGKA PENDEK",
                JenisAkunId = 20,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 32,
                Uraian = "KEWAJIBAN JANGKA PANJANG",
                JenisAkunId = 20,
                Tahun = tahun,
                Kode = 2
            }
        };
        modelBuilder.Entity<KelompokAkun>().HasData(daftarKelompokAkun);
        #endregion

        #region GolonganAkun
        var daftarGolonganAkun = new[]
        {
            new
            {
                Id = 1,
                Uraian = "Gaji dan Tunjangan Pendeta dan Pengajar, MJH non Pendeta",
                KelompokAkunId = 15,
                Tahun = tahun,
                Kode = 11
            },
            new
            {
                Id = 2,
                Uraian = "Tunjangan Hari Raya",
                KelompokAkunId = 15,
                Tahun = tahun,
                Kode = 12
            },
            new
            {
                Id = 3,
                Uraian = "Tunjangan Pengobatan dan Perawatan",
                KelompokAkunId = 15,
                Tahun = tahun,
                Kode = 13
            },
            new
            {
                Id = 4,
                Uraian = "Biaya Tamu Pendeta",
                KelompokAkunId = 15,
                Tahun = tahun,
                Kode = 14
            },
            new
            {
                Id = 5,
                Uraian = "Bantuan Biaya peggantian biaya telphon, wifi, listrik, rumah dan air Pelayan, sewa rumah pelayan",
                KelompokAkunId = 15,
                Tahun = tahun,
                Kode = 15
            },
            new
            {
                Id = 6,
                Uraian = "Honorarium Anggota MJH non pendeta",
                KelompokAkunId = 15,
                Tahun = tahun,
                Kode = 16
            },
            new
            {
                Id = 7,
                Uraian = "Gaji dan Tunjangan",
                KelompokAkunId = 16,
                Tahun = tahun,
                Kode = 21
            },
            new
            {
                Id = 8,
                Uraian = "Upah Tenaga Harian Kontrak/lepas",
                KelompokAkunId = 16,
                Tahun = tahun,
                Kode = 22
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Hari Raya",
                KelompokAkunId = 16,
                Tahun = tahun,
                Kode = 23
            },
            new
            {
                Id = 10,
                Uraian = "Honorarium",
                KelompokAkunId = 16,
                Tahun = tahun,
                Kode = 24
            },
            new
            {
                Id = 11,
                Uraian = "Uang Lembur",
                KelompokAkunId = 16,
                Tahun = tahun,
                Kode = 25
            },
            new
            {
                Id = 12,
                Uraian = "Lain-lain Belanja Karyawan",
                KelompokAkunId = 16,
                Tahun = tahun,
                Kode = 26
            },
            new
            {
                Id = 13,
                Uraian = "Belanja Barang dan Jasa",
                KelompokAkunId = 17,
                Tahun = tahun,
                Kode = 31
            },
            new
            {
                Id = 14,
                Uraian = "Pembayaran Langganan Jasa Telephon, Listrik, Air, Internet/wifi",
                KelompokAkunId = 17,
                Tahun = tahun,
                Kode = 32
            },
            new
            {
                Id = 15,
                Uraian = "Belanja Suguhan",
                KelompokAkunId = 17,
                Tahun = tahun,
                Kode = 33
            },
            new
            {
                Id = 16,
                Uraian = "Belanja Perawatan Kendaraan Bermotor",
                KelompokAkunId = 17,
                Tahun = tahun,
                Kode = 34
            },
            new
            {
                Id = 17,
                Uraian = "Bangunan Air dan Jaringan dan jalan",
                KelompokAkunId = 18,
                Tahun = tahun,
                Kode = 35
            },
            new
            {
                Id = 18,
                Uraian = "Peralatan dan Mesin",
                KelompokAkunId = 18,
                Tahun = tahun,
                Kode = 36
            },
            new
            {
                Id = 19,
                Uraian = "Peralatan Meubeler",
                KelompokAkunId = 18,
                Tahun = tahun,
                Kode = 37
            },
            new
            {
                Id = 20,
                Uraian = "Gedung dan Bangunan",
                KelompokAkunId = 18,
                Tahun = tahun,
                Kode = 38
            },
            new
            {
                Id = 21,
                Uraian = "Hewan, Tanaman dan Taman",
                KelompokAkunId = 18,
                Tahun = tahun,
                Kode = 39
            },
            new
            {
                Id = 22,
                Uraian = "Biaya Perjalanan Pelayanan Tetap Pendeta dan Tata Usaha",
                KelompokAkunId = 19,
                Tahun = tahun,
                Kode = 40
            },
            new
            {
                Id = 23,
                Uraian = "Uang Transport Pelayanan Tamu",
                KelompokAkunId = 19,
                Tahun = tahun,
                Kode = 41
            },
            new
            {
                Id = 24,
                Uraian = "Lain-lain Perjalanan/Transport Pelayanan",
                KelompokAkunId = 19,
                Tahun = tahun,
                Kode = 42
            },
            new
            {
                Id = 25,
                Uraian = "Biaya Perjalanan Dinas ke luar wilayah",
                KelompokAkunId = 19,
                Tahun = tahun,
                Kode = 43
            },
            new
            {
                Id = 26,
                Uraian = "Peralatan dan Mesin",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 45
            },
            new
            {
                Id = 27,
                Uraian = "Alat - Alat Pengeras Suara",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 46
            },
            new
            {
                Id = 28,
                Uraian = "Alat Olah Raga",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 47
            },
            new
            {
                Id = 29,
                Uraian = "Alat - alat Kesenian",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 48
            },
            new
            {
                Id = 30,
                Uraian = "Alat - alat Sakramen dan Ibadah",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 49
            },
            new
            {
                Id = 31,
                Uraian = "Alat - alat Rumah Tangga",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 50
            },
            new
            {
                Id = 32,
                Uraian = "Barang-Barang Perpustakaan",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 51
            },
            new
            {
                Id = 33,
                Uraian = "Sarana Mobilitas",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 52
            },
            new
            {
                Id = 34,
                Uraian = "Perabot",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 53
            },
            new
            {
                Id = 35,
                Uraian = "Ternak",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 54
            },
            new
            {
                Id = 36,
                Uraian = "Tanaman",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 55
            },
            new
            {
                Id = 37,
                Uraian = "Tanah",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 56
            },
            new
            {
                Id = 38,
                Uraian = "Gedung dan Bangunan",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 57
            },
            new
            {
                Id = 39,
                Uraian = "Bangunan Lainnya Jalan, Jaringan Air dan Telephon",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 58
            },
            new
            {
                Id = 40,
                Uraian = "Cadangan Barang Inventaris",
                KelompokAkunId = 20,
                Tahun = tahun,
                Kode = 59
            },
            new
            {
                Id = 41,
                Uraian = "Tanggungan Jemaat/Alokasi dana untuk Majelis Sinode dan Klasis",
                KelompokAkunId = 21,
                Tahun = tahun,
                Kode = 66
            },
            new
            {
                Id = 42,
                Uraian = "Bantuan Diakonia/Pelayanan Kasih",
                KelompokAkunId = 22,
                Tahun = tahun,
                Kode = 71
            },
            new
            {
                Id = 43,
                Uraian = "Bantuan Diakonia sakit dan Kedukaan",
                KelompokAkunId = 22,
                Tahun = tahun,
                Kode = 72
            },
            new
            {
                Id = 44,
                Uraian = "Lain-lain bantuan Diakonia",
                KelompokAkunId = 22,
                Tahun = tahun,
                Kode = 73
            },
            new
            {
                Id = 45,
                Uraian = "Bantuan/Sumbangan",
                KelompokAkunId = 23,
                Tahun = tahun,
                Kode = 76
            },
            new
            {
                Id = 46,
                Uraian = "POS BELANJA PENYERTAAN MODAL",
                KelompokAkunId = 24,
                Tahun = tahun,
                Kode = 81
            },
            new
            {
                Id = 47,
                Uraian = "POS BELANJA PENGEMBALIAN PINJAMAN",
                KelompokAkunId = 25,
                Tahun = tahun,
                Kode = 86
            },
            new
            {
                Id = 48,
                Uraian = "KEWAJIBAN JANGKA PANJANG",
                KelompokAkunId = 25,
                Tahun = tahun,
                Kode = 87
            },
            new
            {
                Id = 49,
                Uraian = "POS BELANJA DANA CADANGAN",
                KelompokAkunId = 26,
                Tahun = tahun,
                Kode = 91
            },
            new
            {
                Id = 50,
                Uraian = "POS BELANJA BIAYA TAK TERSANGKA",
                KelompokAkunId = 27,
                Tahun = tahun,
                Kode = 96
            },
            new
            {
                Id = 51,
                Uraian = "POS BELANJA PANJAR KEGIATAN",
                KelompokAkunId = 28,
                Tahun = tahun,
                Kode = 98
            },
            new
            {
                Id = 52,
                Uraian = "POS BELANJA BIAYA ADMINISTRASI KEUANGAN",
                KelompokAkunId = 29,
                Tahun = tahun,
                Kode = 100
            },
            new
            {
                Id = 53,
                Uraian = "POS PENGELUARAN PEMBIAYAAN",
                KelompokAkunId = 30,
                Tahun = tahun,
                Kode = 101
            },
            new
            {
                Id = 54,
                Uraian = "KEWAJIBAN JANGKA PENDEK",
                KelompokAkunId = 31,
                Tahun = tahun,
                Kode = 102
            },
            new
            {
                Id = 55,
                Uraian = "KEWAJIBAN JANGKA PANJANG",
                KelompokAkunId = 32,
                Tahun = tahun,
                Kode = 102
            },
            new
            {
                Id = 56,
                Uraian = "Honorarium Ketua, Sekretaris dan anggota BPPPJ",
                KelompokAkunId = 14,
                Tahun = tahun,
                Kode = 1
            },
            new
            {
                Id = 57,
                Uraian = "Biaya Operasional BPPPJ (ATK, Penggandaan, Jilid, Suguhan Rapat)",
                KelompokAkunId = 14,
                Tahun = tahun,
                Kode = 2
            }
        };
        modelBuilder.Entity<GolonganAkun>().HasData(daftarGolonganAkun);
        #endregion

        #region Akun
        var daftarAkunDenganKelompokAkun = new[]
        {
            new
            {
                Id = 1,
                Uraian = "SiLPA TAHUN ANGGARAN LALU (POS RUTIN)",
                JenisAkunId = 1,
                KelompokAkunId = 1,
                Kode = 1
            },
            new
            {
                Id = 2,
                Uraian = "Kolekte Kebaktian Hari Minggu",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 1
            },
            new
            {
                Id = 3,
                Uraian = "Kolekte Kebaktian Hari Raya Gerejawi",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 2
            },
            new
            {
                Id = 4,
                Uraian = "Kolekte Ibadat Pengucapan Syukur",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 3
            },
            new
            {
                Id = 5,
                Uraian = "Kolekte Kebaktian Rumah Tangga",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 4
            },
            new
            {
                Id = 6,
                Uraian = "Kolekte Kebaktian Perjamuan Kudus 1)",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 5
            },
            new
            {
                Id = 7,
                Uraian = "Kolekte Kebaktian Baptisan Kudus 2)",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 6
            },
            new
            {
                Id = 8,
                Uraian = "Kolekte Kebaktian Baptisan Kudus 2)",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 7
            },
            new
            {
                Id = 9,
                Uraian = "Kolekte Kebaktian Pernikahan 2)",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 8
            },
            new
            {
                Id = 10,
                Uraian = "Kolekte Ibadah Kaum Bapak",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 9
            },
            new
            {
                Id = 11,
                Uraian = "Kolekte Ibadah Kaum Perempuan",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 10
            },
            new
            {
                Id = 12,
                Uraian = "Kolekte Ibadah Pemuda",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 11
            },
            new
            {
                Id = 13,
                Uraian = "Kolekte Ibadah Kelompok PAR",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 12
            },
            new
            {
                Id = 14,
                Uraian = "Kolekte Kebaktian Khusus dan lain-lain 3)",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 13
            },
            new
            {
                Id = 15,
                Uraian = "Kolekte Ibadah Pelajar/Mahasiswa",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 14
            },
            new
            {
                Id = 16,
                Uraian = "Kolekte Ibadah Lansia",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 15
            },
            new
            {
                Id = 17,
                Uraian = "Kolekte Ibadah Katekisasi ",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 16
            },
            new
            {
                Id = 18,
                Uraian = "Kolekte Persembahan Palungan",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 17
            },
            new
            {
                Id = 19,
                Uraian = "Kolekte Persembahan HUT Jemaat",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 18
            },
            new
            {
                Id = 20,
                Uraian = "Kolekte Ibadah Pendeta dan Karyawan",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 19
            },
            new
            {
                Id = 21,
                Uraian = "Kolekte Ibadah Pembukaan dan Penutupan Pelayanana",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 20
            },
            new
            {
                Id = 22,
                Uraian = "Kolekte Ibadah Katekisasi",
                JenisAkunId = 2,
                KelompokAkunId = 2,
                Kode = 21
            },
            new
            {
                Id = 23,
                Uraian = "Nilai Uang Persembahan hasil bumi, hutan, dan perkebunan",
                JenisAkunId = 2,
                KelompokAkunId = 3,
                Kode = 25
            },
            new
            {
                Id = 24,
                Uraian = "Nilai Uang Persembahan ternak besar, kecil dan unggas",
                JenisAkunId = 2,
                KelompokAkunId = 3,
                Kode = 26
            },
            new
            {
                Id = 25,
                Uraian = "Nilai Uang Persembahan hasil laut",
                JenisAkunId = 2,
                KelompokAkunId = 3,
                Kode = 27
            },
            new
            {
                Id = 26,
                Uraian = "Nilai Uang Persembahan kerajinan tangan",
                JenisAkunId = 2,
                KelompokAkunId = 3,
                Kode = 28
            },
            new
            {
                Id = 27,
                Uraian = "Nilai Uang Persembahan dalam bentuk natura lainnya",
                JenisAkunId = 2,
                KelompokAkunId = 3,
                Kode = 29   
            },
            new
            {
                Id = 28,
                Uraian = "Persembahan Nazar",
                JenisAkunId = 2,
                KelompokAkunId = 4,
                Kode = 31
            },
            new
            {
                Id = 29,
                Uraian = "Persembahan Derma",
                JenisAkunId = 2,
                KelompokAkunId = 4,
                Kode = 32
            },
            new
            {
                Id = 30,
                Uraian = "Persembahan Persepuluhan",
                JenisAkunId = 2,
                KelompokAkunId = 5,
                Kode = 36
            },
            new
            {
                Id = 31,
                Uraian = "Usaha Dana BPP BPPPJ",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 37
            },
            new
            {
                Id = 32,
                Uraian = "Usaha Dana BPP BPPPPJ",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 38
            },
            new
            {
                Id = 33,
                Uraian = "Usaha Dana BPP Pendidikan",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 39
            },
            new
            {
                Id = 34,
                Uraian = "Usaha Dana BPP Diakonat",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 40
            },
            new
            {
                Id = 35,
                Uraian = "Usaha Dana BPP / HRG Panitia",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 41
            },
            new
            {
                Id = 36,
                Uraian = "Usaha Dana BPP Pembangunan",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 42
            },
            new
            {
                Id = 37,
                Uraian = "Usaha Dana UPP Kaum Bapak",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 43
            },
            new
            {
                Id = 38,
                Uraian = "Usaha Dana UPP Kaum Perempuan",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 44
            },
            new
            {
                Id = 39,
                Uraian = "Usaha Dana UPP Pemuda",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 45
            },
            new
            {
                Id = 40,
                Uraian = "Usaha Dana UPP PAR",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 46
            },
            new
            {
                Id = 41,
                Uraian = "Usaha Dana UPP Persekutuan Doa",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 47
            },
            new
            {
                Id = 42,
                Uraian = "Usaha Dana UPP Lansia",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 48
            },
            new
            {
                Id = 43,
                Uraian = "Usaha Dana UPP Katekisasi",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 49
            },
            new
            {
                Id = 44,
                Uraian = "Usaha Dana UPP Limuger",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 50
            },
            new
            {
                Id = 45,
                Uraian = "Usaha Dana UPP Perbendaharaan",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 51
            },
            new
            {
                Id = 46,
                Uraian = "Usaha Dana UPP Tata Usaha",
                JenisAkunId = 2,
                KelompokAkunId = 6,
                Kode = 52
            },
            new
            {
                Id = 47,
                Uraian = "Persembahan Diakonia",
                JenisAkunId = 2,
                KelompokAkunId = 7,
                Kode = 53
            },
            new
            {
                Id = 48,
                Uraian = "Penerimaan Bantuan/sumbangan antar gereja",
                JenisAkunId = 2,
                KelompokAkunId = 7,
                Kode = 54
            },
            new
            {
                Id = 49,
                Uraian = "Penerimaan Bantuan/sumbangan lainnya",
                JenisAkunId = 2,
                KelompokAkunId = 7,
                Kode = 55
            },
            new
            {
                Id = 50,
                Uraian = "Persembahan Melalui Kartu Pembangunan",
                JenisAkunId = 3,
                KelompokAkunId = 8,
                Kode = 56
            },
            new
            {
                Id = 51,
                Uraian = "Persembahan Spontanitas Jemaat",
                JenisAkunId = 3,
                KelompokAkunId = 8,
                Kode = 57
            },
            new
            {
                Id = 52,
                Uraian = "Persembahan Partisipatif dari luar jemat",
                JenisAkunId = 3,
                KelompokAkunId = 8,
                Kode = 58
            },
            new
            {
                Id = 53,
                Uraian = "Persembahan Dalam Bentuk Bahan/Natura",
                JenisAkunId = 3,
                KelompokAkunId = 8,
                Kode = 59
            },
            new
            {
                Id = 54,
                Uraian = "Tangguk Pembangunan",
                JenisAkunId = 3,
                KelompokAkunId = 8,
                Kode = 60
            },
            new
            {
                Id = 55,
                Uraian = "RK DI BENDAHARA",
                JenisAkunId = 4,
                KelompokAkunId = 9,
                Kode = 1
            },
            new
            {
                Id = 56,
                Uraian = "Bantuan Opersional Pedidikan dari Pemerintah",
                JenisAkunId = 5,
                KelompokAkunId = 10,
                Kode = 66
            },
            new
            {
                Id = 57,
                Uraian = "Sumbangan Pembinaan Pendidikan Siswa",
                JenisAkunId = 5,
                KelompokAkunId = 10,
                Kode = 67
            },
            new
            {
                Id = 58,
                Uraian = "Sumbangan Pembangunan",
                JenisAkunId = 5,
                KelompokAkunId = 10,
                Kode = 68
            },
            new
            {
                Id = 59,
                Uraian = "Sumbangan Lain-lain tidak mengikat",
                JenisAkunId = 5,
                KelompokAkunId = 10,
                Kode = 69
            },
            new
            {
                Id = 60,
                Uraian = "Penerimaan Kembali Panjar/Uang Muka Kerja, dll",
                JenisAkunId = 6,
                KelompokAkunId = 11,
                Kode = 71
            },
            new
            {
                Id = 61,
                Uraian = "Administrasi Surat-surat Gerejawi",
                JenisAkunId = 6,
                KelompokAkunId = 11,
                Kode = 72
            },
            new
            {
                Id = 62,
                Uraian = "Penerimaan Sewa Lahan Usaha",
                JenisAkunId = 6,
                KelompokAkunId = 11,
                Kode = 73
            },
            new
            {
                Id = 63,
                Uraian = "Pemanfaatan Fasilitas JEL",
                JenisAkunId = 6,
                KelompokAkunId = 11,
                Kode = 74
            },
            new
            {
                Id = 64,
                Uraian = "Sumbangan/bantuan",
                JenisAkunId = 6,
                KelompokAkunId = 11,
                Kode = 75
            },
            new
            {
                Id = 65,
                Uraian = "Bunga Bank / Jasa Giro Bank NTT (Pos Rutin)",
                JenisAkunId = 6,
                KelompokAkunId = 12,
                Kode = 76
            },
            new
            {
                Id = 66,
                Uraian = "Bunga Bank / Jasa Giro Bank TLM (Pos Rutin)",
                JenisAkunId = 6,
                KelompokAkunId = 12,
                Kode = 77
            },
            new
            {
                Id = 67,
                Uraian = "Bunga Bank / Jasa Giro  Bank NTT (Pos Pembangunan)",
                JenisAkunId = 6,
                KelompokAkunId = 12,
                Kode = 78
            },
            new
            {
                Id = 68,
                Uraian = "Bunga Bank / Jasa Giro Bank NTT (Pos Cadangan)",
                JenisAkunId = 6,
                KelompokAkunId = 12,
                Kode = 79
            },
            new
            {
                Id = 69,
                Uraian = "Bunga Bank / Jasa Giro Bank TLM (Pos Cadangan)",
                JenisAkunId = 6,
                KelompokAkunId = 12,
                Kode = 80
            },
            new
            {
                Id = 70,
                Uraian = "Penggunaan SiLPA rutin Tahun sebelumnya",
                JenisAkunId = 7,
                KelompokAkunId = 13,
                Kode = 81
            },
            new
            {
                Id = 71,
                Uraian = "Pencairan Dana cadangan",
                JenisAkunId = 7,
                KelompokAkunId = 13,
                Kode = 82
            },
            new
            {
                Id = 72,
                Uraian = "Pencairan Dana Pembangunan",
                JenisAkunId = 7,
                KelompokAkunId = 13,
                Kode = 83
            },
            new
            {
                Id = 73,
                Uraian = "Penerimaan Pinjaman dari Lembaga Keuangan, dll",
                JenisAkunId = 7,
                KelompokAkunId = 13,
                Kode = 84
            },
            new
            {
                Id = 74,
                Uraian = "Penerimaan  Kembali  Pemberian  Pinjaman (dana bergulir)",
                JenisAkunId = 7,
                KelompokAkunId = 13,
                Kode = 85
            },
            new
            {
                Id = 75,
                Uraian = "Penerimaan Piutang",
                JenisAkunId = 7,
                KelompokAkunId = 13,
                Kode = 86
            }
        };

        var daftarAkunDenganGolonganAkun = new[]
        {
            new
            {
                Id = 76,
                Uraian = "Honorarium Ketua, Sekretaris dan anggota BPPPJ",
                JenisAkunId = 8,
                GolonganAkunId = 56,
                Kode = 1
            },
            new
            {
                Id = 77,
                Uraian = "Biaya Operasional BPPPJ (ATK, Penggandaan, Jilid, Suguhan Rapat)",
                JenisAkunId = 8,
                GolonganAkunId = 57,
                Kode = 1
            },
            new
            {
                Id = 78,
                Uraian = "Gaji Pokok",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 1
            },
            new
            {
                Id = 79,
                Uraian = "Tunjangan Keluarga",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 2
            },
            new
            {
                Id = 80,
                Uraian = "Tunjangan Struktural",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 3
            },
            new
            {
                Id = 81,
                Uraian = "Tunjangan Fungsional",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 4
            },
            new
            {
                Id = 82,
                Uraian = "Tunjangan Kesejahteraan",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 5
            },
            new
            {
                Id = 83,
                Uraian = "Tunjangan Beras",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 6
            },
            new
            {
                Id = 84,
                Uraian = "Lain - Lain Tunjangan",
                JenisAkunId = 9,
                GolonganAkunId = 1,
                Kode = 7
            },
            new
            {
                Id = 85,
                Uraian = "Natal",
                JenisAkunId = 9,
                GolonganAkunId = 2,
                Kode = 1
            },
            new
            {
                Id = 86,
                Uraian = "Pengobatan dan Perawatan",
                JenisAkunId = 9,
                GolonganAkunId = 3,
                Kode = 1
            },
            new
            {
                Id = 87,
                Uraian = "Makan dan minum",
                JenisAkunId = 9,
                GolonganAkunId = 4,
                Kode = 1
            },
            new
            {
                Id = 88,
                Uraian = "Cinderamata",
                JenisAkunId = 9,
                GolonganAkunId = 4,
                Kode = 2
            },
            new
            {
                Id = 89,
                Uraian = "Telephon/Pulsa elektronik",
                JenisAkunId = 9,
                GolonganAkunId = 5,
                Kode = 1
            },
            new
            {
                Id = 90,
                Uraian = "Listrik/Pulsa elektronik",
                JenisAkunId = 9,
                GolonganAkunId = 5,
                Kode = 2
            },
            new
            {
                Id = 91,
                Uraian = "Air",
                JenisAkunId = 9,
                GolonganAkunId = 5,
                Kode = 3
            },
            new
            {
                Id = 92,
                Uraian = "Wifi/internet",
                JenisAkunId = 9,
                GolonganAkunId = 5,
                Kode = 4
            },
            new
            {
                Id = 93,
                Uraian = "Lain - lain Tunjangan (Transport Perkunjungan)",
                JenisAkunId = 9,
                GolonganAkunId = 5,
                Kode = 5
            },
            new
            {
                Id = 94,
                Uraian = "Biaya Pengganti Sewa Rumah Pendeta",
                JenisAkunId = 9,
                GolonganAkunId = 5,
                Kode = 6
            },
            new
            {
                Id = 95,
                Uraian = "Wakil Ketua",
                JenisAkunId = 9,
                GolonganAkunId = 6,
                Kode = 1
            },
            new
            {
                Id = 96,
                Uraian = "Sekretaris",
                JenisAkunId = 9,
                GolonganAkunId = 6,
                Kode = 2
            },
            new
            {
                Id = 97,
                Uraian = "Bendahara",
                JenisAkunId = 9,
                GolonganAkunId = 6,
                Kode = 3
            },
            new
            {
                Id = 98,
                Uraian = "Gaji pokok",
                JenisAkunId = 9,
                GolonganAkunId = 7,
                Kode = 1
            },
            new
            {
                Id = 99,
                Uraian = "Tunjangan Keluarga",
                JenisAkunId = 9,
                GolonganAkunId = 7,
                Kode = 2
            },
            new
            {
                Id = 100,
                Uraian = "Tunjangan Beras",
                JenisAkunId = 9,
                GolonganAkunId = 7,
                Kode = 3
            },
            new
            {
                Id = 101,
                Uraian = "Tunjangan Kesehatan (BPJS, JKK)",
                JenisAkunId = 9,
                GolonganAkunId = 7,
                Kode = 4
            },
            new
            {
                Id = 102,
                Uraian = "Tunjangan Pensiun",
                JenisAkunId = 9,
                GolonganAkunId = 7,
                Kode = 5
            },
            new
            {
                Id = 103,
                Uraian = "Pengadministrasi umum dan keuangan",
                JenisAkunId = 9,
                GolonganAkunId = 8,
                Kode = 1
            },
            new
            {
                Id = 104,
                Uraian = "Koster",
                JenisAkunId = 9,
                GolonganAkunId = 8,
                Kode = 2
            },
            new
            {
                Id = 105,
                Uraian = "Sopir",
                JenisAkunId = 9,
                GolonganAkunId = 8,
                Kode = 3
            },
            new
            {
                Id = 106,
                Uraian = "Penjaga Keamanan",
                JenisAkunId = 9,
                GolonganAkunId = 8,
                Kode = 4
            },
            new
            {
                Id = 107,
                Uraian = "Teknisi",
                JenisAkunId = 9,
                GolonganAkunId = 8,
                Kode = 5
            },
            new
            {
                Id = 108,
                Uraian = "Natal",
                JenisAkunId = 9,
                GolonganAkunId = 9,
                Kode = 1
            },
            new
            {
                Id = 109,
                Uraian = "Tenaga Pelayan/Pengajar/narasumber/ahli",
                JenisAkunId = 9,
                GolonganAkunId = 10,
                Kode = 1
            },
            new
            {
                Id = 110,
                Uraian = "Tenaga Magang vicaris/dll",
                JenisAkunId = 9,
                GolonganAkunId = 10,
                Kode = 2
            },
            new
            {
                Id = 111,
                Uraian = "THR Tenaga Magang vicaris/dll",
                JenisAkunId = 9,
                GolonganAkunId = 10,
                Kode = 3
            },
            new
            {
                Id = 112,
                Uraian = "Bulan ke 13 Tenaga Magang vicaris/dll",
                JenisAkunId = 9,
                GolonganAkunId = 10,
                Kode = 4
            },
            new
            {
                Id = 113,
                Uraian = "Lembur kegiatan",
                JenisAkunId = 9,
                GolonganAkunId = 11,
                Kode = 1
            },
            new
            {
                Id = 114,
                Uraian = "Lembur Tata Usaha/sekretariat",
                JenisAkunId = 9,
                GolonganAkunId = 11,
                Kode = 2
            },
            new
            {
                Id = 115,
                Uraian = "Lain-lain Belanja Karyawan",
                JenisAkunId = 9,
                GolonganAkunId = 12,
                Kode = 1
            },
            new
            {
                Id = 116,
                Uraian = "Alat Tulis Menulis Kantor",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 1
            },
            new
            {
                Id = 117,
                Uraian = "Penggandaan, Jilid dan Cetak",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 2
            },
            new
            {
                Id = 118,
                Uraian = "Umbul-Umbul dan Bendera",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 3
            },
            new
            {
                Id = 119,
                Uraian = "Hadiah Lomba",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 4
            },
            new
            {
                Id = 120,
                Uraian = "Pembelian alat/bahan kimia dan obat-obatan",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 5
            },
            new
            {
                Id = 121,
                Uraian = "Pembelian Bahan Peraga/Buku-buku/Peraturan2/Majalah/Alkitab/Kidung Pujian/blangko surat gerejawi",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 6
            },
            new
            {
                Id = 122,
                Uraian = "Pembelian Bahan Makanan pokok",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 7
            },
            new
            {
                Id = 123,
                Uraian = "Pembelian Bahan material lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 8
            },
            new
            {
                Id = 124,
                Uraian = "Pembelian Alat dan Bahan Pembersih",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 9
            },
            new
            {
                Id = 125,
                Uraian = "Pembelian bahan/bibit tanaman (pangan, hortikultura, hias, ternak/dll)",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 10
            },
            new
            {
                Id = 126,
                Uraian = "Pembelian Bibit Ternak",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 11
            },
            new
            {
                Id = 127,
                Uraian = "Pembelian Bahan Baku Bangunan",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 12
            },
            new
            {
                Id = 128,
                Uraian = "Barang Untuk Diserahkan kepada Jemaat/Pihak Ketiga",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 13
            },
            new
            {
                Id = 129,
                Uraian = "Pembelian Barang yang Akan Diserahkan Kepada Pihak Ketiga",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 14
            },
            new
            {
                Id = 130,
                Uraian = "Pembelian Cinderamata",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 15
            },
            new
            {
                Id = 131,
                Uraian = "Sewa gedung/rumah/aula/penginapan",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 16
            },
            new
            {
                Id = 132,
                Uraian = "Sewa tenda",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 17
            },
            new
            {
                Id = 133,
                Uraian = "Sewa Meja/kursi",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 18
            },
            new
            {
                Id = 134,
                Uraian = "Sewa in focus/screen",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 19
            },
            new
            {
                Id = 135,
                Uraian = "Sewa genset/lampu",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 20
            },
            new
            {
                Id = 136,
                Uraian = "Sewa sarana mobililitas",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 21
            },
            new
            {
                Id = 137,
                Uraian = "Sewa Soundsystem",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 22
            },
            new
            {
                Id = 138,
                Uraian = "Sewa ......",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 23
            },
            new
            {
                Id = 139,
                Uraian = "Laporan Dokumentasi",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 24
            },
            new
            {
                Id = 140,
                Uraian = "Pembelian Material UMKM",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 25
            },
            new
            {
                Id = 141,
                Uraian = "Jasa Kerja/Administrasi Pihak Ketiga",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 26
            },
            new
            {
                Id = 142,
                Uraian = "Jasa Desain Interior/eksterior",
                JenisAkunId = 9,
                GolonganAkunId = 13,
                Kode = 27
            },
            new
            {
                Id = 143,
                Uraian = "Telephon/Pulsa elektronik/wifi/internet",
                JenisAkunId = 9,
                GolonganAkunId = 14,
                Kode = 1
            },
            new
            {
                Id = 144,
                Uraian = "Listrik/Pulsa listrik",
                JenisAkunId = 9,
                GolonganAkunId = 14,
                Kode = 2
            },
            new
            {
                Id = 145,
                Uraian = "Air PDAM/tanki",
                JenisAkunId = 9,
                GolonganAkunId = 14,
                Kode = 3
            },
            new
            {
                Id = 146,
                Uraian = "Majalah/Buletin/dll",
                JenisAkunId = 9,
                GolonganAkunId = 14,
                Kode = 4
            },
            new
            {
                Id = 147,
                Uraian = "Loundry",
                JenisAkunId = 9,
                GolonganAkunId = 14,
                Kode = 5
            },
            new
            {
                Id = 148,
                Uraian = "Jasa Kerja lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 14,
                Kode = 6
            },
            new
            {
                Id = 149,
                Uraian = "Tamu",
                JenisAkunId = 9,
                GolonganAkunId = 15,
                Kode = 1
            },
            new
            {
                Id = 150,
                Uraian = "Rapat",
                JenisAkunId = 9,
                GolonganAkunId = 15,
                Kode = 2
            },
            new
            {
                Id = 151,
                Uraian = "Kegiatan",
                JenisAkunId = 9,
                GolonganAkunId = 15,
                Kode = 3
            },
            new
            {
                Id = 152,
                Uraian = "Tata Usaha/sekretariat MJH",
                JenisAkunId = 9,
                GolonganAkunId = 15,
                Kode = 4
            },
            new
            {
                Id = 153,
                Uraian = "Pembelian bahan bakar minyak, olie",
                JenisAkunId = 9,
                GolonganAkunId = 16,
                Kode = 1
            },
            new
            {
                Id = 154,
                Uraian = "Pembelian suku cadang",
                JenisAkunId = 9,
                GolonganAkunId = 16,
                Kode = 2
            },
            new
            {
                Id = 155,
                Uraian = "Servis kendaraan",
                JenisAkunId = 9,
                GolonganAkunId = 16,
                Kode = 3
            },
            new
            {
                Id = 156,
                Uraian = "Pajak Kendaraan bermotor",
                JenisAkunId = 9,
                GolonganAkunId = 16,
                Kode = 4
            },
            new
            {
                Id = 157,
                Uraian = "Surat Tanda Nomor Kendaraan (STNK), BPKB",
                JenisAkunId = 9,
                GolonganAkunId = 16,
                Kode = 5
            },
            new
            {
                Id = 158,
                Uraian = "Pemeliharaan Bak Penampug air",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 1
            },
            new
            {
                Id = 159,
                Uraian = "Pemeliharaan Jalan",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 2
            },
            new
            {
                Id = 160,
                Uraian = "Pemeliharaan Jaringan air",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 3
            },
            new
            {
                Id = 161,
                Uraian = "Pemeliharaan Jaringan Listrik",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 4
            },
            new
            {
                Id = 162,
                Uraian = "Pemeliharaan Jaringan telephon/internet",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 5
            },
            new
            {
                Id = 163,
                Uraian = "Pemeliharaan Sumur Bor",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 6
            },
            new
            {
                Id = 164,
                Uraian = "Pemeliharaan Sound System",
                JenisAkunId = 9,
                GolonganAkunId = 17,
                Kode = 7
            },
            new
            {
                Id = 165,
                Uraian = "Peralatan Musik (Piano, Keybord, Gitar, Cajon, dll)",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 1
            },
            new
            {
                Id = 166,
                Uraian = "Peralatan Pelantang Suara (Mike, mixer, power, dll)",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 2
            },
            new
            {
                Id = 167,
                Uraian = "TV, Infocus, screen, Camera, Handycam, dll",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 3
            },
            new
            {
                Id = 168,
                Uraian = "Air Conditioning",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 4
            },
            new
            {
                Id = 169,
                Uraian = "Soundsystem dll (Mixer, mike, dll)",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 5
            },
            new
            {
                Id = 170,
                Uraian = "Komputer",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 6
            },
            new
            {
                Id = 171,
                Uraian = "Printer",
                JenisAkunId = 9,
                GolonganAkunId = 18,
                Kode = 7
            },
            new
            {
                Id = 172,
                Uraian = "Kursi, Bangku, sofa",
                JenisAkunId = 9,
                GolonganAkunId = 19,
                Kode = 1
            },
            new
            {
                Id = 173,
                Uraian = "Lemari",
                JenisAkunId = 9,
                GolonganAkunId = 19,
                Kode = 2
            },
            new
            {
                Id = 174,
                Uraian = "Meja",
                JenisAkunId = 9,
                GolonganAkunId = 19,
                Kode = 3
            },
            new
            {
                Id = 175,
                Uraian = "Meubeler lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 19,
                Kode = 4
            },
            new
            {
                Id = 176,
                Uraian = "Gedung Ibadat",
                JenisAkunId = 9,
                GolonganAkunId = 20,
                Kode = 1
            },
            new
            {
                Id = 177,
                Uraian = "Rumah Pastori",
                JenisAkunId = 9,
                GolonganAkunId = 20,
                Kode = 2
            },
            new
            {
                Id = 178,
                Uraian = "Bangunan Penunjang lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 20,
                Kode = 3
            },
            new
            {
                Id = 179,
                Uraian = "Hewan",
                JenisAkunId = 9,
                GolonganAkunId = 21,
                Kode = 1
            },
            new
            {
                Id = 180,
                Uraian = "Tanaman",
                JenisAkunId = 9,
                GolonganAkunId = 21,
                Kode = 2
            },
            new
            {
                Id = 181,
                Uraian = "Taman",
                JenisAkunId = 9,
                GolonganAkunId = 21,
                Kode = 3
            },
            new
            {
                Id = 183,
                Uraian = "Saprodi (pupuk, obat2an dll)",
                JenisAkunId = 9,
                GolonganAkunId = 21,
                Kode = 4
            },
            new
            {
                Id = 185,
                Uraian = "Pendeta ke Sinode",
                JenisAkunId = 9,
                GolonganAkunId = 22,
                Kode = 1
            },
            new
            {
                Id = 186,
                Uraian = "Pendeta ke Klasis",
                JenisAkunId = 9,
                GolonganAkunId = 22,
                Kode = 2
            },
            new
            {
                Id = 187,
                Uraian = "Pendeta ke Jemaat (rayon,lingkungan, BPP/UPP/kategorial/fungsional)",
                JenisAkunId = 9,
                GolonganAkunId = 22,
                Kode = 3
            },
            new
            {
                Id = 188,
                Uraian = "Karyawan/Tenaga Tata Usaha",
                JenisAkunId = 9,
                GolonganAkunId = 22,
                Kode = 4
            },
            new
            {
                Id = 189,
                Uraian = "Sinode GMIT/sinode lainnnya",
                JenisAkunId = 9,
                GolonganAkunId = 23,
                Kode = 1
            },
            new
            {
                Id = 190,
                Uraian = "Klasis",
                JenisAkunId = 9,
                GolonganAkunId = 23,
                Kode = 2
            },
            new
            {
                Id = 191,
                Uraian = "Pendeta tamu/pertukaran  mimbar",
                JenisAkunId = 9,
                GolonganAkunId = 23,
                Kode = 3
            },
            new
            {
                Id = 192,
                Uraian = "Narasumber/Pemateri/Moderator",
                JenisAkunId = 9,
                GolonganAkunId = 23,
                Kode = 4
            },
            new
            {
                Id = 193,
                Uraian = "Pengajar",
                JenisAkunId = 9,
                GolonganAkunId = 24,
                Kode = 1
            },
            new
            {
                Id = 194,
                Uraian = "PS/VG",
                JenisAkunId = 9,
                GolonganAkunId = 24,
                Kode = 2
            },
            new
            {
                Id = 195,
                Uraian = "MJH non pendeta/BPPJ/UPPJ",
                JenisAkunId = 9,
                GolonganAkunId = 24,
                Kode = 3
            },
            new
            {
                Id = 196,
                Uraian = "Pelaku Pelayanan lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 24,
                Kode = 4
            },
            new
            {
                Id = 197,
                Uraian = "Jemaat",
                JenisAkunId = 9,
                GolonganAkunId = 24,
                Kode = 5
            },
            new
            {
                Id = 198,
                Uraian = "Perjalanan Dinas Pendeta, MJH/BPP/UPP  ke luar wilayah luar provinsi",
                JenisAkunId = 9,
                GolonganAkunId = 25,
                Kode = 1
            },
            new
            {
                Id = 199,
                Uraian = "Perjalanan Dinas Pendeta, MJH/BPP/UPP  ke luar wilayah dalam provinsi",
                JenisAkunId = 9,
                GolonganAkunId = 25,
                Kode = 2
            },
            new
            {
                Id = 200,
                Uraian = "Perjalanan Dinas Pendeta, MJH/BPP/UPP ke luar wilayah dalam klasis",
                JenisAkunId = 9,
                GolonganAkunId = 25,
                Kode = 3
            },
            new
            {
                Id = 201,
                Uraian = "Perjalanan Dinas Pendeta, MJH/BPP/UPP ke luar Negeri",
                JenisAkunId = 9,
                GolonganAkunId = 25,
                Kode = 4
            },
            new
            {
                Id = 202,
                Uraian = "Komputer/PC",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 1
            },
            new
            {
                Id = 203,
                Uraian = "Laptop/notebook",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 2
            },
            new
            {
                Id = 204,
                Uraian = "Printer",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 3
            },
            new
            {
                Id = 205,
                Uraian = "Scaner",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 4
            },
            new
            {
                Id = 206,
                Uraian = "Monitor/display",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 5
            },
            new
            {
                Id = 207,
                Uraian = "Central Procesor Unit (CPU)",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 6
            },
            new
            {
                Id = 208,
                Uraian = "Unit Power Suplay (UPS/stabilizer)",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 7
            },
            new
            {
                Id = 209,
                Uraian = "Kelengkapan komputer (flask disk, mouse, keyboard, hardisk, speaker)",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 8
            },
            new
            {
                Id = 210,
                Uraian = "Stempel",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 9
            },
            new
            {
                Id = 211,
                Uraian = "Kalkulator/alat hitung",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 10
            },
            new
            {
                Id = 212,
                Uraian = "Mesin Hitung Uang",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 11
            },
            new
            {
                Id = 213,
                Uraian = "Alat Potong Kertas",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 12
            },
            new
            {
                Id = 214,
                Uraian = "Brankas",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 13
            },
            new
            {
                Id = 215,
                Uraian = "Mesin Ketik",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 14
            },
            new
            {
                Id = 216,
                Uraian = "White board",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 15
            },
            new
            {
                Id = 217,
                Uraian = "Kipas Angin",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 16
            },
            new
            {
                Id = 218,
                Uraian = "Alat Pemadam Kebakaran",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 17
            },
            new
            {
                Id = 219,
                Uraian = "Air Conditioning",
                JenisAkunId = 9,
                GolonganAkunId = 26,
                Kode = 18
            },
            new
            {
                Id = 220,
                Uraian = "Televisi/antena",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 1
            },
            new
            {
                Id = 221,
                Uraian = "Kamera",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 2
            },
            new
            {
                Id = 222,
                Uraian = "Proyektor/in focus/LCD",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 3
            },
            new
            {
                Id = 223,
                Uraian = "Screen",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 4
            },
            new
            {
                Id = 224,
                Uraian = "Handycam",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 5
            },
            new
            {
                Id = 225,
                Uraian = "Peralatan listrik (kabel, bola lampu, steker/baterai, dll)",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 6
            },
            new
            {
                Id = 226,
                Uraian = "Alat  Pengeras Suara (power, mixer, speaker, mikrofon,  kabel, dll)",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 7
            },
            new
            {
                Id = 227,
                Uraian = "Box Line Array 4 bh",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 8
            },
            new
            {
                Id = 228,
                Uraian = "DLMS Driver Rack DBX 260",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 9
            },
            new
            {
                Id = 229,
                Uraian = "Power 4 chanel",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 10
            },
            new
            {
                Id = 230,
                Uraian = "Kabel snake 32 chanel 50 meter",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 11
            },
            new
            {
                Id = 231,
                Uraian = "Kabel instlasi Salon dan spikon",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 12
            },
            new
            {
                Id = 232,
                Uraian = "Breaket 4 set live array",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 13
            },
            new
            {
                Id = 233,
                Uraian = "Salon Trimbot 4 buah",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 14
            },
            new
            {
                Id = 234,
                Uraian = "Box Salon MID Low 2 bh",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 15
            },
            new
            {
                Id = 235,
                Uraian = "Closed Circuit Television (CCTV)",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 16
            },
            new
            {
                Id = 236,
                Uraian = "Elektronik lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 27,
                Kode = 17
            },
            new
            {
                Id = 237,
                Uraian = "Alat Olah Raga Senam",
                JenisAkunId = 9,
                GolonganAkunId = 28,
                Kode = 1
            },
            new
            {
                Id = 238,
                Uraian = "Bola Voley",
                JenisAkunId = 9,
                GolonganAkunId = 28,
                Kode = 2
            },
            new
            {
                Id = 239,
                Uraian = "Bola Kaki",
                JenisAkunId = 9,
                GolonganAkunId = 28,
                Kode = 3
            },
            new
            {
                Id = 240,
                Uraian = "Alat Musik Keyboard/piano",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 1
            },
            new
            {
                Id = 241,
                Uraian = "Alat Musik Guitar/ukulele/dll",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 2
            },
            new
            {
                Id = 242,
                Uraian = "Alat Musik Cajon",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 3
            },
            new
            {
                Id = 243,
                Uraian = "Alat Musik sasando",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 4
            },
            new
            {
                Id = 244,
                Uraian = "Alat Musik tamborin",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 5
            },
            new
            {
                Id = 245,
                Uraian = "Alat Musik Gong",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 6
            },
            new
            {
                Id = 246,
                Uraian = "Tali senar/dll",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 7
            },
            new
            {
                Id = 247,
                Uraian = "Peralatan lainnya (standpart,dll)",
                JenisAkunId = 9,
                GolonganAkunId = 29,
                Kode = 8
            },
            new
            {
                Id = 248,
                Uraian = "Mimbar Pemberitaan Firman",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 1
            },
            new
            {
                Id = 249,
                Uraian = "Tangguk",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 2
            },
            new
            {
                Id = 250,
                Uraian = "Cawan/teko Perjamuan Kudus",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 3
            },
            new
            {
                Id = 251,
                Uraian = "Sloki Perjamuan Kudus",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 4
            },
            new
            {
                Id = 252,
                Uraian = "Baki Sloki Perjamuan Kudus",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 5
            },
            new
            {
                Id = 253,
                Uraian = "Tempat Lilin",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 6
            },
            new
            {
                Id = 254,
                Uraian = " Kotak/peti Persembahan",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 7
            },
            new
            {
                Id = 255,
                Uraian = "Tempat Alkitab",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 8
            },
            new
            {
                Id = 256,
                Uraian = "Palu sidang",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 9
            },
            new
            {
                Id = 257,
                Uraian = "Stola",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 10
            },
            new
            {
                Id = 258,
                Uraian = "Kain mimbar, dll",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 11
            },
            new
            {
                Id = 259,
                Uraian = "Tempak Kue perjamuan kudus",
                JenisAkunId = 9,
                GolonganAkunId = 30,
                Kode = 12
            },
            new
            {
                Id = 260,
                Uraian = "Lemari Pakaian",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 1
            },
            new
            {
                Id = 261,
                Uraian = "Meja makan",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 2
            },
            new
            {
                Id = 262,
                Uraian = "Kursi makan",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 3
            },
            new
            {
                Id = 263,
                Uraian = "Tabung gas",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 4
            },
            new
            {
                Id = 264,
                Uraian = "Kompor, kompor gas",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 5
            },
            new
            {
                Id = 265,
                Uraian = "Lemari makan",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 6
            },
            new
            {
                Id = 266,
                Uraian = "Dispenser/Magic Jar",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 7
            },
            new
            {
                Id = 267,
                Uraian = "Kulkas/refrigerator",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 8
            },
            new
            {
                Id = 268,
                Uraian = "Lemari / rak piring",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 9
            },
            new
            {
                Id = 269,
                Uraian = "Piring, gelas, sendok, mangkok, cangkir",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 10
            },
            new
            {
                Id = 270,
                Uraian = "Tempat tidur/dipan",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 11
            },
            new
            {
                Id = 271,
                Uraian = "Sofa",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 12
            },
            new
            {
                Id = 272,
                Uraian = "Televisi",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 13
            },
            new
            {
                Id = 273,
                Uraian = "Handsprayer",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 14
            },
            new
            {
                Id = 274,
                Uraian = "Air Conditioning",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 15
            },
            new
            {
                Id = 275,
                Uraian = "Peralatan mandi dll",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 16
            },
            new
            {
                Id = 276,
                Uraian = "Tandon air/bak penampung",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 17
            },
            new
            {
                Id = 277,
                Uraian = "Alat pertukangan",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 18
            },
            new
            {
                Id = 278,
                Uraian = "Seterika",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 19
            },
            new
            {
                Id = 279,
                Uraian = "Dinamo Air",
                JenisAkunId = 9,
                GolonganAkunId = 31,
                Kode = 20
            },
            new
            {
                Id = 280,
                Uraian = "Peta",
                JenisAkunId = 9,
                GolonganAkunId = 32,
                Kode = 1
            },
            new
            {
                Id = 281,
                Uraian = "Gambar/foto",
                JenisAkunId = 9,
                GolonganAkunId = 32,
                Kode = 2
            },
            new
            {
                Id = 282,
                Uraian = "Buku-buku",
                JenisAkunId = 9,
                GolonganAkunId = 32,
                Kode = 3
            },
            new
            {
                Id = 283,
                Uraian = "Mobil",
                JenisAkunId = 9,
                GolonganAkunId = 33,
                Kode = 1
            },
            new
            {
                Id = 284,
                Uraian = "Sepeda motor",
                JenisAkunId = 9,
                GolonganAkunId = 33,
                Kode = 2
            },
            new
            {
                Id = 285,
                Uraian = "Sepeda dayung",
                JenisAkunId = 9,
                GolonganAkunId = 33,
                Kode = 3
            },
            new
            {
                Id = 286,
                Uraian = "Kursi  kayu",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 1
            },
            new
            {
                Id = 287,
                Uraian = "Meja",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 2
            },
            new
            {
                Id = 288,
                Uraian = "Bangku kayu Panjang",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 3
            },
            new
            {
                Id = 289,
                Uraian = "Lemari Arsip",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 4
            },
            new
            {
                Id = 290,
                Uraian = "Sofa",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 5
            },
            new
            {
                Id = 291,
                Uraian = "Rak",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 6
            },
            new
            {
                Id = 292,
                Uraian = "Sekat tempat duduk jemaat/tempat berlutut",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 7
            },
            new
            {
                Id = 293,
                Uraian = "Meja Hitung jemaat",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 8
            },
            new
            {
                Id = 294,
                Uraian = "Alat Hitung jemaat",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 9
            },
            new
            {
                Id = 295,
                Uraian = "Kain gordin dan alat pendukungnya",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 10
            },
            new
            {
                Id = 296,
                Uraian = "Taplak/Kain Meja",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 11
            },
            new
            {
                Id = 297,
                Uraian = "lampu hias taman",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 12
            },
            new
            {
                Id = 298,
                Uraian = "Alat Pemanas/ceret, dll",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 13
            },
            new
            {
                Id = 299,
                Uraian = "Pakain seragam",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 14
            },
            new
            {
                Id = 300,
                Uraian = "Kursi Plastik",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 15
            },
            new
            {
                Id = 301,
                Uraian = "Generator",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 16
            },
            new
            {
                Id = 302,
                Uraian = "Lonceng gereja",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 17
            },
            new
            {
                Id = 303,
                Uraian = "Jam dinding",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 18
            },
            new
            {
                Id = 304,
                Uraian = "Perlengkapan keamanan",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 19
            },
            new
            {
                Id = 305,
                Uraian = "Etalase",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 20
            },
            new
            {
                Id = 306,
                Uraian = "Cermin",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 21
            },
            new
            {
                Id = 307,
                Uraian = "Countener Box",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 22
            },
            new
            {
                Id = 308,
                Uraian = "Pahatan",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 23
            },
            new
            {
                Id = 309,
                Uraian = "Lukisan",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 24
            },
            new
            {
                Id = 310,
                Uraian = "Barang tenunan/batik/dll",
                JenisAkunId = 9,
                GolonganAkunId = 34,
                Kode = 25
            },
            new
            {
                Id = 311,
                Uraian = "Sapi",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 1
            },
            new
            {
                Id = 312,
                Uraian = "Kerbau",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 2
            },
            new
            {
                Id = 313,
                Uraian = "Kuda",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 3
            },
            new
            {
                Id = 314,
                Uraian = "Kambing",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 4
            },
            new
            {
                Id = 315,
                Uraian = "Babi",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 5
            },
            new
            {
                Id = 316,
                Uraian = "Ayam",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 6
            },
            new
            {
                Id = 317,
                Uraian = "Itik/bebek",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 7
            },
            new
            {
                Id = 318,
                Uraian = "Ikan",
                JenisAkunId = 9,
                GolonganAkunId = 35,
                Kode = 8
            },
            new
            {
                Id = 319,
                Uraian = "Kelapa",
                JenisAkunId = 9,
                GolonganAkunId = 36,
                Kode = 1
            },
            new
            {
                Id = 320,
                Uraian = "Kemiri",
                JenisAkunId = 9,
                GolonganAkunId = 36,
                Kode = 2
            },
            new
            {
                Id = 321,
                Uraian = "Padi",
                JenisAkunId = 9,
                GolonganAkunId = 36,
                Kode = 3
            },
            new
            {
                Id = 322,
                Uraian = "Pinang",
                JenisAkunId = 9,
                GolonganAkunId = 36,
                Kode = 4
            },
            new
            {
                Id = 323,
                Uraian = "dst",
                JenisAkunId = 9,
                GolonganAkunId = 36,
                Kode = 5
            },
            new
            {
                Id = 324,
                Uraian = "Tanaman Hortikultura (sayur, buah2an, jagung kacang2an)",
                JenisAkunId = 9,
                GolonganAkunId = 36,
                Kode = 6
            },
            new
            {
                Id = 325,
                Uraian = "Tanah",
                JenisAkunId = 9,
                GolonganAkunId = 37,
                Kode = 1
            },
            new
            {
                Id = 326,
                Uraian = "Sertifikasi tanah",
                JenisAkunId = 9,
                GolonganAkunId = 37,
                Kode = 2
            },
            new
            {
                Id = 327,
                Uraian = "Gedung Ibadat",
                JenisAkunId = 9,
                GolonganAkunId = 38,
                Kode = 1
            },
            new
            {
                Id = 328,
                Uraian = "Rumah Pastori",
                JenisAkunId = 9,
                GolonganAkunId = 38,
                Kode = 2
            },
            new
            {
                Id = 329,
                Uraian = "Bangunan lainnya",
                JenisAkunId = 9,
                GolonganAkunId = 38,
                Kode = 3
            },
            new
            {
                Id = 330,
                Uraian = "Sumur Bor",
                JenisAkunId = 9,
                GolonganAkunId = 39,
                Kode = 1
            },
            new
            {
                Id = 331,
                Uraian = "Bak Penampung/fiber/dll",
                JenisAkunId = 9,
                GolonganAkunId = 39,
                Kode = 2
            },
            new
            {
                Id = 332,
                Uraian = "Instalasi Air",
                JenisAkunId = 9,
                GolonganAkunId = 39,
                Kode = 3
            },
            new
            {
                Id = 333,
                Uraian = "Instalasi listrik",
                JenisAkunId = 9,
                GolonganAkunId = 39,
                Kode = 4
            },
            new
            {
                Id = 334,
                Uraian = "Instalasi telephon/wifi",
                JenisAkunId = 9,
                GolonganAkunId = 39,
                Kode = 5
            },
            new
            {
                Id = 335,
                Uraian = "Instalasi Soundsystem",
                JenisAkunId = 9,
                GolonganAkunId = 39,
                Kode = 6
            },
            new
            {
                Id = 336,
                Uraian = "Alokasi dana untuk Majelis Sinode (10%)",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 1
            },
            new
            {
                Id = 337,
                Uraian = "Alokasi dana Kebersamaan untuk Klasis",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 2
            },
            new
            {
                Id = 338,
                Uraian = "Insidentil Jemaat utk kegiatan sinode, klasis, unit kategorial/fungsional",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 3
            },
            new
            {
                Id = 339,
                Uraian = "Amplop Pensiun",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 4
            },
            new
            {
                Id = 340,
                Uraian = "Pendidikan 2 %",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 5
            },
            new
            {
                Id = 341,
                Uraian = "Akokasi dana Surplus",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 6
            },
            new
            {
                Id = 342,
                Uraian = "Alokasi dana ke Teritori 2 KKKT",
                JenisAkunId = 10,
                GolonganAkunId = 41,
                Kode = 7
            },
            new
            {
                Id = 343,
                Uraian = "Beasiswa",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 1
            },
            new
            {
                Id = 344,
                Uraian = "Bingkisan natal/kasih/dll",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 2
            },
            new
            {
                Id = 345,
                Uraian = "Perbaiki rumah",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 3
            },
            new
            {
                Id = 346,
                Uraian = "Pelayanan Kasih bagi Lansia",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 4
            },
            new
            {
                Id = 347,
                Uraian = "Jemaat Kurang mampu",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 5
            },
            new
            {
                Id = 348,
                Uraian = "Orang tua asuh",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 6
            },
            new
            {
                Id = 349,
                Uraian = "Pelayanan Kasih bagi Presbiter Non Pendeta",
                JenisAkunId = 11,
                GolonganAkunId = 42,
                Kode = 7
            },
            new
            {
                Id = 350,
                Uraian = "Diakonia orang Sakit ",
                JenisAkunId = 11,
                GolonganAkunId = 43,
                Kode = 1
            },
            new
            {
                Id = 351,
                Uraian = "Diakonia duka Jemaat, Orang tua Majelis, Kel Inti MJEL, dan MJEL",
                JenisAkunId = 11,
                GolonganAkunId = 43,
                Kode = 2
            },
            new
            {
                Id = 352,
                Uraian = "Diakonia Duka luar JEL yang di layani di Keluarga JEL",
                JenisAkunId = 11,
                GolonganAkunId = 43,
                Kode = 3
            },
            new
            {
                Id = 353,
                Uraian = "Diakonia Duka luar Jemaat",
                JenisAkunId = 11,
                GolonganAkunId = 43,
                Kode = 4
            },
            new
            {
                Id = 354,
                Uraian = "Diakonia Stunting",
                JenisAkunId = 11,
                GolonganAkunId = 43,
                Kode = 5
            },
            new
            {
                Id = 355,
                Uraian = "Pengembangan Usaha Produktif UMKM",
                JenisAkunId = 11,
                GolonganAkunId = 44,
                Kode = 1
            },
            new
            {
                Id = 356,
                Uraian = "Bencana Alam dan Non Alam dalam Jemaat",
                JenisAkunId = 11,
                GolonganAkunId = 44,
                Kode = 2
            },
            new
            {
                Id = 357,
                Uraian = "Bencana Alam dan Non Alam Luar Jemaat",
                JenisAkunId = 11,
                GolonganAkunId = 44,
                Kode = 3
            },
            new
            {
                Id = 358,
                Uraian = "Diakonia Pemulihan/Rehabilitasi",
                JenisAkunId = 11,
                GolonganAkunId = 44,
                Kode = 4
            },
            new
            {
                Id = 359,
                Uraian = "Diakonia bagi Gereja lain",
                JenisAkunId = 11,
                GolonganAkunId = 44,
                Kode = 5
            },
            new
            {
                Id = 360,
                Uraian = "Antar Jemaat",
                JenisAkunId = 12,
                GolonganAkunId = 45,
                Kode = 1
            },
            new
            {
                Id = 361,
                Uraian = "Kegiatan Majelis Sinode dan Klasis",
                JenisAkunId = 12,
                GolonganAkunId = 45,
                Kode = 2
            },
            new
            {
                Id = 363,
                Uraian = "Bencana Alam dan Non Alam Luar Jemaat",
                JenisAkunId = 12,
                GolonganAkunId = 45,
                Kode = 3
            },
            new
            {
                Id = 364,
                Uraian = "Lain2 Bantuan",
                JenisAkunId = 12,
                GolonganAkunId = 45,
                Kode = 4
            },
            new
            {
                Id = 365,
                Uraian = "Penyertaan Modal Jemaat kepada Badan Usaha Milik GMIT",
                JenisAkunId = 13,
                GolonganAkunId = 46,
                Kode = 1
            },
            new
            {
                Id = 366,
                Uraian = "Penyertaan Modal Jemaat kepada Pihak Ketiga",
                JenisAkunId = 13,
                GolonganAkunId = 46,
                Kode = 2
            },
            new
            {
                Id = 367,
                Uraian = "Lain-lain Penyertaan Modal",
                JenisAkunId = 13,
                GolonganAkunId = 46,
                Kode = 3
            },
            new
            {
                Id = 368,
                Uraian = "Utang Perhitungan ke Sinode",
                JenisAkunId = 14,
                GolonganAkunId = 47,
                Kode = 1
            },
            new
            {
                Id = 369,
                Uraian = "Utang Perhitungan ke Klasis",
                JenisAkunId = 14,
                GolonganAkunId = 47,
                Kode = 2
            },
            new
            {
                Id = 370,
                Uraian = "Utang Belanja BPPJ / UPPJ",
                JenisAkunId = 14,
                GolonganAkunId = 47,
                Kode = 3
            },
            new
            {
                Id = 371,
                Uraian = "Utang Jangka Pendek Lainnya",
                JenisAkunId = 14,
                GolonganAkunId = 47,
                Kode = 4
            },
            new
            {
                Id = 372,
                Uraian = "Utang ke lembaga keuangan Bank",
                JenisAkunId = 15,
                GolonganAkunId = 48,
                Kode = 1
            },
            new
            {
                Id = 373,
                Uraian = "Utang ke Lembaga Keuangan Bukan Bank",
                JenisAkunId = 15,
                GolonganAkunId = 48,
                Kode = 2
            },
            new
            {
                Id = 374,
                Uraian = "Tanah",
                JenisAkunId = 16,
                GolonganAkunId = 49,
                Kode = 1
            },
            new
            {
                Id = 375,
                Uraian = "Bangunan",
                JenisAkunId = 16,
                GolonganAkunId = 49,
                Kode = 2
            },
            new
            {
                Id = 376,
                Uraian = "Sarana transportasi",
                JenisAkunId = 16,
                GolonganAkunId = 49,
                Kode = 3
            },
            new
            {
                Id = 377,
                Uraian = "Kegiatan Pelayanan",
                JenisAkunId = 16,
                GolonganAkunId = 49,
                Kode = 4
            },
            new
            {
                Id = 378,
                Uraian = "Kegiatan Pelayanan lainnya",
                JenisAkunId = 16,
                GolonganAkunId = 49,
                Kode = 5
            },
            new
            {
                Id = 379,
                Uraian = "Biaya Tak Tersangka",
                JenisAkunId = 17,
                GolonganAkunId = 50,
                Kode = 1
            },
            new
            {
                Id = 380,
                Uraian = "BPP BPPPJ",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 1
            },
            new
            {
                Id = 381,
                Uraian = "BPP BPPPPJ",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 2
            },
            new
            {
                Id = 382,
                Uraian = "BPP Pendidikan",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 3
            },
            new
            {
                Id = 383,
                Uraian = "BPP Diakonat",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 4
            },
            new
            {
                Id = 384,
                Uraian = "BPP / Panitia HRG",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 5
            },
            new
            {
                Id = 385,
                Uraian = "BPP Pembangunan",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 6
            },
            new
            {
                Id = 386,
                Uraian = "UPP Kaum Bapak",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 7
            },
            new
            {
                Id = 387,
                Uraian = "UPP Kaum Perempuan",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 8
            },
            new
            {
                Id = 388,
                Uraian = "UPP Pemuda",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 9
            },
            new
            {
                Id = 389,
                Uraian = "UPP PAR",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 10
            },
            new
            {
                Id = 390,
                Uraian = "UPP Persekutuan Doa",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 11
            },
            new
            {
                Id = 391,
                Uraian = "UPP Lansia",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 12
            },
            new
            {
                Id = 392,
                Uraian = "UPP Katekisasi",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 13
            },
            new
            {
                Id = 393,
                Uraian = "UPP Limuger",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 14
            },
            new
            {
                Id = 394,
                Uraian = "UPP Perbendaharaan",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 15
            },
            new
            {
                Id = 395,
                Uraian = "UPP Tata Usaha",
                JenisAkunId = 18,
                GolonganAkunId = 51,
                Kode = 16
            },
            new
            {
                Id = 396,
                Uraian = "Pajak Bank NTT (Pos Rutin)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 1
            },
            new
            {
                Id = 397,
                Uraian = "Biaya Administrasi Bank NTT (Pos Rutin)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 2
            },
            new
            {
                Id = 398,
                Uraian = "Pajak Bank TLM (Pos Rutin)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 3
            },
            new
            {
                Id = 399,
                Uraian = "Biaya Administrasi Bank TLM (Pos Rutin)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 4
            },
            new
            {
                Id = 400,
                Uraian = "Pajak Bank NTT (Pos Pembangunan)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 5
            },
            new
            {
                Id = 401,
                Uraian = "Biaya Administrasi Bank NTT (Pos Pembangunan)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 6
            },
            new
            {
                Id = 402,
                Uraian = "Pajak Bank NTT (Pos Cadangan)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 7
            },
            new
            {
                Id = 403,
                Uraian = "Biaya Administrasi  Bank NTT (Pos Cadangan)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 8
            },
            new
            {
                Id = 404,
                Uraian = "Pajak Bank TLM (Pos Cadangan)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 9
            },
            new
            {
                Id = 405,
                Uraian = "Biaya Administrasi Bank TLM (Pos Cadangan)",
                JenisAkunId = 19,
                GolonganAkunId = 52,
                Kode = 10
            },
            new
            {
                Id = 406,
                Uraian = "Pemberian Pinjaman",
                JenisAkunId = 19,
                GolonganAkunId = 53,
                Kode = 1
            },
            new
            {
                Id = 407,
                Uraian = "Pebentukan Dana Cadangan",
                JenisAkunId = 19,
                GolonganAkunId = 53,
                Kode = 2
            },
            new
            {
                Id = 408,
                Uraian = "Pembayaran Pokok Hutang",
                JenisAkunId = 19,
                GolonganAkunId = 53,
                Kode = 3
            },
            new
            {
                Id = 409,
                Uraian = "Kegiatan Klasis/Sinode",
                JenisAkunId = 19,
                GolonganAkunId = 53,
                Kode = 4
            },
            new
            {
                Id = 410,
                Uraian = "Penyertaan Modal (Investasi)",
                JenisAkunId = 19,
                GolonganAkunId = 53,
                Kode = 5
            },
            new
            {
                Id = 411,
                Uraian = "Utang Perhitungan ke Sinode",
                JenisAkunId = 20,
                GolonganAkunId = 54,
                Kode = 1
            },
            new
            {
                Id = 412,
                Uraian = "Utang Perhitungan ke Klasis",
                JenisAkunId = 20,
                GolonganAkunId = 54,
                Kode = 2
            },
            new
            {
                Id = 413,
                Uraian = "Utang Belanja BPPJ/UPPJ",
                JenisAkunId = 20,
                GolonganAkunId = 54,
                Kode = 3
            },
            new
            {
                Id = 414,
                Uraian = "Utang Jangka Pendek Lainnya",
                JenisAkunId = 20,
                GolonganAkunId = 54,
                Kode = 4
            },
            new
            {
                Id = 415,
                Uraian = "Utang ke lembaga keuangan Bank",
                JenisAkunId = 20,
                GolonganAkunId = 55,
                Kode = 1
            },
            new
            {
                Id = 416,
                Uraian = "Utang ke Lembaga Keuangan Bukan Bank",
                JenisAkunId = 20,
                GolonganAkunId = 55,
                Kode = 2
            }
        };

        modelBuilder.Entity<Akun>().HasData(
            daftarAkunDenganKelompokAkun.Select(a =>
            {
                if (a.JenisAkunId <= 7 && a.JenisAkunId >= 1)
                    return new { a.Id, a.Uraian, a.Kode, a.JenisAkunId, a.KelompokAkunId, Tahun = tahun, SetoranSinode = (bool?)true };
                else
                    return new { a.Id, a.Uraian, a.Kode, a.JenisAkunId, a.KelompokAkunId, Tahun = tahun, SetoranSinode = (bool?)null };
            }).ToArray());

        modelBuilder.Entity<Akun>().HasData(
            daftarAkunDenganGolonganAkun.Select(a =>
            {
                if (a.JenisAkunId <= 7 && a.JenisAkunId >= 1)
                    return new { a.Id, a.Uraian, a.Kode, a.JenisAkunId, a.GolonganAkunId, Tahun = tahun, SetoranSinode = (bool?)true };
                else
                    return new { a.Id, a.Uraian, a.Kode, a.JenisAkunId, a.GolonganAkunId, Tahun = tahun, SetoranSinode = (bool?)null };
            }).ToArray());
        #endregion

        #region RAPBJ
        modelBuilder.Entity<RAPBJ>().HasData(new RAPBJ { Tahun = tahun });
        #endregion

        #region DetailRAPBJ
        modelBuilder.Entity<DetailRAPBJ>().HasData(
            daftarAkunDenganKelompokAkun.Select(a => new DetailRAPBJ
            {
                TahunRAPBJ = tahun,
                KodeAkun = a.Id,
                Volume = 1,
                Satuan = "kali",
                HargaSatuan = 10000d
            })
        );

        modelBuilder.Entity<DetailRAPBJ>().HasData(
            daftarAkunDenganGolonganAkun.Select(a => new DetailRAPBJ
            {
                TahunRAPBJ = tahun,
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
                Saldo = 4_693_500d,
                TanggalDitambahkan = new DateTime(2024, 5, 4),
                TanggalDiubah = new DateTime(2024, 5, 4)
            }
        );
        #endregion

        #region Transaksi
        var daftarTransaksi = new[]
        {
            
            new
            {
                Id = 10,
                Uraian = "Kolekte",
                Jumlah = 930000d,
                SaldoKas = 6961500d,
                Tanggal = new DateTime(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 51,
                KasId = 1,
            },
            new
            {
                Id = 11,
                Uraian = "Terima nazar Tanpa Nama 1",
                Jumlah = 5000d,
                SaldoKas = 6966500d,
                Tanggal = new DateTime(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 16,
                KasId = 1,
            },
            new
            {
                Id = 12,
                Uraian = "Terima nazar Tanpa Nama 2",
                Jumlah = 10000d,
                SaldoKas = 6976500d,
                Tanggal = new DateTime(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 16,
                KasId = 1,
            },
            new
            {
                Id = 13,
                Uraian = "Terima nazar Tanpa Nama 3",
                Jumlah = 100000d,
                SaldoKas = 7076500d,
                Tanggal = new DateTime(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 18,
                KasId = 1,
            },
            new
            {
                Id = 14,
                Uraian = "Terima nazar Tanpa Nama 4",
                Jumlah = 10000d,
                SaldoKas = 7086500d,
                Tanggal = new DateTime(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 19,
                KasId = 1,
            },
            new
             {
                 Id = 15,
                 Uraian = "Terima nazar Tanpa Nama 5",
                 Jumlah = 5000d,
                 SaldoKas = 7091500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 16,
                 KasId = 1,
             },
            new
             {
                 Id = 16,
                 Uraian = "Terima nazar Tanpa Nama 6",
                 Jumlah = 20000d,
                 SaldoKas = 7111500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 17,
                 KasId = 1,
             },
            new
             {
                 Id = 17,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 1",
                 Jumlah = 30000d,
                 SaldoKas = 7141500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 18,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 2",
                 Jumlah = 50000d,
                 SaldoKas = 7191500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 19,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 3",
                 Jumlah = 10000d,
                 SaldoKas = 7201500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 20,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 4",
                 Jumlah = 9000d,
                 SaldoKas = 7210500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 21,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 5",
                 Jumlah = 5000d,
                 SaldoKas = 7215500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 22,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 6",
                 Jumlah = 10000d,
                 SaldoKas = 7225500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 23,
                 Uraian = "Terima perpuluhan tidak tetap Tanpa Nama 7",
                 Jumlah = 50000d,
                 SaldoKas = 7275500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 21,
                 KasId = 1,
             },
            new
             {
                 Id = 24,
                 Uraian = "Terima persembahan syukur Tanpa Nama 1",
                 Jumlah = 10000d,
                 SaldoKas = 7285500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 25,
                 Uraian = "Terima persembahan syukur Tanpa Nama 2",
                 Jumlah = 5000d,
                 SaldoKas = 7290500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 26,
                 Uraian = "Terima persembahan syukur Tanpa Nama 3",
                 Jumlah = 10000d,
                 SaldoKas = 7300500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 27,
                 Uraian = "Terima persembahan syukur Tanpa Nama 4",
                 Jumlah = 50000d,
                 SaldoKas = 7350500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 28,
                 Uraian = "Terima persembahan syukur Tanpa Nama 5",
                 Jumlah = 50000d,
                 SaldoKas = 7400500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 29,
                 Uraian = "Terima persembahan syukur Tanpa Nama 6",
                 Jumlah = 100000d,
                 SaldoKas = 7500500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 30,
                 Uraian = "Terima persembahan syukur Tanpa Nama 7",
                 Jumlah = 10000d,
                 SaldoKas = 7510500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 31,
                 Uraian = "Terima persembahan syukur Tanpa Nama 8",
                 Jumlah = 10000d,
                 SaldoKas = 7520500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 32,
                 Uraian = "Terima persembahan syukur Tanpa Nama 9",
                 Jumlah = 10000d,
                 SaldoKas = 7530500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 33,
                 Uraian = "Terima persembahan syukur Tanpa Nama 10",
                 Jumlah = 10000d,
                 SaldoKas = 7540500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 22,
                 KasId = 1,
             },
            new
             {
                 Id = 34,
                 Uraian = "Bpk. Oktovianus Metboki Rayon 5",
                 Jumlah = 50000d,
                 SaldoKas = 7590500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 35,
                 Uraian = "Oma. Elisabeth Tualaka Rayon 7",
                 Jumlah = 77000d,
                 SaldoKas = 7667500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 36,
                 Uraian = "Kel AS Rayon 2",
                 Jumlah = 72000d,
                 SaldoKas = 7739500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 37,
                 Uraian = "Oma. Aranci Suek Rayon 4",
                 Jumlah = 10000d,
                 SaldoKas = 7749500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 38,
                 Uraian = " Bpk. Dominggus Kole Rayon 7",
                 Jumlah = 50000d,
                 SaldoKas = 7799500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 39,
                 Uraian = "Kel. IB Rayon 4",
                 Jumlah = 300000d,
                 SaldoKas = 8099500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 40,
                 Uraian = "Oma. Naomi A. Henuk Rayon 2",
                 Jumlah = 50000d,
                 SaldoKas = 8149500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 41,
                 Uraian = "Tanpa nama Rayon 7",
                 Jumlah = 100000d,
                 SaldoKas = 8249500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 42,
                 Uraian = "Bpk. Marcus Baria Rayon 7",
                 Jumlah = 69000d,
                 SaldoKas = 8318500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 43,
                 Uraian = "Oma. Annie M. Malonda Rayon 7",
                 Jumlah = 150000d,
                 SaldoKas = 8468500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 44,
                 Uraian = "Bpk. Mikhael Nenotek Rayon 5",
                 Jumlah = 50000d,
                 SaldoKas = 8518500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 45,
                 Uraian = "Tanpa nama Rayon 7",
                 Jumlah = 50000d,
                 SaldoKas = 8568500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 46,
                 Uraian = "Tanpa nama Rayon 7",
                 Jumlah = 50000d,
                 SaldoKas = 8618500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 47,
                 Uraian = "Bpk. A.J. Sinaga Rayon 2",
                 Jumlah = 30000d,
                 SaldoKas = 8648500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 48,
                 Uraian = "Bpk. Melkisedek Kasse Rayon 4",
                 Jumlah = 10000d,
                 SaldoKas = 8658500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 49,
                 Uraian = "Bpk. Nur M. Tasrap Rayon 5",
                 Jumlah = 57000d,
                 SaldoKas = 8715500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 50,
                 Uraian = "Bpk. Marthen Patipellohy Rayon 5",
                 Jumlah = 16000d,
                 SaldoKas = 8731500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 51,
                 Uraian = "Bpk. Benyamin Sua Rayon 3",
                 Jumlah = 60000d,
                 SaldoKas = 8791500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 52,
                 Uraian = "Tanpa Nama Rayon 7",
                 Jumlah = 100000d,
                 SaldoKas = 8891500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 53,
                 Uraian = "Bpk. Daud Ludji Rayon 4",
                 Jumlah = 50000d,
                 SaldoKas = 8941500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 54,
                 Uraian = "Tanpa Nama 1",
                 Jumlah = 10000d,
                 SaldoKas = 8951500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 55,
                 Uraian = "Tanpa Nama 2",
                 Jumlah = 111000d,
                 SaldoKas = 9062500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 56,
                 Uraian = "Tanpa Nama 3",
                 Jumlah = 10000d,
                 SaldoKas = 9072500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 57,
                 Uraian = "Tanpa Nama 4",
                 Jumlah = 10000d,
                 SaldoKas = 9082500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 58,
                 Uraian = "Tanpa Nama 5",
                 Jumlah = 10000d,
                 SaldoKas = 9092500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 59,
                 Uraian = "Tanpa Nama 6",
                 Jumlah = 20000d,
                 SaldoKas = 9112500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 60,
                 Uraian = "Tanpa Nama 7",
                 Jumlah = 2000d,
                 SaldoKas = 9114500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 61,
                 Uraian = "Tanpa Nama 8",
                 Jumlah = 64000d,
                 SaldoKas = 9178500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 62,
                 Uraian = "Tanpa Nama 9",
                 Jumlah = 10000d,
                 SaldoKas = 9188500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 63,
                 Uraian = "Tanpa Nama 10",
                 Jumlah = 10000d,
                 SaldoKas = 9198500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 64,
                 Uraian = "Tanpa Nama 11",
                 Jumlah = 10000d,
                 SaldoKas = 9208500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 50,
                 KasId = 1,
             },
            new
             {
                 Id = 65,
                 Uraian = "Tanpa Nama",
                 Jumlah = 100000d,
                 SaldoKas = 9308500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 44,
                 KasId = 1,
             },
            new
             {
                 Id = 66,
                 Uraian = "Bpk. A.J. Sinaga Rayon 2",
                 Jumlah = 30000d,
                 SaldoKas = 9338500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 44,
                 KasId = 1,
             },
            new
             {
                 Id = 67,
                 Uraian = "Ibu. Febei Nuban Rayon 7",
                 Jumlah = 25000d,
                 SaldoKas = 9363500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 44,
                 KasId = 1,
             },
            new
             {
                 Id = 68,
                 Uraian = "Bpk. Kristian Walu Logo Rayon 1",
                 Jumlah = 100000d,
                 SaldoKas = 9463500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 44,
                 KasId = 1,
             },
            new
             {
                 Id = 69,
                 Uraian = "Bpk. Max Warruw Rayon 7",
                 Jumlah = 250000d,
                 SaldoKas = 9713500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 44,
                 KasId = 1,
             },
            new
             {
                 Id = 70,
                 Uraian = "Terima persembahan syukur ULTAH ke-79",
                 Jumlah = 100000d,
                 SaldoKas = 9813500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 14,
                 KasId = 1,
             },
            new
             {
                 Id = 71,
                 Uraian = "Terima kolekte ibadah keluarga dirumah Bpk. Mexi Bekabel Rayon 4",
                 Jumlah = 400000d,
                 SaldoKas = 10213500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 1),
                 TanggalDiubah = new DateTime(2024, 1, 1),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 44,
                 KasId = 1,
             },
            new
            {
                Id = 1,
                Uraian = "Diakonia Duka Alm. An. Ezra Sioh Rayon 7",
                Jumlah = 500000d,
                SaldoKas = 9713500d,
                Tanggal = new DateTime(2024, 1, 1),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 171,
                KasId = 1
            },
            new
            {
                Id = 2,
                Uraian = "Foto copy 600 lembar liturgi ibadah pemakaman @Rp. 250,-",
                Jumlah = 150000d,
                SaldoKas = 9563500d,
                Tanggal = new DateTime(2024, 1, 2),
                TanggalDitambahkan = new DateTime(2024, 1, 1),
                TanggalDiubah = new DateTime(2024, 1, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 101,
                KasId = 1
            },
            new
             {
                 Id = 72,
                 Uraian = "Terima kolekte ibadah lepas kabung di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th",
                 Jumlah = 791000d,
                 SaldoKas = 10354500d,
                 Tanggal = new DateTime(2024, 1, 1),
                 TanggalDitambahkan = new DateTime(2024, 1, 3),
                 TanggalDiubah = new DateTime(2024, 1, 3),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 10,
                 KasId = 1,
             },
            new
             {
                 Id = 73,
                 Uraian = "Terima kolekte ibadah penggembalaan Majelis Jemaat Periode 2024-2027 diGereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th",
                 Jumlah = 643000d,
                 SaldoKas = 10997500d,
                 Tanggal = new DateTime(2024, 1, 3),
                 TanggalDitambahkan = new DateTime(2024, 1, 3),
                 TanggalDiubah = new DateTime(2024, 1, 3),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 81,
                 KasId = 1,
             },
            new
             {
                 Id = 74,
                 Uraian = "Terima kolekte ibadah Syukur di Kel. Sioh Rayon 7, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th",
                 Jumlah = 329000d,
                 SaldoKas = 11326500d,
                 Tanggal = new DateTime(2024, 1, 5),
                 TanggalDitambahkan = new DateTime(2024, 1, 5),
                 TanggalDiubah = new DateTime(2024, 1, 5),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Penerimaan,
                 AkunId = 14,
                 KasId = 1,
             },
            new
             {
                 Id = 3,
                 Uraian = "Beli 1 pcs MCB Broco 6A",
                 Jumlah = 40000d,
                 SaldoKas = 11286500d,
                 Tanggal = new DateTime(2024, 1, 5),
                 TanggalDitambahkan = new DateTime(2024, 1, 5),
                 TanggalDiubah = new DateTime(2024, 1, 5),
                 FileBukti = new Uri("https://file/1"),
                 Jenis = Jenis.Belanja,
                 AkunId = 109,
                 KasId = 1,
             },
            new
            {
                Id = 4,
                Uraian = "Beli 1 pcs Box MCB",
                Jumlah = 5000d,
                SaldoKas = 11281500d,
                Tanggal = new DateTime(2024, 1, 5),
                TanggalDitambahkan = new DateTime(2024, 1, 5),
                TanggalDiubah = new DateTime(2024, 1, 5),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 109,
                KasId = 1,
            },
            new
            {
                Id = 5,
                Uraian = "Beli 4 kg gula pasir timbang @Rp. 17.900,-",
                Jumlah = 71600d,
                SaldoKas = 11209900d,
                Tanggal = new DateTime(2024, 1, 6),
                TanggalDitambahkan = new DateTime(2024, 1, 6),
                TanggalDiubah = new DateTime(2024, 1, 6),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 100,
                KasId = 1,
            },
            new
            {
                Id = 6,
                Uraian = "Beli 1 pcs teh sariwangi (50P)",
                Jumlah = 12500d,
                SaldoKas = 11197400d,
                Tanggal = new DateTime(2024, 1, 6),
                TanggalDitambahkan = new DateTime(2024, 1, 6),
                TanggalDiubah = new DateTime(2024, 1, 6),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 100,
                KasId = 1,
            },
            new
            {
                Id = 7,
                Uraian = "Beli 1 pcs tugu buaya spesial (1 kg)",
                Jumlah = 59900d,
                SaldoKas = 11137500d,
                Tanggal = new DateTime(2024, 1, 6),
                TanggalDitambahkan = new DateTime(2024, 1, 6),
                TanggalDiubah = new DateTime(2024, 1, 6),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 100,
                KasId = 1,
            },
            new
            {
                Id = 8,
                Uraian = "Beli 30 potong kue @Rp. 1.000,-",
                Jumlah = 30000d,
                SaldoKas = 11107500d,
                Tanggal = new DateTime(2024, 1, 6),
                TanggalDitambahkan = new DateTime(2024, 1, 6),
                TanggalDiubah = new DateTime(2024, 1, 6),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 100,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Foto copy 1.020 lembar liturgi dan warta jemaat @Rp. 250,-",
                Jumlah = 255000d,
                SaldoKas = 10852500d,
                Tanggal = new DateTime(2024, 1, 6),
                TanggalDitambahkan = new DateTime(2024, 1, 6),
                TanggalDiubah = new DateTime(2024, 1, 6),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 101,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah rumah tangga dirumah Bpk. Nur M. Tasrap Rayon 5, dipimpin oleh Pnt. Jeri K. Patipellohy-Akal",
                Jumlah = 177_000d,
                SaldoKas = 11_029_500d ,
                Tanggal = new DateTime(2024, 2, 1),
                TanggalDitambahkan = new DateTime(2024, 2, 1),
                TanggalDiubah = new DateTime(2024, 2, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 69,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah rumah tangga dirumah Bpk. Devilpus Subu Rayon 6, dipimpin oleh Dkn. Lely Nepafay",
                Jumlah = 59_000d,
                SaldoKas = 11_088_500d ,
                Tanggal = new DateTime(2024, 2, 1),
                TanggalDitambahkan = new DateTime(2024, 2, 1),
                TanggalDiubah = new DateTime(2024, 2, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 70,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah rumah tangga dirumah Bpk. Derven G. Foenay Rayon 2, dipimpin oleh Pnt. Djibrael Nawa",
                Jumlah = 104_000d,
                SaldoKas = 11_192_500d ,
                Tanggal = new DateTime(2024, 2, 1),
                TanggalDitambahkan = new DateTime(2024, 2, 1),
                TanggalDiubah = new DateTime(2024, 2, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 65,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah rumah tangga dirumah Ibu. Erna Nggolut Rayon 3, dipimpin oleh Cavic Victor I. Hairmo, S.Th",
                Jumlah = 303_000d,
                SaldoKas = 11_495_500d ,
                Tanggal = new DateTime(2024, 2, 1),
                TanggalDitambahkan = new DateTime(2024, 2, 1),
                TanggalDiubah = new DateTime(2024, 2, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 66,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah katekasasi reguler di Gereja JLET, dipimpin oleh Pjr. Lusia L. Kassir-Kollis",
                Jumlah = 17_500d,
                SaldoKas = 11_513_000d ,
                Tanggal = new DateTime(2024, 2, 1),
                TanggalDitambahkan = new DateTime(2024, 2, 1),
                TanggalDiubah = new DateTime(2024, 2, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 77,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "1 pcs Kantong Kresek Kharisma Besar",
                Jumlah = 500d,
                SaldoKas = 11_512_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 181,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "3 pcs Rumput PL-923 @Rp. 20.000,-",
                Jumlah = 60_000d,
                SaldoKas = 11_452_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 181,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "3 pcs Bunga XH-24628 @Rp. 24.000,-",
                Jumlah = 72_000d,
                SaldoKas = 11_380_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 181,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "2 pcs Rumput 2509 @Rp. 17.000,-",
                Jumlah = 34_000d,
                SaldoKas = 11_346_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 181,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "1 pcs Rumput PL940",
                Jumlah = 18_000d,
                SaldoKas = 11_328_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 181,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah katekasasi reguler di Gereja JLET, dipimpin oleh Pjr. Lusia L. Kassir-Kollis",
                Jumlah = 12_000d,
                SaldoKas = 11_340_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 77,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah penggembalaan perhadapan Koster, UPP dan BP Kategorial, Fungsional dan Profesional JLET periode pelayanan 2024-2027 di Gereja JLET, dipimpin oleh Pdt. Ishak B. Batmalo, S.Th",
                Jumlah = 138_000d,
                SaldoKas = 11_478_500d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 81,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah rumah tangga dirumah Bpk. Yeskiel Humau Rayon 2, dipimpin oleh Dkn. Guntur S. Karlau",
                Jumlah = 288_500d,
                SaldoKas = 11_767_000d ,
                Tanggal = new DateTime(2024, 3, 1),
                TanggalDitambahkan = new DateTime(2024, 3, 1),
                TanggalDiubah = new DateTime(2024, 3, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 65,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Kolekte Ibadah Syukur Paskah",
                Jumlah = 469_500d,
                SaldoKas = 12_236_500d ,
                Tanggal = new DateTime(2024, 4, 1),
                TanggalDitambahkan = new DateTime(2024, 4, 1),
                TanggalDiubah = new DateTime(2024, 4, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 54,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima nazar Tanpa Nama",
                Jumlah = 20_000d,
                SaldoKas = 12_256_500d ,
                Tanggal = new DateTime(2024, 4, 1),
                TanggalDitambahkan = new DateTime(2024, 4, 1),
                TanggalDiubah = new DateTime(2024, 4, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 19,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima perpuluhan tidak tetap Tanpa Nama",
                Jumlah = 200_000d,
                SaldoKas = 12_456_500d ,
                Tanggal = new DateTime(2024, 4, 1),
                TanggalDitambahkan = new DateTime(2024, 4, 1),
                TanggalDiubah = new DateTime(2024, 4, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 21,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Ketua Majelis Jemaat  bulan April 2024",
                Jumlah = 2_000_000d,
                SaldoKas = 10_456_500d ,
                Tanggal = new DateTime(2024, 4, 1),
                TanggalDitambahkan = new DateTime(2024, 4, 1),
                TanggalDiubah = new DateTime(2024, 4, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 185,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Kesejahteraan Pendeta bulan April 2024",
                Jumlah = 1_200_000d,
                SaldoKas = 9_256_500d ,
                Tanggal = new DateTime(2024, 4, 1),
                TanggalDitambahkan = new DateTime(2024, 4, 1),
                TanggalDiubah = new DateTime(2024, 4, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 186,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Kesehatan Pendeta bulan April 2024",
                Jumlah = 750_000d,
                SaldoKas = 8_506_500d ,
                Tanggal = new DateTime(2024, 4, 1),
                TanggalDitambahkan = new DateTime(2024, 4, 1),
                TanggalDiubah = new DateTime(2024, 4, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 187,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah gabungan kaum perempuan dirumah Ibu. Marni Aplugi Rayon 1&7, dipimpin oleh Dkn. Orpa M. Bria-P",
                Jumlah = 160_000d,
                SaldoKas = 8_666_500d ,
                Tanggal = new DateTime(2024, 5, 1),
                TanggalDitambahkan = new DateTime(2024, 5, 1),
                TanggalDiubah = new DateTime(2024, 5, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 73,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah gabungan kaum perempuan dirumah Ibu. Meytri Boimata Rayon 2, dipimpin oleh Pnt. Nelcy Kamesa-Ballu",
                Jumlah = 87_000d,
                SaldoKas = 8_753_500d ,
                Tanggal = new DateTime(2024, 5, 1),
                TanggalDitambahkan = new DateTime(2024, 5, 1),
                TanggalDiubah = new DateTime(2024, 5, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 73,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Terima kolekte ibadah gabungan kaum perempuan dirumah Ibu. Yunita Lali Pora Rayon 4, dipimpin oleh Pnt. Rivera Lantik-N",
                Jumlah = 160_000d,
                SaldoKas = 8_913_500d ,
                Tanggal = new DateTime(2024, 5, 1),
                TanggalDitambahkan = new DateTime(2024, 5, 1),
                TanggalDiubah = new DateTime(2024, 5, 1),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Penerimaan,
                AkunId = 73,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Ketua Majelis Jemaat  bulan Mei 2024",
                Jumlah = 2_000_000d,
                SaldoKas = 6_913_500d ,
                Tanggal = new DateTime(2024, 5, 4),
                TanggalDitambahkan = new DateTime(2024, 5, 4),
                TanggalDiubah = new DateTime(2024, 5, 4),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 185,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Kesejahteraan Pendeta bulan Mei 2024",
                Jumlah = 1_200_000d,
                SaldoKas = 5_713_500d ,
                Tanggal = new DateTime(2024, 5, 4),
                TanggalDitambahkan = new DateTime(2024, 5, 4),
                TanggalDiubah = new DateTime(2024, 5, 4),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 186,
                KasId = 1,
            },
            new
            {
                Id = 9,
                Uraian = "Tunjangan Kesehatan Pendeta bulan Mei 2024",
                Jumlah = 750_000d,
                SaldoKas = 4_693_500d ,
                Tanggal = new DateTime(2024, 5, 4),
                TanggalDitambahkan = new DateTime(2024, 5, 4),
                TanggalDiubah = new DateTime(2024, 5, 4),
                FileBukti = new Uri("https://file/1"),
                Jenis = Jenis.Belanja,
                AkunId = 187,
                KasId = 1,
            }
        };

        modelBuilder.Entity<Transaksi>().HasData(
            daftarTransaksi.Select((x, i) => new { Id = i + 1, x.Uraian, x.Jumlah, x.SaldoKas, Tanggal = new DateTime(x.Tanggal.Year, x.Tanggal.Month, x.Tanggal.Day, (i + 1) / 60, (i + 1) % 60, 0), x.TanggalDitambahkan, x.TanggalDiubah, x.FileBukti, x.Jenis, x.AkunId, x.KasId})
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
            },
            new User
            {
                Id = 2,
                UserName = "Operator",
                Role = UserRoles.Operator,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Operator")
            }
        );
        #endregion

        return modelBuilder;
    }
}