﻿using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateGolonganAkun;

public record CreateGolonganAkunCommand(string Uraian, int Tahun, int Kode, int IdKelompokAkun) : ICommand
{
}
