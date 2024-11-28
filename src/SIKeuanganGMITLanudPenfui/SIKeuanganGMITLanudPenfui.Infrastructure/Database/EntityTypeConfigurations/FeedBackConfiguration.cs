using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
{
    public void Configure(EntityTypeBuilder<FeedBack> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Tanggal).HasColumnType("timestamp without time zone");
    }
}
