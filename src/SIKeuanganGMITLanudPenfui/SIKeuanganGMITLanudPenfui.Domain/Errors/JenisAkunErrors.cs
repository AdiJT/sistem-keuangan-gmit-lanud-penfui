using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Domain.Errors;

public static class JenisAkunErrors
{
    public static Error UraianNotUnique(string uraian, Tahun tahun) => new(
        "JenisAkun.UraianNotUnique", $"Sudah ada jenis akun dengan uraian : {uraian} dan tahun : {tahun.Value}");

    public static Error KodeNotUnique(int kode, Tahun tahun) => new(
        "JenisAkun.KodeNotUnique", $"Sudah ada jenis akun dengan kode : {kode} pada tahun {tahun.Value}");
}
