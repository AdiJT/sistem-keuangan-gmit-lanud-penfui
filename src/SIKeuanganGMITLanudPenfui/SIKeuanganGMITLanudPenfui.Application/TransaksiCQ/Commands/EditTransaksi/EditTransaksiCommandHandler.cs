﻿using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Application.Services;
using SIKeuanganGMITLanudPenfui.Domain.Enums;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.TransaksiCQ.Commands.EditTransaksi;

internal class EditTransaksiCommandHandler : ICommandHandler<EditTransaksiCommand>
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriTransaksi _repositoriTransaksi;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileService _fileService;

    public EditTransaksiCommandHandler(
        IRepositoriAkun repositoriAkun, 
        IRepositoriTransaksi repositoriTransaksi, 
        IUnitOfWork unitOfWork, 
        IFileService fileService)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriTransaksi = repositoriTransaksi;
        _unitOfWork = unitOfWork;
        _fileService = fileService;
    }

    public async Task<Result> Handle(EditTransaksiCommand request, CancellationToken cancellationToken)
    {
        var transaksi = await _repositoriTransaksi.Get(request.IdTransaksi);
        if (transaksi is null)
            return new Error("EditTransaksiCommandHandler.TransaksiTidakDitemukan", $"Transaksi dengan Id {request.IdTransaksi} tidak ditemukan");

        var akun = await _repositoriAkun.Get(request.IdAkun);
        if(akun is null)
            return new Error("EditTransaksiCommandHandler.AkunTidakDitemukan", $"Akun dengan Id {request.IdAkun} tidak ditemukan");

        if(akun.JenisAkun.Jenis != transaksi.Jenis)
            return new Error("EditTransaksiCommandHandler.JenisBerbeda", 
                $"Akun {akun.JenisAkun.Jenis} tidak digunakan pada transaksi {transaksi.Jenis}");

        if(transaksi.StatusTransaksi == StatusTransaksi.Lunas)
        {
            if(transaksi.FileBukti != request.FileBukti)
            {
                if(!_fileService.IsExist(request.FileBukti))
                    return new Error("EditTransaksiCommandHandler.FileBuktiTidakAda", 
                        $"File Bukti baru tidak ada");

                var deleteResult = _fileService.Delete(transaksi.FileBukti!);
                if(deleteResult.IsFailure)
                    return new Error("EditTransaksiCommandHandler.FileBuktiLamaGagalDihapus",
                        $"File Bukti lama gagal dihapus");

                transaksi.FileBukti = request.FileBukti;
                transaksi.NomorBukti = request.NomorBukti;
            }
        }

        transaksi.Uraian = request.Uraian;
        transaksi.Akun = akun;
        _repositoriTransaksi.Update(transaksi);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if (result.IsFailure) return result.Error;

        return Result.Success();
    }
}
