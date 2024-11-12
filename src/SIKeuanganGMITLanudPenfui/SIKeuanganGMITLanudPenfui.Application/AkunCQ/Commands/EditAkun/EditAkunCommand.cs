﻿using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditAkun;

public record EditAkunCommand(
    int IdAkun, 
    string Uraian, 
    double? PresentaseSetoranSinode, 
    int IdJenisAkun, 
    int? IdKelompokAkun, 
    int? IdGolonganAkun) : ICommand
{
} 