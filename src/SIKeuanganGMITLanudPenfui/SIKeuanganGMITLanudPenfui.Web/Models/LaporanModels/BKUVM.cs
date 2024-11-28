using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Dashboard.Models.LaporanModels;

public class BKUVM
{
    public required int Tahun { get; set; }
    public required int Bulan { get; set; }
    public required List<Transaksi> DaftarTransaksi { get; set; }

    private readonly string[] _monthNames =
    [
        "JANUARI",
        "FEBRUARI",
        "MARET",
        "APRIL",
        "MEI",
        "JUNI",
        "JULI",
        "AGUSTUS",
        "SEPTEMBER",
        "OKTOBER",
        "NOVEMBER",
        "DESEMBER"
    ];

    public string MonthName(int month)
    {
        if (month <= 0 || month > _monthNames.Length) throw new ArgumentOutOfRangeException(nameof(month));

        return _monthNames[month - 1];
    }
}
