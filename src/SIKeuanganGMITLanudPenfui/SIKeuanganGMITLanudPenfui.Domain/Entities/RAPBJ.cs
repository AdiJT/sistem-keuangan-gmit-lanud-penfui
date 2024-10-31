using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class RAPBJ
{
    public int Tahun { get; set; }

    public double TotalPenerimaan => DaftarDetailRAPBJ.Where(d => d.Akun.JenisAkun.Jenis == Jenis.Penerimaan).Select(d => d.Jumlah).Sum();
    public double TotalBelanja => DaftarDetailRAPBJ.Where(d => d.Akun.JenisAkun.Jenis == Jenis.Belanja).Select(d => d.Jumlah).Sum();

    public List<DetailRAPBJ> DaftarDetailRAPBJ { get; set; } = [];
}