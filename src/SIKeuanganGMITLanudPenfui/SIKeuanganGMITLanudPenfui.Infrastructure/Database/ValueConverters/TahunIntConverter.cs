using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Database.ValueConverters;

internal class TahunIntConverter : ValueConverter<Tahun, int>
{
    public TahunIntConverter() : 
        base(t => t.Value, i => Tahun.Create(i).Value, null)
    {
    }
}
