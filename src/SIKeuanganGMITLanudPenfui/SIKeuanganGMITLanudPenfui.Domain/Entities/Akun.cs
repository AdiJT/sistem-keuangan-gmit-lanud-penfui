using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Akun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public double? PresentaseSetoran { get; set; }

    public string Kode =>
        this switch
        {
            { KelompokAkun : null, GolonganAkun : null }  => $"{JenisAkun.DaftarAkun.IndexOf(this) + 1}",
            { KelompokAkun : not null, GolonganAkun : null } => $"{KelompokAkun.Kode}.{KelompokAkun.DaftarAkun.IndexOf(this) + 1}",
            { KelompokAkun : null, GolonganAkun : not null } => $"{GolonganAkun.Kode}.{GolonganAkun.DaftarAkun.IndexOf(this) + 1}",
            _ => throw new NotImplementedException()
        };

    public JenisAkun JenisAkun { get; set; }
    public KelompokAkun? KelompokAkun { get; set; }
    public GolonganAkun? GolonganAkun { get; set; }

    private Akun(string uraian, double? presentaseSetoran)
    {
        Uraian = uraian;
        PresentaseSetoran = presentaseSetoran;
    }

    public static Result<Akun> CreateWithJenisAkun(
        string uraian,
        double? presentaseSetoran,
        JenisAkun jenisAkun)
    {
        if (jenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return Errors.AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (jenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return Errors.AkunErrors.PenerimaanPresentaseSetoranNull;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return Errors.AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, presentaseSetoran) 
        {
            JenisAkun = jenisAkun
        };

        jenisAkun.DaftarAkun.Add(akun);

        return akun;
    }

    public static Result<Akun> CreateWithKelompokAkun(
        string uraian,
        double? presentaseSetoran,
        KelompokAkun kelompokAkun)
    {
        if (kelompokAkun.JenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return Errors.AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (kelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return Errors.AkunErrors.PenerimaanPresentaseSetoranNull;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return Errors.AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, presentaseSetoran)
        {
            JenisAkun = kelompokAkun.JenisAkun,
            KelompokAkun = kelompokAkun
        };

        kelompokAkun.DaftarAkun.Add(akun);

        return akun;
    }

    public static Result<Akun> CreateWithGolonganAkun(
        string uraian,
        double? presentaseSetoran,
        GolonganAkun golonganAkun)
    {
        if (golonganAkun.KelompokAkun.JenisAkun.Jenis == Jenis.Belanja && presentaseSetoran is not null)
            return Errors.AkunErrors.BelanjaPresentaseSetoranNotNull;

        if (golonganAkun.KelompokAkun.JenisAkun.Jenis == Jenis.Penerimaan && presentaseSetoran is null)
            return Errors.AkunErrors.PenerimaanPresentaseSetoranNull;

        if (presentaseSetoran is not null && (presentaseSetoran < 0 || presentaseSetoran > 1))
            return Errors.AkunErrors.PresentaseSetoranNotInRange;

        var akun = new Akun(uraian, presentaseSetoran)
        {
            JenisAkun = golonganAkun.KelompokAkun.JenisAkun,
            GolonganAkun = golonganAkun
        };

        golonganAkun.DaftarAkun.Add(akun);

        return akun;
    }
}
