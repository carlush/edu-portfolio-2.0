public class PublishingHouse
{
    public string Name { get; set; }

    public PublishingHouse(string name)
    {
        Name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Издательство: {Name}");
    }
}