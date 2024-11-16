using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;
using SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class DetailRAPBJConfiguration : IEntityTypeConfiguration<DetailRAPBJ>
{
    public void Configure(EntityTypeBuilder<DetailRAPBJ> builder)
    {
        builder.HasKey(d => new { d.TahunRAPBJ, d.KodeAkun });
        builder.Property(r => r.TahunRAPBJ).HasConversion<TahunIntConverter>();
        builder.HasOne(d => d.RAPBJ).WithMany(d => d.DaftarDetailRAPBJ).HasForeignKey(d => d.TahunRAPBJ);
        builder.HasOne(d => d.Akun).WithMany().HasForeignKey(d => d.KodeAkun);
    }
}
