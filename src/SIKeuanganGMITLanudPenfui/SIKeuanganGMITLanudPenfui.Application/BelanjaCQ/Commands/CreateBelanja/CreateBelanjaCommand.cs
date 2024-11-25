using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.BelanjaCQ.Commands.CreateBelanja;

public record CreateBelanjaCommand(DateOnly Tanggal, string Uraian, double Jumlah, Uri FileBukti, int IdKas, int IdAkun) : ICommand
{
}
