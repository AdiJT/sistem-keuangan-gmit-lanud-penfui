using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.CreateTransaksi;

public record CreateTransaksiCommand(
    DateOnly Tanggal,
    TimeOnly? Jam,
    string Uraian,
    double Jumlah,
    Uri FileBukti,
    string NomorBukti,
    Jenis Jenis,
    int AkunId,
    int KasId) : ICommand { }