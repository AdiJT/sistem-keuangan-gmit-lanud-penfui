using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class GolonganAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;

    public string Kode =>
        $"{KelompokAkun.Kode}." +
        $"{KelompokAkun.DaftarAkun.Where(a => a.GolonganAkun is null).Count() 
            + KelompokAkun.DaftarGolonganAkun.IndexOf(this) + 1}";

    public KelompokAkun KelompokAkun { get; set; }
    public List<Akun> DaftarAkun { get; set; } = [];
}
