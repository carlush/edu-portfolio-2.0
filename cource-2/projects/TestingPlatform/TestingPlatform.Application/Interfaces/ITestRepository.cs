using TestingPlatform.Application.Dtos;

namespace TestingPlatform.Application.Interfaces;

public interface ITestRepository
{
    /// <summary>
    /// Получить все тесты.
    /// </summary>
    /// <param name="isPublic">Опубликован ли тест</param>
    /// <param name="groupIds">Идентификаторы групп</param>
    /// <param name="studentIds">Идентификаторы студентов</param>
    /// <returns>Массив тестов.</returns>
    Task<IEnumerable<TestDto>> GetAllAsync(bool? isPublic, List<int> groupIds, List<int> studentIds);

    /// <summary>
    /// Получить все тесты для студента.
    /// </summary>
    /// <param name="studentId">Идентификатор студента</param>
    /// <returns></returns>
    Task<IEnumerable<TestDto>> GetAllForStudent(int studentId);

    /// <summary>
    /// Получить тест по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор теста.</param>
    /// <returns>Тест.</returns>
    Task<TestDto> GetByIdAsync(int id);

    /// <summary>
    /// Создать новый тест.
    /// </summary>
    /// <param name="testDto">Модель создания нового теста.</param>
    /// <returns>Идентификатор нового теста.</returns>
    Task<int> CreateAsync(TestDto testDto);

    /// <summary>
    /// Обновить информацию о тесте.
    /// </summary>
    /// <param name="testDto">Модель обновления теста.</param>
    Task UpdateAsync(TestDto testDto);

    /// <summary>
    /// Удалить курс.
    /// </summary>
    /// <param name="id">Идентификатор теста.</param>
    Task DeleteAsync(int id);
}

