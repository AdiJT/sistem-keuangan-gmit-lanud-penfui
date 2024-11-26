using SIKeuanganGMITLanudPenfui.Application.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Application.KasCQ.Commands.CreateKas;

public record CreateKasCommand(string Uraian, double Saldo) : ICommand { }