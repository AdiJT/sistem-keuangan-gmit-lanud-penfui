using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class KelompokAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }

    public string Kode =>
        $"{JenisAkun.DaftarAkun.Where(a => a.KelompokAkun is null && a.GolonganAkun is null).Count()
            + JenisAkun.DaftarKelompokAkun.IndexOf(this) + 1}";

    public required JenisAkun JenisAkun { get; set; }
    public List<GolonganAkun> DaftarGolonganAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];

    private KelompokAkun(string uraian, Tahun tahun)
    {
        Uraian = uraian;
        Tahun = tahun;
    }

    public static Result<KelompokAkun> Create(string uraian, Tahun tahun, JenisAkun jenisAkun)
    {
        if (jenisAkun.Tahun != tahun)
            return KelompokAkunErrors.JenisAkunTahunDifferent;

        var kelompokAkun = new KelompokAkun(uraian, tahun) { JenisAkun = jenisAkun };
        jenisAkun.DaftarKelompokAkun.Add(kelompokAkun);

        return kelompokAkun;
    }
}
