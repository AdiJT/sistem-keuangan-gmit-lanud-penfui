using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class PenerimaanConfiguration : IEntityTypeConfiguration<Penerimaan>
{
    public void Configure(EntityTypeBuilder<Penerimaan> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasOne(p => p.Akun).WithMany();
        builder.HasOne(b => b.Kas).WithMany();
    }
}
