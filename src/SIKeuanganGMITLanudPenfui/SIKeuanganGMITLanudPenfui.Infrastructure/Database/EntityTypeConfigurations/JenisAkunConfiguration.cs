using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class JenisAkunConfiguration : IEntityTypeConfiguration<JenisAkun>
{
    public void Configure(EntityTypeBuilder<JenisAkun> builder)
    {
        builder.HasKey(j => j.Id);
        builder.HasMany(j => j.DaftarAkun).WithOne(a => a.JenisAkun).IsRequired();
        builder.HasMany(j => j.DaftarKelompokAkun).WithOne(k => k.JenisAkun).IsRequired();
    }
}
