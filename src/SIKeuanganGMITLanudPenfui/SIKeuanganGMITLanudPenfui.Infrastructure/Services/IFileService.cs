using Microsoft.AspNetCore.Http;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Services;

public interface IFileService
{
    bool IsFileExist(string folderPath, string fileName);
    Uri GetFileUri(string folderPath, string fileName);
    Task<Result<string>> UploadFile<TModel>(IFormFile formFile, string folderPath, string[] permittedExtension, long minSizeLimit, long maxSizeLimit);
}
