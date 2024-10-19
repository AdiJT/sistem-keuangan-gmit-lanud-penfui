using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class JenisAkun : Entity
{
    public string Nama { get; set; } = string.Empty;
    public Jenis Jenis { get; set; } = Jenis.Pendapatan;
}
