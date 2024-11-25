using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.PenerimaanModels;

public class IndexVM
{
    public required int Tahun { get; set; }
    public required List<Penerimaan> DaftarPenerimaan { get; set; }
}