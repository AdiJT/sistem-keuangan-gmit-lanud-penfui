using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.HapusTransaksi;

public record HapusTransaksiCommand(int IdTransaksi) : ICommand
{
}
