using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class JenisAkunConfiguration : IEntityTypeConfiguration<JenisAkun>
{
    public void Configure(EntityTypeBuilder<JenisAkun> builder)
    {
        builder.HasKey(j => j.Id);
        builder.HasMany(j => j.DaftarAkun).WithOne(a => a.JenisAkun).IsRequired().OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(j => j.DaftarKelompokAkun).WithOne(k => k.JenisAkun).IsRequired().OnDelete(DeleteBehavior.Cascade);
        builder.Property(j => j.Tahun).HasConversion<TahunIntConverter>();
    }
}
