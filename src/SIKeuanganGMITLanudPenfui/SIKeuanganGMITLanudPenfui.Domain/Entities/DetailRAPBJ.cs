using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class DetailRAPBJ
{
    public int TahunRAPBJ { get; set; }
    public int KodeAkun { get; set; }

    public int Volume { get; set; }
    public string Satuan { get; set; } = string.Empty;
    public double HargaSatuan { get; set; }

    public double Jumlah => Volume * HargaSatuan;
    
    public Akun Akun { get; set; }
    public RAPBJ RAPBJ { get; set; }
}
