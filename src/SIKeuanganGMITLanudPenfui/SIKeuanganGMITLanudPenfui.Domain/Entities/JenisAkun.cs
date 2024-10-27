using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class JenisAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public Jenis Jenis { get; set; }

    public List<KelompokAkun> DaftarKelompokAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];
}
