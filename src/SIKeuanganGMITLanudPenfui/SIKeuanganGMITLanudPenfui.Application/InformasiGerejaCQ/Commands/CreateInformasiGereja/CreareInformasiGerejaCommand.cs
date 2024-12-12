using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.InformasiGerejaCQ.Commands.CreateInformasiGereja;

public record CreareInformasiGerejaCommand(int Tahun, string KetuaMajelisJemaat, string Bendahara) : ICommand
{
}
