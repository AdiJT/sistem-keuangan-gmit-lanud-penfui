using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateBelanjaPanjar;

public record CreateBelanjaPanjarCommand(
    DateOnly Tanggal,
    TimeOnly? Jam,
    string Uraian,
    double Jumlah,
    int AkunId,
    int KasId) : ICommand
{
}
