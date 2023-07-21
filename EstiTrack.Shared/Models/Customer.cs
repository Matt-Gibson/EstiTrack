using System.ComponentModel.DataAnnotations;
namespace EstiTrack.Shared.Models;

public class Customer
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public string PhoneNumber { get; set; } = string.Empty;
    public bool Active { get; set; }
}
