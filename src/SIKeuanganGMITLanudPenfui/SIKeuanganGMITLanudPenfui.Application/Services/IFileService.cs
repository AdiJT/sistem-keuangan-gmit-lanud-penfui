using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Application.Services;

public interface IFileService
{
    bool IsExist(Uri uri);
    Result Delete(Uri uri);
}
