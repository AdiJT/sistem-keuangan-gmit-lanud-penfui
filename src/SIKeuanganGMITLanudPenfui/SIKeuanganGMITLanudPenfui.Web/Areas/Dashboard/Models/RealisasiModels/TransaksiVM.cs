using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class TransaksiVM
{
    public required int Tahun { get; set; }
    public required Jenis Jenis { get; set; }
    public required List<Transaksi> DaftarTransaksi { get; set; }
    public required DateOnly Start { get; set; }
    public required DateOnly End { get; set; }
}