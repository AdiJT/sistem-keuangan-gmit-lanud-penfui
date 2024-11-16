using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class RAPBJ : IEquatable<RAPBJ>
{
    public required Tahun Tahun { get; set; }

    public double TotalPenerimaan => DaftarDetailRAPBJ.Where(d => d.Akun.JenisAkun.Jenis == Jenis.Penerimaan).Select(d => d.Jumlah).Sum();
    public double TotalBelanja => DaftarDetailRAPBJ.Where(d => d.Akun.JenisAkun.Jenis == Jenis.Belanja).Select(d => d.Jumlah).Sum();

    public List<DetailRAPBJ> DaftarDetailRAPBJ { get; set; } = [];

    public bool Equals(RAPBJ? other) => other is not null && other.Tahun == Tahun;

    public override bool Equals(object? obj) => obj is not null && obj is RAPBJ other && other.Tahun == Tahun;

    public override int GetHashCode() => Tahun.GetHashCode();
}