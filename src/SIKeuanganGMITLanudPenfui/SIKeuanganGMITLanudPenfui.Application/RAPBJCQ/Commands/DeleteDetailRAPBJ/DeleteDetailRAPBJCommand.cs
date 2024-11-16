using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.DeleteDetailRAPBJ;

public record DeleteDetailRAPBJCommand(int Tahun, int IdAkun) : ICommand
{
}