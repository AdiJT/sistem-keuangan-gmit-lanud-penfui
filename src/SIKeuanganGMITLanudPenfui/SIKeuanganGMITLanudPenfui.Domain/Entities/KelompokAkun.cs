using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class KelompokAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;

    public JenisAkun JenisAkun { get; set; }
    public List<GolonganAkun> DaftarGolonganAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];
}
