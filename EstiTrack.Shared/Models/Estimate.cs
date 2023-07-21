using System.ComponentModel.DataAnnotations;
namespace EstiTrack.Shared.Models;

public class Estimate
{
    public int Id { get; set; }
    public DateOnly DateCreated { get; set; }
    public DateOnly DateUpdated { get; set; }
    public required Customer Customer { get; set; } = new();

    [Required]
    public required String JobType { get; set; }
    public required bool IsRush { get; set; }
}