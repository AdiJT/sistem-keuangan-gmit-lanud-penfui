using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class AkunConfiguration : IEntityTypeConfiguration<Akun>
{
    public void Configure(EntityTypeBuilder<Akun> builder)
    {
        builder.HasKey(a => a.Id);
        builder.HasOne(a => a.JenisAkun).WithMany(j => j.DaftarAkun).IsRequired(true);
        builder.HasOne(a => a.KelompokAkun).WithMany(k => k.DaftarAkun).IsRequired(false);
        builder.HasOne(a => a.GolonganAkun).WithMany(g => g.DaftarAkun).IsRequired(false);
        builder.Property(a => a.Tahun).HasConversion<TahunIntConverter>();
    }
}
