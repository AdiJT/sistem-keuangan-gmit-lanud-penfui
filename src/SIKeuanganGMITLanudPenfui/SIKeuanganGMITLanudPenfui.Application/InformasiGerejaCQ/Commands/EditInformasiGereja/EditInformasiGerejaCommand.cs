using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.InformasiGerejaCQ.Commands.EditInformasiGereja;

public record EditInformasiGerejaCommand(int Tahun, string KetuaMajelisJemaat, string Bendahara) : ICommand
{
}
