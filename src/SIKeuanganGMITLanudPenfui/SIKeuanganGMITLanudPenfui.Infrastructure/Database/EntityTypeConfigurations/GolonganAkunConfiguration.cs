using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class GolonganAkunConfiguration : IEntityTypeConfiguration<GolonganAkun>
{
    public void Configure(EntityTypeBuilder<GolonganAkun> builder)
    {
        builder.HasKey(g => g.Id);
        builder.HasOne(g => g.KelompokAkun).WithMany(k => k.DaftarGolonganAkun).IsRequired();
        builder.HasMany(g => g.DaftarAkun).WithOne(a => a.GolonganAkun).IsRequired(false);
        builder.Property(g => g.Tahun).HasConversion<TahunIntConverter>();
    }
}
