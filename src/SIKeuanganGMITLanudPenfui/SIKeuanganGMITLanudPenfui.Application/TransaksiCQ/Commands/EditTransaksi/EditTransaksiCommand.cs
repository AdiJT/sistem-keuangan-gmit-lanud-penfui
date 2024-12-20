using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.EditTransaksi;

public record EditTransaksiCommand(
    int IdTransaksi, 
    string Uraian, 
    Uri FileBukti,
    string NomorBukti,
    int IdAkun) : ICommand
{
}
