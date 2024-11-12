using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkun;

public record CreateAkunCommand(
    string Uraian,
    int Tahun,
    double? PresentaseSetoranSinode,
    int IdJenisAkun,
    int? IdKelompokAkun,
    int? IdGolonganAkun) : ICommand
{
}
