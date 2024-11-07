using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class BuktiTransaksi : Entity, IAuditableEntity
{
    public Jenis Jenis { get; set; }
    public string Uraian { get; set; }
    public Uri FileBukti { get; set; }
    public DateTime TanggalDitambahkan { get; set; }
    public DateTime TanggalDiubah { get; set; }
}
