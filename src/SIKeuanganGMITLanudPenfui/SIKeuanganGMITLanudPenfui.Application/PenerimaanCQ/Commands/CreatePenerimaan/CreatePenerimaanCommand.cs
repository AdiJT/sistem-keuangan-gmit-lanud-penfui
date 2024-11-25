using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.PenerimaanCQ.Commands.CreatePenerimaan;

public record CreatePenerimaanCommand(
    DateOnly Tanggal,
    string Uraian,
    double Jumlah,
    Uri FileBukti,
    int IdKas,
    int IdAkun) : ICommand
{
}
