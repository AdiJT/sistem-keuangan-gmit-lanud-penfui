using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditAkun;

public record EditAkunCommand(
    int IdAkun, 
    string Uraian, 
    int Kode,
    bool? SetoranSinode, 
    int IdJenisAkun, 
    int? IdKelompokAkun, 
    int? IdGolonganAkun) : ICommand
{
} 