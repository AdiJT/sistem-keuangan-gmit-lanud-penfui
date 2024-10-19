namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class DetailRancanganAnggaran
{
    public int Volume { get; set; }
    public string Satuan { get; set; }
    public double HargaSatuan { get; set; }

    public double Total  => Volume * HargaSatuan;

    public Akun Akun { get; set; }
    public RancanganAnggaran RancanganAnggaran { get; set; }
}
