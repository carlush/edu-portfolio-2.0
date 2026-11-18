using System.ComponentModel.DataAnnotations;
using TestingPlatform.Domain.Enums;

namespace practice.Requests.Test;

public class UpdateTestRequest
{
    public int Id { get; set; }
    [Required] public string Title { get; set; } = null!;
    [Required] public string Description { get; set; } = null!;
    public bool IsRepeatable { get; set; }
    [Required] public TestType Type { get; set; }
    public DateTime PublishedAt { get; set; }
    public DateTime Deadline { get; set; }
    public int? DurationMinutes { get; set; }
    public bool IsPublic { get; set; }
    public int? PassingScore { get; set; }
    public int? MaxAttempts { get; set; }
    public List<int> Students { get; set; } = new();
    public List<int> Projects { get; set; } = new();
    public List<int> Courses { get; set; } = new();
    public List<int> Groups { get; set; } = new();
    public List<int> Directions { get; set; } = new();
}