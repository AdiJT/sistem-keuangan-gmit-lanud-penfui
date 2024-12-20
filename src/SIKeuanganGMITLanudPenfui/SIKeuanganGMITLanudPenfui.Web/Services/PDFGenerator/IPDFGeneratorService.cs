namespace SIKeuanganGMITLanudPenfui.Web.Services.PDFGenerator;

public interface IPDFGeneratorService
{
    Task<byte[]> GeneratePDF(string html, string fileName);
}
