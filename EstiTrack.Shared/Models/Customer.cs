using System.ComponentModel.DataAnnotations;
namespace EstiTrack.Shared.Models;

public class Customer
{
    public int Id { get; set; }

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

    public bool Active { get; set; }
}
