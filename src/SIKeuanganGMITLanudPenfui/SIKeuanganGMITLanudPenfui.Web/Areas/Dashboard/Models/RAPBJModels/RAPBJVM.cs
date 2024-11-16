using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RAPBJModels;

public class RAPBJVM
{
    public required int Tahun { get; set; }
    public required List<JenisAkun> DaftarJenisAkun { get; set; }
    public required RAPBJ? RAPBJ { get; set; }
}
