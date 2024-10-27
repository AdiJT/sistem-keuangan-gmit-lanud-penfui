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
}
