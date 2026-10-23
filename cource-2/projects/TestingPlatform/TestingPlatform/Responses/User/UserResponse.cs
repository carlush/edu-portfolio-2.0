using TestingPlatform.Domain.Enums;

namespace TestingPlatform.Responses.User;

public class UserResponse
{
    public int Id { get; set; }
    public string Login { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = null!;
    public UserRole Role { get; set; }
}