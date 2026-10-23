using System.ComponentModel.DataAnnotations;
using TestingPlatform.Domain.Enums;

namespace TestingPlatform.Requests.User;

public class CreateUserRequest
{
    [Required] public string Login { get; set; } = null!;
    [Required] public string Password { get; set; } = null!;
    [Required, EmailAddress] public string Email { get; set; } = null!;
    [Required] public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    [Required] public string LastName { get; set; } = null!;
    [Required] public UserRole Role { get; set; }
}