using Microsoft.AspNetCore.Http;
using SIKeuanganGMITLanudPenfui.Domain.Shared;

namespace SIKeuanganGMITLanudPenfui.Infrastructure.Services.FileUpload;

public interface IFileUploadService
{
    Task<Result<Uri>> UploadFile<TModel>(IFormFile formFile, string folderPath, string[] permittedExtension, long minSizeLimit, long maxSizeLimit);
}
