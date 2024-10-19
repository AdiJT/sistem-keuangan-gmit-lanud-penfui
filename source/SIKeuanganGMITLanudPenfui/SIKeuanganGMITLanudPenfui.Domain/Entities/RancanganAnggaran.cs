using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class RancanganAnggaran : Entity
{
    public int Tahun { get; set; }

    public List<DetailRancanganAnggaran> DaftarDetailRancangan { get; set; } = new();
}
