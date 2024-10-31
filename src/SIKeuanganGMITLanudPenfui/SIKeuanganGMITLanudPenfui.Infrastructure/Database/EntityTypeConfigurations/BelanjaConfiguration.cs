using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class BelanjaConfiguration : IEntityTypeConfiguration<Belanja>
{
    public void Configure(EntityTypeBuilder<Belanja> builder)
    {
        builder.HasKey(b => b.Id);
        builder.HasOne(b => b.Akun).WithMany();
    }
}
