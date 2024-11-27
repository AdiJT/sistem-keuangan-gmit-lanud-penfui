using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.LaporanModels;

public class RekaptulasiTahunanVM
{
    public required List<Transaksi> DaftarTransaksi { get; set; }
    public required int Tahun { get; set; }
}
