using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Belanja : Entity
{
    public DateOnly Tanggal { get; set; }
    public string Uraian { get; set; } = string.Empty;
    public double Jumlah { get; set; }
    public double SaldoKas { get; set; }

    public Akun Akun { get; set; }
}
