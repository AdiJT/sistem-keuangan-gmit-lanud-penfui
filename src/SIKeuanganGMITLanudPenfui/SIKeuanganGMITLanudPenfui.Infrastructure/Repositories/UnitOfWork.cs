using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Repositories;

internal class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _appDbContext;
    private readonly ILogger<UnitOfWork> _logger;

    public UnitOfWork(AppDbContext appDbContext, ILogger<UnitOfWork> logger)
    {
        _appDbContext = appDbContext;
        _logger = logger;
    }

    public async Task<Result<int>> SaveChangesAsync(CancellationToken cancellationToken=default)
    {
        try
        {
            UpdateAuditableEntity();
            return await _appDbContext.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("Unexpected Exception When Try SaveChanges. Message : {@message}. At : {@time}", ex.Message, DateTime.Now);

            return new Error("SaveChangesAsync.Failed",
                "Terjadi masalah tidak terduga saat coba menyimpan perubahan ke database. Laporkan masalah ini ke admin/developer!");
        }
    }

    private void UpdateAuditableEntity() =>
        _appDbContext.ChangeTracker.Entries<IAuditableEntity>().ToList().ForEach(
            e =>
            {
                if (e.State == EntityState.Added)
                    e.Entity.TanggalDitambahkan = DateTime.Now;

                if (e.State == EntityState.Modified)
                    e.Entity.TanggalDiubah = DateTime.Now;
            });
}
