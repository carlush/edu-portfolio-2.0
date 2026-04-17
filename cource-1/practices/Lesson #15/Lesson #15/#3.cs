using System;
using System.Collections.Generic;
using System.Text;

public interface IDocumentExporter
{
    string FormatName { get; }
    void Export(string content);

    void ShowInfo(string content)
    {
        Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
    }
}
public class TxtExporter : IDocumentExporter
{
    public string FormatName => "TXT";
    public void Export(string content)
    {
        Console.WriteLine("Сохраняем текстовый файл...");
    }
}

public class PdfExporter : IDocumentExporter
{
    public string FormatName => "PDF";
    public void Export(string content)
    {
        Console.WriteLine("Создаём PDF-документ...");
    }
}

