using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Akun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }
    public double? PresentaseSetoran { get; set; }

    public string Kode =>
        this switch
        {
            { KelompokAkun : null, GolonganAkun : null } => 
                $"{JenisAkun.DaftarAkun.Where(a => a is { KelompokAkun : null, GolonganAkun : null }).ToList().IndexOf(this) + 1}",
            { KelompokAkun : not null, GolonganAkun : null } => $"{KelompokAkun.Kode}.{KelompokAkun.DaftarAkun.IndexOf(this) + 1}",
            { KelompokAkun : null, GolonganAkun : not null } => $"{GolonganAkun.Kode}.{GolonganAkun.DaftarAkun.IndexOf(this) + 1}",
            _ => $"{GolonganAkun.Kode}.{GolonganAkun.DaftarAkun.IndexOf(this) + 1}"
        };

    public required JenisAkun JenisAkun { get; set; }
    public KelompokAkun? KelompokAkun { get; set; }
    public GolonganAkun? GolonganAkun { get; set; }

    private Akun(string uraian, Tahun tahun, double? presentaseSetoran)
    {
        Uraian = uraian;
        Tahun = tahun;
        PresentaseSetoran = presentaseSetoran;
    }

    public static Result<Akun> CreateWithJenisAkun(
        string uraian,
        Tahun tahun,
        double? presentaseSetoran,
        JenisAkun jenisAkun)
    {
        if (jenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return Errors.AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (jenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return Errors.AkunErrors.PenerimaanPresentaseSetoranNull;

        if (jenisAkun.Tahun != tahun)
            return Errors.AkunErrors.JenisAkunTahunBeda;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return Errors.AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, tahun, presentaseSetoran) 
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
        KelompokAkun kelompokAkun)
    {
        if (kelompokAkun.JenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return Errors.AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (kelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return Errors.AkunErrors.PenerimaanPresentaseSetoranNull;

        if (kelompokAkun.JenisAkun.Tahun != tahun)
            return Errors.AkunErrors.JenisAkunTahunBeda;

        if (kelompokAkun.Tahun != tahun)
            return Errors.AkunErrors.KelompokAkunTahunBeda;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return Errors.AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, tahun, presentaseSetoran)
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
        GolonganAkun golonganAkun)
    {
        if (golonganAkun.KelompokAkun.JenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return Errors.AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (golonganAkun.KelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return Errors.AkunErrors.PenerimaanPresentaseSetoranNull;

        if (golonganAkun.KelompokAkun.JenisAkun.Tahun != tahun)
            return Errors.AkunErrors.JenisAkunTahunBeda;

        if (golonganAkun.KelompokAkun.Tahun != tahun)
            return Errors.AkunErrors.KelompokAkunTahunBeda;

        if (golonganAkun.Tahun != tahun)
            return Errors.AkunErrors.GolonganAkunTahunBeda;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return Errors.AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, tahun, presentaseSetoran)
        {
            JenisAkun = golonganAkun.KelompokAkun.JenisAkun,
            GolonganAkun = golonganAkun
        };

        golonganAkun.DaftarAkun.Add(akun);

        return akun;
    }
}
