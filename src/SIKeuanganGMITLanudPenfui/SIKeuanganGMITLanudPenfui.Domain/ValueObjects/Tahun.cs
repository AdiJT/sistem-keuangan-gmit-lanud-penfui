using SIKeuanganGMITLanudPenfui.Domain.Abstracts;
using SIKeuanganGMITLanudPenfui.Domain.Errors;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Domain.ValueObjects;

public class Tahun : ValueObject
{
    public int Value { get; }

    private Tahun(int tahun) => Value = tahun;

    public static Result<Tahun> Create(int tahun)
    {
        if (tahun < 0)
            return TahunErrors.TahunNegative;

        return new Tahun(tahun);
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
