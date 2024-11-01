using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class RAPBJConfiguration : IEntityTypeConfiguration<RAPBJ>
{
    public void Configure(EntityTypeBuilder<RAPBJ> builder)
    {
        builder.HasKey(r => r.Tahun);
        builder.Property(r => r.Tahun).ValueGeneratedNever();
        builder.HasMany(r => r.DaftarDetailRAPBJ).WithOne(r => r.RAPBJ);
    }
}
