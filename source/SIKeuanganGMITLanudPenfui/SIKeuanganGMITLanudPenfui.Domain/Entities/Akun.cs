using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Akun : Entity
{
    public string Uraian { get; set; }
    public bool IsKategori { get; set; }
    public double? PresentaseSinode { get; set; }

    public Akun? Kategori { get; set; }
    public JenisAkun JenisAkun { get; set; }
}
