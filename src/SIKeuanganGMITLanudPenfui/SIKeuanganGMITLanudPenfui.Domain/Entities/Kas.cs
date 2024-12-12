using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class Kas : Entity, IAuditableEntity
{
    public string Uraian { get; set; } = string.Empty;
    public string Keterangan { get; set; } = string.Empty;
    public double Saldo { get; set; }
    public DateTime TanggalDitambahkan { get; set; }
    public DateTime? TanggalDiubah { get; set; }

    public List<Transaksi> DaftarTransaksi { get; set; } = [];
}