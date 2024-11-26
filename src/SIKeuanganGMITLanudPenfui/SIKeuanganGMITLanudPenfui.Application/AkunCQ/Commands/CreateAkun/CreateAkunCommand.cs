using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkun;

public record CreateAkunCommand(
    string Uraian,
    int Tahun,
    bool? SetoranSinode,
    int Kode,
    int IdJenisAkun,
    int? IdKelompokAkun,
    int? IdGolonganAkun) : ICommand
{
}
