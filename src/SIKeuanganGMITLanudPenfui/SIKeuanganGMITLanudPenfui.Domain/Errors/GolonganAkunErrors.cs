using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class GolonganAkunErrors
{
    public static readonly Error KelompokAkunTahunDifferent = new("GolonganAkun.KelompokAkunTahunDifferent", 
        "Tahun Kelompok Akun beda dengan tahun Golongan Akun");
}
