using Telegram.Bot;
using Telegram.Bot.Types;

namespace ScheduleBot;

public class CommandDispatcher
{
    private readonly Dictionary<string, ICommand> _commands = new(StringComparer.OrdinalIgnoreCase);

    public void Register(string trigger, ICommand command) => _commands[trigger] = command;

    public async Task DispatchAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        if (update.Message?.Text == null) return;
        var parts = update.Message.Text.Trim().Split(' ');
        var cmd = parts[0].ToLower();

        if (_commands.TryGetValue(cmd, out var command))
        {
            await command.ExecuteAsync(update, botClient, ct);
        }
        else
        {
            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Неизвестная команда.", cancellationToken: ct);
        }
    }
}