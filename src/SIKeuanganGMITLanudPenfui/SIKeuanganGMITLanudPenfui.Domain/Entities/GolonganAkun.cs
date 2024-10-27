using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class GolonganAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;

    public KelompokAkun KelompokAkun { get; set; }
    public List<Akun> DaftarAkun { get; set; } = [];
}
