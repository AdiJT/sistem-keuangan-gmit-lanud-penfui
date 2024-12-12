using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.EditKas;

public record EditKasCommand(int IdKas, string Uraian, string Keterangan) : ICommand
{
}
