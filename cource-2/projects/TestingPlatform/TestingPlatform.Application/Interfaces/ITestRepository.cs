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
    /// <summary>
    ///  Получение количества тестов по типам тестов.
    /// </summary>
    Task<IEnumerable<object>> GetTestCountByTypeAsync();

    /// <summary>
    /// Получение статистики по тестам для разных курсов (среднее время и проходной балл).
    /// </summary>
    Task<IEnumerable<object>> GetCourseStatsAsync();

    /// <summary>
    /// Получение среднего проходного балла и длительности для каждого направления (с сортировкой).
    /// </summary>
    Task<IEnumerable<object>> GetDirectionAveragesAsync();

    /// <summary>
    /// Получение статистики по таймлайну тестов в зависимости от публичности и даты публикации.
    /// </summary>
    Task<IEnumerable<object>> GetTestTimelineByPublicAsync();

    /// <summary>
    /// Получение топа групп по количеству тестов (с использованием SelectMany, GroupBy и Take).
    /// </summary>
    /// <param name="top">Количество записей в топе (по умолчанию 10)</param>
    Task<IEnumerable<object>> GetTopGroupsByTestCountAsync(int top = 10);
}

