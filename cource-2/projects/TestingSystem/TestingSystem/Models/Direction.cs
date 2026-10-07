using TestingSystem.Controllers;

public class Direction
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Group> Groups { get; set; } = new();
    public List<Test> Tests { get; set; } = new();
}
