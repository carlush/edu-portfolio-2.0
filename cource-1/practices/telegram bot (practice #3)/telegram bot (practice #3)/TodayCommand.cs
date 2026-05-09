using Telegram.Bot;
using Telegram.Bot.Types;
using System.Globalization;

namespace ScheduleBot;

public class TodayCommand : ICommand
{
    private readonly JsonScheduleRepository _repo;
    public TodayCommand(JsonScheduleRepository repo) => _repo = repo;

    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        var text = update.Message?.Text ?? "";
        var parts = text.Split(' ');
        if (parts.Length < 2) return;

        var schedule = _repo.Load();
        var inputGroup = parts[1].Trim();
        var group = schedule.Groups.FirstOrDefault(g => g.Group.Trim().Equals(inputGroup, StringComparison.OrdinalIgnoreCase));

        if (group == null)
        {
            await botClient.SendTextMessageAsync(update.Message!.Chat.Id, "Группа не найдена.", cancellationToken: ct);
            return;
        }

        string dayName = DateTime.Now.ToString("dddd", new CultureInfo("ru-RU")).ToLower();
        var day = group.Days.FirstOrDefault(d => d.Day.Trim().ToLower() == dayName);

        string msg = (day != null && day.Lessons.Any())
            ? $"📖 Сегодня ({dayName}):\n" + string.Join("\n", day.Lessons.Select(l => $"{l.Time}: {l.Subject}"))
            : $"На сегодня ({dayName}) уроков нет.";

        await botClient.SendTextMessageAsync(update.Message!.Chat.Id, msg, cancellationToken: ct);
    }
}