using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RAPBJModels;

public class IndexVM
{
    public required int Tahun { get; set; }
    public required Jenis Jenis { get; set; }
    public required RAPBJ? RAPBJ { get; set; }
}
