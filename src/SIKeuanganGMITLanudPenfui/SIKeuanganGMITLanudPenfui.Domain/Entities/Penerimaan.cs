using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Penerimaan : Entity, IAuditableEntity
{
    public DateOnly Tanggal { get; set; }
    public string Uraian { get; set; } = string.Empty;
    public double Jumlah { get; set; }
    public double SaldoKas { get; set; }
    public DateTime TanggalDitambahkan { get; set; }
    public DateTime TanggalDiubah { get; set; }

    public Akun Akun { get; set; }
    public Kas Kas { get; set; }
    public BuktiTransaksi BuktiTransaksi { get; set; }
}
