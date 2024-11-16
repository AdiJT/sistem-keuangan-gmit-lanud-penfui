using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class DetailRAPBJ : IEquatable<DetailRAPBJ>
{
    public required Tahun TahunRAPBJ { get; set; }
    public required int KodeAkun { get; set; }

    public required int Volume { get; set; }
    public required string Satuan { get; set; }
    public required double HargaSatuan { get; set; }

    public double Jumlah => Volume * HargaSatuan;
    
    public Akun Akun { get; set; }
    public RAPBJ RAPBJ { get; set; }

    public bool Equals(DetailRAPBJ? other) => other is not null && other.TahunRAPBJ == TahunRAPBJ && other.KodeAkun == KodeAkun;

    public override bool Equals(object? obj) => 
        obj is not null && obj is DetailRAPBJ other && other.TahunRAPBJ == TahunRAPBJ && other.KodeAkun == KodeAkun;

    public override int GetHashCode() => HashCode.Combine(TahunRAPBJ, KodeAkun);
}
