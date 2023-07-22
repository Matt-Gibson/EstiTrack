using System.ComponentModel.DataAnnotations;
namespace EstiTrack.Shared.Models;

public class Estimate
{
    public int Id { get; set; }

    [Required]
    public DateOnly DateCreated { get; set; }

    [Required]
    public DateOnly DateUpdated { get; set; }

    [Required]
    [StringLength(50)]
    public required String JobType { get; set; }

    [Required]
    [StringLength(20)]
    [MinLength(2)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    [MinLength(2)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(20)]
    public string PhoneNumber { get; set; } = string.Empty;

    public required bool IsRush { get; set; }
}