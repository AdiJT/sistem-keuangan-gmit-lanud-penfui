using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditJenisAkun;

public record EditJenisAkunCommand(int IdJenisAkun, string Uraian) : ICommand {}
