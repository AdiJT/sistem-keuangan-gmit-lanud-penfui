﻿using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models.RealisasiModels;

public class PanjarVM
{
    public required int Tahun { get; set; }
    public required List<Transaksi> DaftarTransaksi { get; set; }
    public required DateOnly Start { get; set; }
    public required DateOnly End { get; set; }
}
