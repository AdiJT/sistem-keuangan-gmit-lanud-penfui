using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.InformasiGerejaModels;

public class IndexVM
{
    public required int Tahun { get; set; }
    public required InformasiGereja? InformasiGereja { get; set; }
}
