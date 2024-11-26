using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Akun : Entity, IAkun
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }
    public double? PresentaseSetoran { get; set; }
    public int Kode { get; set; }

    public required JenisAkun JenisAkun { get; set; }
    public KelompokAkun? KelompokAkun { get; set; }
    public GolonganAkun? GolonganAkun { get; set; }
    public List<DetailRAPBJ> DaftarDetailRAPBJ { get; set; } = [];

    public string KodeAkun =>
        this switch
        {
            { KelompokAkun: null, GolonganAkun: null } => $"{JenisAkun.KodeAkun}.{Kode}",
            { KelompokAkun: not null, GolonganAkun: null} => $"{KelompokAkun.KodeAkun}.{Kode}",
            { KelompokAkun: null, GolonganAkun: not null} => $"{GolonganAkun.KodeAkun}.{Kode}",
            { KelompokAkun: not null, GolonganAkun: not null} => $"{GolonganAkun.KodeAkun}.{Kode}",
        };

    private Akun(string uraian, Tahun tahun, double? presentaseSetoran, int kode)
    {
        Uraian = uraian;
        Tahun = tahun;
        PresentaseSetoran = presentaseSetoran;
        Kode = kode;
    }

    public static Result<Akun> CreateWithJenisAkun(
        string uraian,
        Tahun tahun,
        double? presentaseSetoran,
        int kode,
        JenisAkun jenisAkun)
    {
        if (jenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (jenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return AkunErrors.PenerimaanPresentaseSetoranNull;

        if (jenisAkun.Tahun != tahun)
            return AkunErrors.JenisAkunTahunBeda;

        if (jenisAkun.DaftarIAkun.Any(a => a.Kode == kode))
            return AkunErrors.KodeNotUnique;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, tahun, presentaseSetoran, kode) 
        {
            JenisAkun = jenisAkun
        };

        jenisAkun.DaftarAkun.Add(akun);

        return akun;
    }

    public static Result<Akun> CreateWithKelompokAkun(
        string uraian,
        Tahun tahun,
        double? presentaseSetoran,
        int kode,
        KelompokAkun kelompokAkun)
    {
        if (kelompokAkun.JenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (kelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return AkunErrors.PenerimaanPresentaseSetoranNull;

        if (kelompokAkun.JenisAkun.Tahun != tahun)
            return AkunErrors.JenisAkunTahunBeda;

        if (kelompokAkun.Tahun != tahun)
            return AkunErrors.KelompokAkunTahunBeda;

        if (kelompokAkun.DaftarIAkun.Any(a => a.Kode == kode))
            return AkunErrors.KodeNotUnique;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, tahun, presentaseSetoran, kode)
        {
            JenisAkun = kelompokAkun.JenisAkun,
            KelompokAkun = kelompokAkun
        };

        kelompokAkun.DaftarAkun.Add(akun);

        return akun;
    }

    public static Result<Akun> CreateWithGolonganAkun(
        string uraian,
        Tahun tahun,
        double? presentaseSetoran,
        int kode,
        GolonganAkun golonganAkun)
    {
        if (golonganAkun.KelompokAkun.JenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (golonganAkun.KelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return AkunErrors.PenerimaanPresentaseSetoranNull;

        if (golonganAkun.KelompokAkun.JenisAkun.Tahun != tahun)
            return AkunErrors.JenisAkunTahunBeda;

        if (golonganAkun.KelompokAkun.Tahun != tahun)
            return AkunErrors.KelompokAkunTahunBeda;

        if (golonganAkun.Tahun != tahun)
            return AkunErrors.GolonganAkunTahunBeda;

        if (golonganAkun.DaftarAkun.Any(a => a.Kode == kode))
            return AkunErrors.KodeNotUnique;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, tahun, presentaseSetoran, kode)
        {
            JenisAkun = golonganAkun.KelompokAkun.JenisAkun,
            GolonganAkun = golonganAkun
        };

        golonganAkun.DaftarAkun.Add(akun);

        return akun;
    }
}
