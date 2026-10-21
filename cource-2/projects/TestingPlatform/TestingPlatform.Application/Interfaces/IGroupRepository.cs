using TestingPlatform.Application.Dtos;

namespace TestingPlatform.Application.Interfaces;

public interface IGroupRepository
{
    /// <summary>
    /// Получить все группы.
    /// </summary>
    /// <returns>Массив групп.</returns>
    Task<List<GroupDto>> GetAllAsync();

    /// <summary>
    /// Получить группу по id.
    /// </summary>
    /// <param name="id">Идентификатор группы</param>
    /// <returns></returns>
    Task<GroupDto> GetByIdAsync(int id);

    /// <summary>
    /// Создать новую группу.
    /// </summary>
    /// <param name="groupDto">Модель создания новой группы.</param>
    /// <returns>Идентификатор новой группы .</returns>
    Task<int> CreateAsync(GroupDto groupDto);

    /// <summary>
    /// Обновить информацию о группе.
    /// </summary>
    /// <param name="groupDto">Модель обновления группы.</param>
    Task UpdateAsync(GroupDto groupDto);

    /// <summary>
    /// Удалить группу.
    /// </summary>
    /// <param name="id">Идентификатор группы.</param>
    Task DeleteAsync(int id);
}

