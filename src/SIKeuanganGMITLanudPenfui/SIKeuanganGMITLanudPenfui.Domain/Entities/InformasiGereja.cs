using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class InformasiGereja : IEquatable<InformasiGereja>
{
    public Tahun Tahun { get; set; }

    public string KetuaMajelisJemaat { get; set; } = string.Empty;
    public string Bendahara { get; set; } = string.Empty;

    public override int GetHashCode() => Tahun.Value.GetHashCode();

    public override bool Equals(object? obj) => obj is not null && obj is InformasiGereja other && other.Tahun == Tahun;

    public bool Equals(InformasiGereja? other) => other is not null && other.Tahun == Tahun;

    public static bool operator==(InformasiGereja? left,  InformasiGereja? right) => left is not null && left.Equals(right);

    public static bool operator !=(InformasiGereja? left, InformasiGereja? right) => !(left == right);
}
