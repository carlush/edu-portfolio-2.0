using ScheduleBot;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

class Program
{
    static async Task Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var botClient = new TelegramBotClient("8275480122:AAHglv_XNsPne_ec3HPsOscuP0j4_uItSbE");
        var repo = new JsonScheduleRepository("schedule.json");
        var dispatcher = new CommandDispatcher();

        dispatcher.Register("/start", new StartCommand());
        dispatcher.Register("/help", new HelpCommand());
        dispatcher.Register("/week", new WeekCommand(repo));
        dispatcher.Register("/today", new TodayCommand(repo));

        using var cts = new CancellationTokenSource();
        Console.WriteLine("Бот запущен...");

        botClient.StartReceiving(
            async (c, u, ct) => {
                if (u.Message?.Text != null) Console.WriteLine($"{DateTime.Now:HH:mm} | {u.Message.Text}");
                await dispatcher.DispatchAsync(u, c, ct);
            },
            (c, e, ct) => Task.CompletedTask,
            new ReceiverOptions { AllowedUpdates = Array.Empty<UpdateType>() },
            cts.Token
        );

        Console.ReadLine();
        cts.Cancel();
    }
}