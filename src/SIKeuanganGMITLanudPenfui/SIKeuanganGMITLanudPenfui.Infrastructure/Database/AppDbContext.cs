using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database;

internal class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(IAuditableEntity).IsAssignableFrom(entityType.ClrType))
            {
                modelBuilder.Entity(entityType.ClrType).Property(nameof(IAuditableEntity.TanggalDitambahkan))
                    .HasColumnType("timestamp without time zone");
                modelBuilder.Entity(entityType.ClrType).Property(nameof(IAuditableEntity.TanggalDiubah))
                    .HasColumnType("timestamp without time zone");
            }
        }

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        modelBuilder.SeedingData();

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
    public DbSet<Kas> TblKas { get; set; }
    public DbSet<BuktiTransaksi> TblBuktiTransaksi { get; set; }
}
