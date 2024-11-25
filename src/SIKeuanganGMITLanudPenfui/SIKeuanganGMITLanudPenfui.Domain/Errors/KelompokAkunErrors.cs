using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class KelompokAkunErrors
{
    public static readonly Error JenisAkunTahunDifferent = new("KelompokAkunCreate.JenisAkunTahunDifferent", 
        "Tahun pada Jenis Akun berbeda dengan tahun Kelompok Akun");

    public static Error KodeNotUnique(int kode, int jenisAkunId) => new("KelompokCreate.KodeNotUnique",
        $"Jenis akun dengan Id {jenisAkunId} sudah memiliki kelompok akun dengan kode {kode}");
}
