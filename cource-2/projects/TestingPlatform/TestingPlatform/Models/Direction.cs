/// <summary>
/// Направление
/// </summary>
public class Direction
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название направления
    /// </summary>
    public string Name { get; set; }
    ///<summary>
    ///Список групп внутри курса
    /// <summary>
    public List<Group> Groups { get; set; }
}