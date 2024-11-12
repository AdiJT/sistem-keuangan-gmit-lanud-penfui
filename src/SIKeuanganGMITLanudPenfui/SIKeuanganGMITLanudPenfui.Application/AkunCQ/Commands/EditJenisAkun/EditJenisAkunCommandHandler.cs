﻿using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditJenisAkun;

internal class EditJenisAkunCommandHandler : ICommandHandler<EditJenisAkunCommand>
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IUnitOfWork _unitOfWork;

    public EditJenisAkunCommandHandler(IRepositoriJenisAkun repositoriJenisAkun, IUnitOfWork unitOfWork)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(EditJenisAkunCommand request, CancellationToken cancellationToken)
    {
        var jenisAkun = await _repositoriJenisAkun.Get(request.IdJenisAkun);
        if (jenisAkun is null)
            return new Error("EditJenisAkunCommandHandler.JenisAkunNotFound", $"Jenis Akun dengan Id {request.IdJenisAkun} tidak ditemukan");

        jenisAkun.Uraian = request.Uraian;
        _repositoriJenisAkun.Update(jenisAkun);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}