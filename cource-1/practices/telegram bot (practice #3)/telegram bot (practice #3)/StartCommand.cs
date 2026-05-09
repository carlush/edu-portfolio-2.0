using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ScheduleBot;

public class StartCommand : ICommand
{
    public async Task ExecuteAsync(Update update, ITelegramBotClient botClient, CancellationToken ct)
    {
        await botClient.SendTextMessageAsync(update.Message!.Chat.Id, "Бот запущен. /help для списка.", cancellationToken: ct);
    }
}