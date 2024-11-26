using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIKeuanganGMITLanudPenfui.Domain.Entities;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.EntityTypeConfigurations;

internal class TransaksiConfiguration : IEntityTypeConfiguration<Transaksi>
{
    public void Configure(EntityTypeBuilder<Transaksi> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(t => t.Tanggal).HasColumnType("timestamp without time zone");

        builder.HasOne(b => b.Akun).WithMany();
        builder.HasOne(b => b.Kas).WithMany(k => k.DaftarTransaksi);
    }
}
