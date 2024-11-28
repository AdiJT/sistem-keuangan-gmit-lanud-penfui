using SIKeuanganGMITLanudPenfui.Domain.Abstracts;

namespace SIKeuanganGMITLanudPenfui.Domain.Entities;

public class FeedBack : Entity
{
    public required string Nama { get; set; }
    public required string Judul { get; set; }
    public required string Pesan { get; set; }
    public required DateTime Tanggal { get; set; }
    public required bool SudahDibaca { get; set; }
}
