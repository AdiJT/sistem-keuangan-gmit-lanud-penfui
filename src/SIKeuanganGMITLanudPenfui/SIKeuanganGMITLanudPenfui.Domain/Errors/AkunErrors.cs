using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class AkunErrors
{
    public static readonly Error BelanjaPresentaseSetoranNotNull = new(
        "Akun.BelanjaPresentaseSetoranNotNull", "Untuk akun jenis belanja presentase setoran harus null");

    public static readonly Error PenerimaanPresentaseSetoranNull = new(
        "Akun.PenerimaanPresentaseSetoranNull", "Untuk akun jenis penerimaan presentase setoran harus null");

    public static readonly Error PresentaseSetoranNotInRange = new(
        "Akun.PresentaseSetoranNotInRange", "Presentase setoran harus diantara 0% dan 100%");

    public static readonly Error JenisAkunTahunBeda = new(
        "Akun.JenisAkunTahunBeda", "Tahun dari Jenis Akun beda dengan Tahun Akun");

    public static readonly Error KelompokAkunTahunBeda = new(
        "Akun.KelompokAkunTahunBeda", "Tahun dari Kelompok Akun beda dengan Tahun Akun");

    public static readonly Error GolonganAkunTahunBeda = new(
        "Akun.GolonganAkunTahunBeda", "Tahun dari Golongan Akun beda dengan Tahun Akun");

    public static readonly Error KodeNotUnique = new("Akun.KodeNotUnique", "Kode akun tidak unik");
}
