using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditKelompokAkun;

public record EditKelompokAkunCommand(int IdKelompokAkun, string Uraian, int IdJenisAkun) : ICommand
{
}