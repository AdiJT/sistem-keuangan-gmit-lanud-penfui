using SIKeuanganGMITLanudPenfui.Application.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Application.AkunCQ.Commands.CreateAkunOnTahunFromTahun;

internal class CreateAkunOnTahunFromTahunCommandHandler : ICommandHandler<CreateAkunOnTahunFromTahunCommand>
{
    private readonly IRepositoriAkun _repositoriAkun;
    private readonly IRepositoriJenisAkun _repositoriJenisAkun;
    private readonly IRepositoriKelompokAkun _repositoriKelompokAkun;
    private readonly IRepositoriGolonganAkun _repositoriGolonganAkun;
    private readonly IUnitOfWork _unitOfWork;

    public CreateAkunOnTahunFromTahunCommandHandler(
        IRepositoriAkun repositoriAkun,
        IRepositoriJenisAkun repositoriJenisAkun,
        IRepositoriKelompokAkun repositoriKelompokAkun,
        IRepositoriGolonganAkun repositoriGolonganAkun,
        IUnitOfWork unitOfWork)
    {
        _repositoriAkun = repositoriAkun;
        _repositoriJenisAkun = repositoriJenisAkun;
        _repositoriKelompokAkun = repositoriKelompokAkun;
        _repositoriGolonganAkun = repositoriGolonganAkun;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(CreateAkunOnTahunFromTahunCommand request, CancellationToken cancellationToken)
    {
        var tahunSumber = Tahun.Create(request.TahunSumber);
        if (tahunSumber.IsFailure)
            return tahunSumber.Error;

        var tahunTujuan = Tahun.Create(request.TahunTujuan);
        if (tahunTujuan.IsFailure)
            return tahunTujuan.Error;

        if (!await _repositoriAkun.IsExistOnTahun(tahunSumber.Value))
            return new Error("CreateAkunOnTahunFromTahunCommandHandler.NoAkunOnTahunSumber",
                $"Tidak ada akun di tahun sumber : {tahunSumber.Value}");

        if (await _repositoriAkun.IsExistOnTahun(tahunTujuan.Value))
            return new Error("CreateAkunOnTahunFromTahunCommandHandler.AkunExistOnTahunTujuan",
                $"Sudah ada akun di tahun tujuan: {tahunTujuan.Value}");

        var daftarJenisAkun = await _repositoriJenisAkun.GetAllByTahun(tahunSumber.Value);
        var daftarKelompokAkun = await _repositoriKelompokAkun.GetAllByTahun(tahunSumber.Value);
        var daftarGolonganAkun = await _repositoriGolonganAkun.GetAllByTahun(tahunSumber.Value);
        var daftarAkun = await _repositoriAkun.GetAllByTahun(tahunSumber.Value);

        var daftarJenisAkunBaru = daftarJenisAkun.Select(j => new JenisAkun { Uraian = j.Uraian, Jenis = j.Jenis, Tahun = tahunTujuan.Value }).ToList();
        var daftarKelompokAkunBaru = new List<KelompokAkun>();
        var daftarGolonganAkunBaru = new List<GolonganAkun>();
        var daftarAkunBaru = new List<Akun>();

        foreach (var kelompokAkun in daftarKelompokAkun)
        {
            var jenisAkun = daftarJenisAkunBaru[daftarJenisAkun.IndexOf(kelompokAkun.JenisAkun)];
            var kelompokAkunBaru = KelompokAkun.Create(kelompokAkun.Uraian, tahunTujuan.Value, jenisAkun);

            if (kelompokAkunBaru.IsFailure)
                return kelompokAkunBaru.Error;

            daftarKelompokAkunBaru.Add(kelompokAkunBaru.Value);
        }

        foreach (var golonganAkun in daftarGolonganAkun)
        {
            var kelompokAkun = daftarKelompokAkunBaru[daftarKelompokAkun.IndexOf(golonganAkun.KelompokAkun)];
            var golonganAkunBaru = GolonganAkun.Create(golonganAkun.Uraian, tahunTujuan.Value, kelompokAkun);

            if (golonganAkunBaru.IsFailure)
                return golonganAkunBaru.Error;

            daftarGolonganAkunBaru.Add(golonganAkunBaru.Value);
        }

        foreach (var akun in daftarAkun)
        {
            var jenisAkun = daftarJenisAkunBaru[daftarJenisAkun.IndexOf(akun.JenisAkun)];

            Akun akunBaru;
            if(akun is { KelompokAkun : not null, GolonganAkun : null })
            {
                var kelompokAkun = daftarKelompokAkunBaru[daftarKelompokAkun.IndexOf(akun.KelompokAkun)];
                var rAkun = Akun.CreateWithKelompokAkun(akun.Uraian, tahunTujuan.Value, akun.PresentaseSetoran, kelompokAkun);
                if(rAkun.IsFailure)
                    return rAkun.Error;
                akunBaru = rAkun.Value;
            }
            else if (akun is { KelompokAkun : null, GolonganAkun : not null })
            {
                var golonganAkun = daftarGolonganAkunBaru[daftarGolonganAkun.IndexOf(akun.GolonganAkun)];
                var rAkun = Akun.CreateWithGolonganAkun(akun.Uraian, tahunTujuan.Value, akun.PresentaseSetoran, golonganAkun);
                if (rAkun.IsFailure)
                    return rAkun.Error;
                akunBaru = rAkun.Value;
            }
            else
            {
                var rAkun = Akun.CreateWithJenisAkun(akun.Uraian, tahunTujuan.Value, akun.PresentaseSetoran, jenisAkun);
                if (rAkun.IsFailure)
                    return rAkun.Error;
                akunBaru = rAkun.Value;
            }
            daftarAkunBaru.Add(akunBaru);
        }

        foreach (var jenisAkun in daftarJenisAkunBaru)
            _repositoriJenisAkun.Add(jenisAkun);

        foreach (var kelompokAkun in daftarKelompokAkunBaru)
            _repositoriKelompokAkun.Add(kelompokAkun);

        foreach (var golonganAkun in daftarGolonganAkunBaru)
            _repositoriGolonganAkun.Add(golonganAkun);

        foreach (var akun in daftarAkunBaru)
            _repositoriAkun.Add(akun);

        var result = await _unitOfWork.SaveChangesAsync(cancellationToken);
        if(result.IsFailure)
            return result.Error;

        return Result.Success();
    }
}
