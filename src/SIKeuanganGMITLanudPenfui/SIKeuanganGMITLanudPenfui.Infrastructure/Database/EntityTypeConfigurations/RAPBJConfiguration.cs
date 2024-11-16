using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class RAPBJConfiguration : IEntityTypeConfiguration<RAPBJ>
{
    public void Configure(EntityTypeBuilder<RAPBJ> builder)
    {
        builder.HasKey(r => r.Tahun);
        builder.Property(r => r.Tahun).ValueGeneratedNever();
        builder.Property(r => r.Tahun).HasConversion<TahunIntConverter>();
        builder.HasMany(r => r.DaftarDetailRAPBJ).WithOne(r => r.RAPBJ);
    }
}
