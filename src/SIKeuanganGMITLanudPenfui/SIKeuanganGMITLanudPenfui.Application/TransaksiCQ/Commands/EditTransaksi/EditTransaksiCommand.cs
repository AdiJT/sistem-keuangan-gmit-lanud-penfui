using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.EditTransaksi;

public record EditTransaksiCommand(int IdTransaksi, string Uraian, int IdAkun) : ICommand
{
}
