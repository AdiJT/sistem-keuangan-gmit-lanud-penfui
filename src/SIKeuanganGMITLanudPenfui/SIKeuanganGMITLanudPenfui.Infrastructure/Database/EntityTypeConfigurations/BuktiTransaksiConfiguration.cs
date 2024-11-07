using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class BuktiTransaksiConfiguration : IEntityTypeConfiguration<BuktiTransaksi>
{
    public void Configure(EntityTypeBuilder<BuktiTransaksi> builder)
    {
        builder.HasKey(x => x.Id);
    }
}
