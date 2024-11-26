using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class KasConfiguration : IEntityTypeConfiguration<Kas>
{
    public void Configure(EntityTypeBuilder<Kas> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(x => x.DaftarTransaksi).WithOne(t => t.Kas);
    }
}
