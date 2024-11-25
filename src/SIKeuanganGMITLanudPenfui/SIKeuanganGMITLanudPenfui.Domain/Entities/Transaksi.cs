using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Transaksi : Entity, IAuditableEntity
{
    public DateTime Tanggal { get; set; }
    public string Uraian { get; set; } = string.Empty;
    public double Jumlah { get; set; }
    public double SaldoKas { get; set; }
    public Uri FileBukti { get; set; }
    public Jenis Jenis { get; set; }
    public DateTime TanggalDitambahkan { get; set; }
    public DateTime? TanggalDiubah { get; set; }

    public Akun Akun { get; set; }
    public Kas Kas { get; set; }
}
