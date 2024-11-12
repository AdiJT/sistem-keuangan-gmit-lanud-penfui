using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Enums;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateJenisAkun;

public record CreateJenisAkunCommand(string Uraian, int Tahun, Jenis jenis) : ICommand
{
}
