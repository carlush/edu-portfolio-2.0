using System;
using System.Collections.Generic;
using System.Text;

public interface IReadable
{
    void Read(string filename);
}

public interface IWritable
{
    void Write(string filename, string content);
}

public interface ISavable
{
    void Save();
}
public class TextDocument : IReadable, IWritable, ISavable
{
    private string content;

    public void Read(string filename)
    {
        Console.WriteLine($"Чтение из файла {filename}");
        content = "Текст из файла";
    }

    public void Write(string filename, string content)
    {
        Console.WriteLine($"Запись в файл {filename}: {content}");
        this.content = content;
    }

    public void Save()
    {
        Console.WriteLine($"Файл сохранён. Содержимое: {content}");
    }
}
