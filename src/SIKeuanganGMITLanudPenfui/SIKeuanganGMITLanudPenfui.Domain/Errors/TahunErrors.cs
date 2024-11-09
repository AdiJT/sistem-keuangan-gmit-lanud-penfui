using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class TahunErrors
{
    public static readonly Error TahunNegative = new("Tahun.NegativeYear", "Tahun tidak boleh negatif");
}
