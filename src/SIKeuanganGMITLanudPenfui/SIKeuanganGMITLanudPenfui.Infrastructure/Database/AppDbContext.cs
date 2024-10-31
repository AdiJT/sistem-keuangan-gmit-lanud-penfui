using Microsoft.EntityFrameworkCore;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Domain.Repositories;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database
{
    internal class AppDbContext : DbContext, IUnitOfWork
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

            base.OnModelCreating(modelBuilder);
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
