using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.DeleteAllByTahun;

public record DeleteAllByTahunCommand(int Tahun) : ICommand
{
}
