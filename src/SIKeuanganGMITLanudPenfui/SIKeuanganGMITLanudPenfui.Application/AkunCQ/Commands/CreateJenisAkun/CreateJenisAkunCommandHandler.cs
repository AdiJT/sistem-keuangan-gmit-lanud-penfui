using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateJenisAkun;

internal class CreateJenisAkunCommandHandler : ICommandHandler<CreateJenisAkunCommand>
{
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IUnitOfWork _unitOfWork;

    public CreateJenisAkunCommandHandler(IRepositoriJenisAkun repositoriJenisAkun, IUnitOfWork unitOfWork)
    {
        _repositoriJenisAkun = repositoriJenisAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateJenisAkunCommand request, CancellationToken cancellationToken)
    {
        var tahun = Tahun.Create(request.Tahun);
        if (tahun.IsFailure) return tahun.Error;

        if (!(await _repositoriJenisAkun.IsUraianUnique(request.Uraian, tahun.Value)))
            return new Error("CreateJenisAkunCommandHandler.UraianNotUnique",
                $"Sudah ada jenis akun dengan uraian : {request.Uraian} dan tahun : {request.Tahun}");

        var jenisAkun = new JenisAkun
        {
            Uraian = request.Uraian,
            Tahun = tahun.Value,
            Jenis = request.jenis,
        };

        _repositoriJenisAkun.Add(jenisAkun);
        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}
