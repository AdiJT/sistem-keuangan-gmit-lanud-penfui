using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkunOnTahunFromTahun;

public record CreateAkunOnTahunFromTahunCommand(int TahunSumber, int TahunTujuan) : ICommand
{
}
