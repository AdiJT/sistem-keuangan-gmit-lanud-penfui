using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class GolonganAkunErrors
{
    public static readonly Error KelompokAkunTahunDifferent = new("GolonganAkun.KelompokAkunTahunDifferent", 
        "Tahun Kelompok Akun beda dengan tahun Golongan Akun");

    public static Error KodeNotUnique(int kode, int idKelompokAkun) => new("GolonganAkun.KodeNotUnique",
        $"Kelompok Akun dengan Id : {idKelompokAkun} sudah memiliki akun dengan kode {kode}");
}
