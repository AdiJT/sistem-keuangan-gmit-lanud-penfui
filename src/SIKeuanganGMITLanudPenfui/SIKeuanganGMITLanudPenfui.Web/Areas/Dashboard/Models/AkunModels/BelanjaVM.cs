using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class BelanjaVM
{
    public List<JenisAkun> DaftarJenisAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];
    public List<KelompokAkun> DaftarKelompokAkun { get; set; } = [];
    public List<GolonganAkun> DaftarGolonganAkun { get; set; } = [];

    public string KodeJenisAkun(JenisAkun jenisAkun) => $"2.{DaftarJenisAkun.IndexOf(jenisAkun) + 1}";
}
