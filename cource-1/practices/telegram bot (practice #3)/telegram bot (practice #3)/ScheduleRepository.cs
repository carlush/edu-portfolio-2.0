using System.Text.Json;

namespace ScheduleBot;

public class JsonScheduleRepository
{
    private readonly string _path;
    public JsonScheduleRepository(string path) => _path = path;

    public ScheduleFile Load()
    {
        if (!File.Exists(_path))
        {
            Console.WriteLine($"[ОШИБКА] Файл не найден по пути: {Path.GetFullPath(_path)}");
            return new ScheduleFile();
        }

        try
        {
            var json = File.ReadAllText(_path);
            var data = JsonSerializer.Deserialize<ScheduleFile>(json);

            if (data == null || data.Groups.Count == 0)
                Console.WriteLine("[ВНИМАНИЕ] JSON прочитан, но групп внутри нет.");
            else
                Console.WriteLine($"[OK] Загружено групп: {data.Groups.Count}. Первая группа: '{data.Groups[0].Group}'");

            return data ?? new ScheduleFile();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ОШИБКА] Не удалось распарсить JSON: {ex.Message}");
            return new ScheduleFile();
        }
    }
}