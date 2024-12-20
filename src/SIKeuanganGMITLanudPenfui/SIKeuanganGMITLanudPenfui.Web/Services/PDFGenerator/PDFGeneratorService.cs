
using Microsoft.AspNetCore.Hosting;
using PuppeteerSharp.Media;
using PuppeteerSharp;

namespace SIKeuanganGMITLanudPenfui.Web.Services.PDFGenerator;

public class PDFGeneratorService : IPDFGeneratorService
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public PDFGeneratorService(IWebHostEnvironment environment)
    {
        _webHostEnvironment = environment;
    }

    public async Task<byte[]> GeneratePDF(string html, string fileName)
    {
        var browserFetcher = new BrowserFetcher();
        await browserFetcher.DownloadAsync();

        using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true, Args = ["--no-sandbox"] });
        using var page = await browser.NewPageAsync();
        await page.SetContentAsync(html);
        var filePath = $"{_webHostEnvironment.WebRootPath}/file/pdf/{fileName}.pdf";
        await page.PdfAsync(filePath, new PdfOptions
        {
            Format = PaperFormat.A4,
            MarginOptions = new MarginOptions
            {
                Bottom = "20px",
                Top = "20px",
                Left = "20px",
                Right = "20px",
            }
        });

        return await File.ReadAllBytesAsync(filePath);
    }
}
