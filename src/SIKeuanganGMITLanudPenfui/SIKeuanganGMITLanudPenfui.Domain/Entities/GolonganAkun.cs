using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class GolonganAkun : Entity, IAkun
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }
    public int Kode { get; set; }

    public required KelompokAkun KelompokAkun { get; set; }
    public List<Akun> DaftarAkun { get; set; } = [];

    public string KodeAkun => $"{KelompokAkun.KodeAkun}.{Kode}";

    private GolonganAkun(string uraian, Tahun tahun, int kode)
    {
        Uraian = uraian;
        Tahun = tahun;
        Kode = kode;
    }

    public static Result<GolonganAkun> Create(string uraian, Tahun tahun, int kode, KelompokAkun kelompokAkun)
    {
        if (kelompokAkun.Tahun != tahun)
            return GolonganAkunErrors.KelompokAkunTahunDifferent;

        if(kelompokAkun.DaftarIAkun.Any(a => a.Kode == kode))
            return GolonganAkunErrors.KodeNotUnique(kode, kelompokAkun.Id);

        var golonganAkun = new GolonganAkun(uraian, tahun, kode) { KelompokAkun = kelompokAkun };
        kelompokAkun.DaftarGolonganAkun.Add(golonganAkun);

        return golonganAkun;
    }
}
