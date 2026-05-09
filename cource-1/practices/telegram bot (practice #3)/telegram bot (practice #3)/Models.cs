namespace ScheduleBot;

public record Lesson(string Time, string Subject, string Teacher = "");

public class DaySchedule
{
    public string Day { get; set; } = string.Empty;
    public List<Lesson> Lessons { get; set; } = new();
}

public class GroupSchedule
{
    public string Group { get; set; } = string.Empty;
    public List<DaySchedule> Days { get; set; } = new();
}

public class ScheduleFile
{
    public List<GroupSchedule> Groups { get; set; } = new();
}