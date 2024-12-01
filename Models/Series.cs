using System.ComponentModel.DataAnnotations;

namespace RadzenDebugSite.Models;

public class Series
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    [StringLength(4000)]
    public string SgasComment { get; set; } = string.Empty;

    [StringLength(200)]
    public string WorkingPaperLink { get; set; } = string.Empty;

    public bool IsDu { get; set; }

    public bool IsNu { get; set; }

    public DateTime? AnalysisCompleteDate { get; set; }
}