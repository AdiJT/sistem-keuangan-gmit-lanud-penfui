﻿using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Web.Dashboard.Models.LaporanModels;

public class IndexVM
{
    public required List<Transaksi> DaftarTransaksi { get; set; }
    public required Kas Kas { get; set; }

    public Dictionary<int, List<Transaksi>> TransaksiPerBulan
    {
        get
        {
            var dict = new Dictionary<int, List<Transaksi>>();
            for(int i = 1; i <= 12; i++)
            {
                var daftarTransaksi = DaftarTransaksi
                    .Where(t => t.Tanggal.Year == DateTime.Now.Year && t.Tanggal.Month == i)
                    .ToList();

                dict.Add(i, daftarTransaksi);
            }

            return dict;
        }
    }

    public Dictionary<DateTime, List<Transaksi>> TransaksiPerTanggal
    {
        get
        {
            var dict = new Dictionary<DateTime, List<Transaksi>>();

            for (int i = 1; i <= 6; i++)
            {
                var tanggal = new DateTime(2024, 1, i);
                var daftarTransaksi = DaftarTransaksi
                    .Where(t => t.Tanggal.Date == tanggal.Date)
                    .ToList();

                dict.Add(tanggal, daftarTransaksi);
            }

            return dict;
        }
    }

    public Dictionary<(DateTime start, DateTime end), List<Transaksi>> TransaksiPerMinggu
    {
        get
        {
            var dict = new Dictionary<(DateTime start, DateTime end), List<Transaksi>>();

            var start = new DateTime(DateTime.Now.Year, 1, 1);

            while (start.Month == 1)
            {
                var end = start.AddDays(7);
                dict.Add((start, end), DaftarTransaksi.Where(t => t.Tanggal.Date <= end.Date && t.Tanggal.Date >= start.Date).ToList());
                start = end;
            }

            return dict;
        }
    }

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