using Telegram.Bot;
using Telegram.Bot.Types;

namespace ScheduleBot;

public class HelpCommand : ICommand
{
    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        var chatId = update.Message!.Chat.Id;

        string helpText = "📚 **Доступные команды:**\n\n" +
                          "/start — Начать работу с ботом\n" +
                          "/help — Показать это сообщение\n" +
                          "/week [группа] — Расписание на всю неделю\n" +
                          "/today [группа] — Расписание на текущий день";

        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: helpText,
            parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown,
            cancellationToken: ct
        );
    }
}