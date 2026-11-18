using System.ComponentModel.DataAnnotations;
using TestingPlatform.Domain.Enums;

namespace practice.Requests.Question;

public class CreateQuestionRequest
{
    [Required] public string Text { get; set; } = null!;
    [Required] public int Number { get; set; }
    public string? Description { get; set; }
    [Required] public AnswerType AnswerType { get; set; }
    public bool IsScoring { get; set; }
    public int? MaxScore { get; set; }
    [Required] public int TestId { get; set; }
}