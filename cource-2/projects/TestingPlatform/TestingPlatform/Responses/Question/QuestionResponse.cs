using TestingPlatform.Domain.Enums;

namespace practice.Responses.Question;

public class QuestionResponse
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
    public int Number { get; set; }
    public string? Description { get; set; }
    public AnswerType AnswerType { get; set; }
    public bool IsScoring { get; set; }
    public int? MaxScore { get; set; }
    public int TestId { get; set; }
}