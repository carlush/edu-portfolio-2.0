using Telegram.Bot;
using Telegram.Bot.Types;

namespace ScheduleBot;

public class WeekCommand : ICommand
{
    private readonly JsonScheduleRepository _repo;
    public WeekCommand(JsonScheduleRepository repo) => _repo = repo;

    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        var text = update.Message?.Text ?? "";
        var parts = text.Split(' ');

        if (parts.Length < 2)
        {
            await botClient.SendTextMessageAsync(update.Message!.Chat.Id, "Пиши: /week 9А", cancellationToken: ct);
            return;
        }

        var schedule = _repo.Load();
        var inputGroup = parts[1].Trim();
        var group = schedule.Groups.FirstOrDefault(g =>
            g.Group.Trim().Equals(inputGroup, StringComparison.OrdinalIgnoreCase));

        if (group == null)
        {
            await botClient.SendTextMessageAsync(update.Message!.Chat.Id, $"Группа '{inputGroup}' не найдена.", cancellationToken: ct);
            return;
        }

        var res = $"📅 Расписание {group.Group}:\n" + string.Join("\n", group.Days.Select(d =>
            $"\n● {d.Day.ToUpper()}:\n" + (d.Lessons.Any()
                ? string.Join("\n", d.Lessons.Select(l => $"{l.Time} - {l.Subject}"))
                : "выходной")));

        await botClient.SendTextMessageAsync(update.Message!.Chat.Id, res, cancellationToken: ct);
    }
}