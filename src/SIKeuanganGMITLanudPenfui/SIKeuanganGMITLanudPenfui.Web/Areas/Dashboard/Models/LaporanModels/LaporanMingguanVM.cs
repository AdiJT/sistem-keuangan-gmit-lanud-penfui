using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.LaporanModels;

public class LaporanMingguanVM
{
    public required DateTime Dari { get; set; }
    public required DateTime Sampai { get; set; }
    public required List<Transaksi> DaftarTransaksi { get; set; }
}
