using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class GolonganAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }

    public required KelompokAkun KelompokAkun { get; set; }
    public List<Akun> DaftarAkun { get; set; } = [];

    private GolonganAkun(string uraian, Tahun tahun)
    {
        Uraian = uraian;
        Tahun = tahun;
    }

    public static Result<GolonganAkun> Create(string uraian, Tahun tahun, KelompokAkun kelompokAkun)
    {
        if (kelompokAkun.Tahun != tahun)
            return GolonganAkunErrors.KelompokAkunTahunDifferent;

        var golonganAkun = new GolonganAkun(uraian, tahun) { KelompokAkun = kelompokAkun };
        kelompokAkun.DaftarGolonganAkun.Add(golonganAkun);

        return golonganAkun;
    }
}
