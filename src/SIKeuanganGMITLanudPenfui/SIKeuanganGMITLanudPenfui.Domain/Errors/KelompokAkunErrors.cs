using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class KelompokAkunErrors
{
    public static readonly Error JenisAkunTahunDifferent = new("KelompokAkunCreate.JenisAkunTahunDifferent", 
        "Tahun pada Jenis Akun berbeda dengan tahun Kelompok Akun");
}
