using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateKelompokAkun;

public record CreateKelompokAkunCommand(string Uraian, int Tahun, int Kode, int IdJenisAkun) : ICommand
{
}