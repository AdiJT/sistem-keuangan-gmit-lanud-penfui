using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database
{
    internal class AppDbContext : DbContext, IUnitOfWork
    {
        private readonly ILogger<AppDbContext> _logger;

        public AppDbContext(DbContextOptions<AppDbContext> options, ILogger<AppDbContext> logger) : base(options)
        {
            _logger = logger;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public async new Task<Result<int>> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unexpected Exception When Try SaveChanges. Message : {@message}. At : {@time}", ex.Message, DateTime.Now);

                return new Error("SaveChangesAsync.Failed", 
                    "Terjadi masalah tidak terduga saat coba simpan ke database. Laporkan masalah ke admin!");
            }
        }

        public DbSet<Akun> TblAkun { get; set; }
        public DbSet<JenisAkun> TblJenisAkun { get; set; }
        public DbSet<KelompokAkun> TblKelompokAkun { get; set; }
        public DbSet<GolonganAkun> TblGolonganAkun { get; set; }
        public DbSet<RAPBJ> TblRAPBJ { get; set; }
        public DbSet<DetailRAPBJ> TblDetailRAPBJ { get; set; }
        public DbSet<Belanja> TblBelanja { get; set; }
        public DbSet<Penerimaan> TblPenerimaan { get; set; }
        public DbSet<User> TblUser { get; set; }
    }
}
