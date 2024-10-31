using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class KelompokAkunConfiguration : IEntityTypeConfiguration<KelompokAkun>
{
    public void Configure(EntityTypeBuilder<KelompokAkun> builder)
    {
        builder.HasKey(k => k.Id);
        builder.HasOne(k => k.JenisAkun).WithMany(j => j.DaftarKelompokAkun).IsRequired();
        builder.HasMany(k => k.DaftarGolonganAkun).WithOne(g => g.KelompokAkun).IsRequired();
        builder.HasMany(k => k.DaftarAkun).WithOne(a => a.KelompokAkun).IsRequired(false);
    }
}
