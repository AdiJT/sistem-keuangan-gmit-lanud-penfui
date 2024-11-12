using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditGolonganAkun;

public record EditGolonganAkunCommand(int IdGolonganAkun, string Uraian, int IdKelompokAkun) : ICommand
{
}
