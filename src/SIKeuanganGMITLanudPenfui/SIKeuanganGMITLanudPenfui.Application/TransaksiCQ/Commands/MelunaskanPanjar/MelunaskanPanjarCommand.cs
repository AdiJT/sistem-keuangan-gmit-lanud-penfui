using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.MelunaskanPanjar;

public record MelunaskanPanjarCommand(
    int IdTransaksi,
    double Jumlah,
    Uri FileBukti,
    string NomorBukti) : ICommand
{
}