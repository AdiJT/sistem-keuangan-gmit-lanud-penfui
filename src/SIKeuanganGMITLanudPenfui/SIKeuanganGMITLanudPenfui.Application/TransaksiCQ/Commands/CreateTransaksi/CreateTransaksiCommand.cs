using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateTransaksi;

public record CreateTransaksiCommand(
    DateOnly Tanggal,
    string Uraian,
    string Jumlah,
    Uri FileBukti,
    Jenis Jenis,
    int AkunId,
    int KasId) : ICommand { }