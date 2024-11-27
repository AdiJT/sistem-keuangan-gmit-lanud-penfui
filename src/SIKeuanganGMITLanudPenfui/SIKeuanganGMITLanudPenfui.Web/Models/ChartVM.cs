using System.ComponentModel.DataAnnotations;

namespace SIKeuanganGMITLanudPenfui.Web.Models;

public class ChartVM
{
    public string Id { get; } = $"chart{string.Join("", Guid.NewGuid().ToString().Split("-"))}";
    public Dictionary<string, double> Data { get; set; } = new Dictionary<string, double>();
    public string Label { get; set; } = string.Empty;
    public ChartType Type { get; set; }
}

public enum ChartType
{
    [Display(Name = "doughnut", Description = "doughnut")]
    Doughnut,
    [Display(Name = "pie", Description = "pie")]
    Pie,
    [Display(Name = "polarArea", Description = "polarArea")]
    PolarArea,
    [Display(Name = "line", Description = "line")]
    Line,
    [Display(Name = "bar", Description = "bar")]
    Bar
}