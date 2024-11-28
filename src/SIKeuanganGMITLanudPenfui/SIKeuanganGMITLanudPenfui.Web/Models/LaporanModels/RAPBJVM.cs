using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Dashboard.Models.LaporanModels;

public class RAPBJVM
{
    public required int Tahun { get; set; }
    public required List<JenisAkun> DaftarJenisAkunPenerimaan { get; set; }
    public required List<JenisAkun> DaftarJenisAkunBelanja { get; set; }
    public required RAPBJ? RAPBJ { get; set; }
}