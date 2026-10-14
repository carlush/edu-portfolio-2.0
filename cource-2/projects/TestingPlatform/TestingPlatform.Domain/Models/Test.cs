using TestingPlatform.Domain.Enums;
namespace TestingPlatform.Domain.Models;

public class Test
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsRepeatable { get; set; }
    public TestType Type { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset PublishedAt { get; set; }
    public DateTimeOffset Deadline { get; set; }
    public int? DurationMinutes { get; set; }
    public bool IsPublic { get; set; }
    public int? PassingScore { get; set; }
    public int? MaxAttempts { get; set; }
    public List<Question> Questions { get; set; } = new();
    public List<Attempt> Attempts { get; set; } = new();
    public List<TestResult> TestResults { get; set; } = new();
    public List<Student> Students { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<Course> Courses { get; set; } = new();
    public List<Group> Groups { get; set; } = new();
    public List<Direction> Directions { get; set; } = new();
}
