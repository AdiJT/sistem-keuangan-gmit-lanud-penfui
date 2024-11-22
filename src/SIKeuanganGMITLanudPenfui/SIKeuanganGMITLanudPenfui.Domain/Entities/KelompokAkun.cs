using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class KelompokAkun : Entity, IAkun
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }
    public int Kode { get; set; }

    public required JenisAkun JenisAkun { get; set; }
    public List<GolonganAkun> DaftarGolonganAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];

    public List<IAkun> DaftarIAkun => DaftarGolonganAkun.Concat<IAkun>(DaftarAkun).OrderBy(a => a.Kode).ToList();
    public string KodeAkun => $"{JenisAkun.KodeAkun}.{Kode}";

    private KelompokAkun(string uraian, Tahun tahun, int kode)
    {
        Uraian = uraian;
        Tahun = tahun;
        Kode = kode;
    }

    public static Result<KelompokAkun> Create(string uraian, Tahun tahun, int kode, JenisAkun jenisAkun)
    {
        if (jenisAkun.Tahun != tahun)
            return KelompokAkunErrors.JenisAkunTahunDifferent;

        if (jenisAkun.DaftarIAkun.Any(a => a.Kode == kode))
            return KelompokAkunErrors.KodeNotUnique(kode, jenisAkun.Id);

        var kelompokAkun = new KelompokAkun(uraian, tahun, kode) { JenisAkun = jenisAkun };
        jenisAkun.DaftarKelompokAkun.Add(kelompokAkun);

        return kelompokAkun;
    }
}
