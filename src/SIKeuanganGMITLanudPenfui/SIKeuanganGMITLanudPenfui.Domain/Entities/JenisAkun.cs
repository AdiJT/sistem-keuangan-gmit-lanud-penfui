using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class JenisAkun : Entity, IAkun
{
    public string Uraian { get; set; }
    public Tahun Tahun { get; set; }
    public Jenis Jenis { get; set; }
    public int Kode { get; set; }

    public List<KelompokAkun> DaftarKelompokAkun { get; set; } = [];
    public List<Akun> DaftarAkun { get; set; } = [];

    public List<IAkun> DaftarIAkun
    {
        get
        {
            var daftarIAkun = new List<IAkun>();

            foreach (var akun in DaftarAkun)
            {
                if (akun.KelompokAkun is null && akun.GolonganAkun is null)
                    daftarIAkun.Add(akun);
            }

            foreach (var kelompokAkun in DaftarKelompokAkun)
                daftarIAkun.Add(kelompokAkun);

            return daftarIAkun.OrderBy(a => a.Kode).ToList();
        }
    }

    public string KodeAkun => $"{(Jenis == Jenis.Penerimaan ? "I" : "II")}.{Kode}";

    private JenisAkun(
        string uraian,
        Tahun tahun,
        Jenis jenis,
        int kode)
    {
        Uraian = uraian;
        Tahun = tahun;
        Jenis = jenis;
        Kode = kode;
    }

    public static async Task<Result<JenisAkun>> Create(
        string uraian,
        Tahun tahun,
        Jenis jenis,
        int kode,
        IRepositoriJenisAkun repositoriJenisAkun)
    {
        if (!await repositoriJenisAkun.IsUraianUnique(uraian, tahun))
            return JenisAkunErrors.UraianNotUnique(uraian, tahun);

        if ((await repositoriJenisAkun.GetAllByTahun(tahun)).Where(j => j.Jenis == jenis).Any(j => j.Kode == kode))
            return JenisAkunErrors.KodeNotUnique(kode, tahun);

        return new JenisAkun(uraian, tahun, jenis, kode);
    }
}
