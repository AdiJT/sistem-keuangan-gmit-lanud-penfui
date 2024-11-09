using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class JenisAkun : Entity
{
    public string Uraian { get; set; } = string.Empty;
    public Tahun Tahun { get; set; }
    public Jenis Jenis { get; set; }

    public List<KelompokAkun> DaftarKelompokAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];
}
