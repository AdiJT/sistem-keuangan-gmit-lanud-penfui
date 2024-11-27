namespace SIKeuanganGMITLanudPenfui.Web.Areas.Dashboard.Models;

public class DeleteConfirmationModalVM
{
    public string Id { get; set; } = $"modal{string.Join("", Guid.NewGuid().ToString().Split("-"))}";
    public required string Title { get; set; }
    public required string Url { get; set; }
}