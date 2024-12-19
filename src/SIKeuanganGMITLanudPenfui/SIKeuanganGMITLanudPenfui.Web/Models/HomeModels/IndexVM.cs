using SIKeuanganGMITLanudPenfui.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Models.HomeModels;

public class IndexVM
{
    public required List<Transaksi> DaftarTransaksi { get; set; } = [];

    public Dictionary<int, List<Transaksi>> TransaksiPerBulan
    {
        get
        {
            var dict = new Dictionary<int, List<Transaksi>>();
            for (int i = 1; i <= 12; i++)
            {
                var daftarTransaksi = DaftarTransaksi
                    .Where(t => t.Tanggal.Year == DateTime.Now.Year && t.Tanggal.Month == i)
                    .ToList();

                dict.Add(i, daftarTransaksi);
            }

            return dict;
        }
    }

    public Dictionary<(DateTime start, DateTime end), List<Transaksi>> TransaksiPerMinggu
    {
        get
        {
            var dict = new Dictionary<(DateTime start, DateTime end), List<Transaksi>>();
            var dateTimeNow = DateTime.Now;

            var start = new DateTime(DateTime.Now.Year, dateTimeNow.Month, 1);

            while(start.Month == dateTimeNow.Month)
            {
                var end = start.AddDays(7);
                dict.Add((start, end), DaftarTransaksi.Where(t => t.Tanggal.Date <= end.Date && t.Tanggal.Date >= start.Date).ToList());
                start = end;
            }

            return dict;
        }
    }

    [Display(Name = "Nama")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Nama { get; set; } = string.Empty;

    [Display(Name = "Judul")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Judul { get; set; } = string.Empty;

    [Display(Name = "Pesan")]
    [Required(ErrorMessage = "{0} harus diisi")]
    public string Pesan { get; set; } = string.Empty;
}
