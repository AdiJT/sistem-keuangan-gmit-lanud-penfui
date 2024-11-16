using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.EditDetailRAPBJ;

public record EditDetailRAPBJCommand(int Tahun, int IdAkun, int Volume, string Satuan, double HargaSatuan) : ICommand
{
}
