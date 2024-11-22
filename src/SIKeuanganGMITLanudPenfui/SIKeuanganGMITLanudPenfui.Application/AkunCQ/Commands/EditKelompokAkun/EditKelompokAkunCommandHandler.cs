using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.EditKelompokAkun;

internal class EditKelompokAkunCommandHandler : ICommandHandler<EditKelompokAkunCommand>
{
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IUnitOfWork _unitOfWork;

    public EditKelompokAkunCommandHandler(
        IRepositoriKelompokAkun repositoriKelompokAkun, 
        IRepositoriJenisAkun repositoriJenisAkun, 
        IUnitOfWork unitOfWork)
    {
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(EditKelompokAkunCommand request, CancellationToken cancellationToken)
    {
        var kelompokAkun = await _repositoriKelompokAkun.Get(request.IdKelompokAkun);
        if (kelompokAkun is null)
            return new Error("EditKelompokAkunCommandHandler.KelompokAkunNotFound", 
                $"Kelompok Akun dengan Id : {request.IdKelompokAkun} tidak ditemukan");

        var jenisAkun = await _repositoriJenisAkun.Get(request.IdJenisAkun);
        if(jenisAkun is null)
            return new Error("EditKelompokAkunCommandHandler.JenisAkunNotFound",
                $"Jenis Akun dengan Id : {request.IdJenisAkun} tidak ditemukan");

        if(jenisAkun.Tahun != kelompokAkun.Tahun)
            return new Error("EditKelompokAkunCommandHandler.TahunJenisAkunDifferent",
                $"Tahun Jenis Akun berbeda dengan Tahun Kelompok Akun");

        if(jenisAkun.Jenis != kelompokAkun.JenisAkun.Jenis)
            return new Error("EditKelompokAkunCommandHandler.JenisJenisAkunDifferent",
                $"Jenis dari Jenis Akun berbeda dengan Jenis dari Kelompok Akun");

        if(jenisAkun.DaftarIAkun.Any(a => a.Kode == request.Kode))
            return new Error("EditKelompokAkunCommandHandler.KodeNotUnique", "Kode tidak unik");

        kelompokAkun.Uraian = request.Uraian;
        kelompokAkun.JenisAkun = jenisAkun;
        kelompokAkun.Kode = request.Kode;
        _repositoriKelompokAkun.Update(kelompokAkun);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
