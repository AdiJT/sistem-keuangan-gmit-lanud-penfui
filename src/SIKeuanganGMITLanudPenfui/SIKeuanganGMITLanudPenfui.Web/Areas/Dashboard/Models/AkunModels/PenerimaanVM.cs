using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.AkunModels;

public class PenerimaanVM
{
    public int Tahun { get; set; }
    public List<Akun> DaftarAkun { get; set; } = [];
    public List<JenisAkun> DaftarJenisAkun { get; set; } = [];
    public List<KelompokAkun> DaftarKelompokAkun { get; set; } = [];
    public List<GolonganAkun> DaftarGolonganAkun { get; set; } = [];

    public string KodeJenisAkun(JenisAkun jenisAkun) => $"1.{DaftarJenisAkun.IndexOf(jenisAkun) + 1}";
}
