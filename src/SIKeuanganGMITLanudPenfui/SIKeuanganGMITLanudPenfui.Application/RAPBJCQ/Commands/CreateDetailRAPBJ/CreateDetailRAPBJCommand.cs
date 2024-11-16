using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateDetailRAPBJ;

public record CreateDetailRAPBJCommand(int Tahun, int IdAkun, int Volume, string Satuan, double HargaSatuan) : ICommand
{
}
