using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.RAPBJCQ.Commands.CreateRAPBJ;

public record CreateRAPBJCommand(int Tahun) : ICommand { }