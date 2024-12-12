using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class InformasiGerejaConfiguration : IEntityTypeConfiguration<InformasiGereja>
{
    public void Configure(EntityTypeBuilder<InformasiGereja> builder)
    {
        builder.HasKey(i => i.Tahun);
        builder.Property(i => i.Tahun).ValueGeneratedNever();
        builder.Property(i => i.Tahun).HasConversion<TahunIntConverter>();
    }
}
