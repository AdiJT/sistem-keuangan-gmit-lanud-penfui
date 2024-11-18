using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Domain.Abstracts;

public interface IAuditableEntity
{
    DateTime TanggalDitambahkan { get; set; }
    DateTime? TanggalDiubah {  get; set; }
}