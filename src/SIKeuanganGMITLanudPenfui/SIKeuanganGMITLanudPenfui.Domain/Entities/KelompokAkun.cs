using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class KelompokAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }

    public string Kode => 
        $"{JenisAkun.DaftarAkun.Where(a => a.KelompokAkun is null && a.GolonganAkun is null).Count() 
            + JenisAkun.DaftarKelompokAkun.IndexOf(this) + 1}";

    public JenisAkun JenisAkun { get; set; }
    public List<GolonganAkun> DaftarGolonganAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];
}
