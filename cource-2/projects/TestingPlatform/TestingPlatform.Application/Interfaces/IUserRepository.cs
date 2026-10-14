using TestingPlatform.Domain.Models;

namespace TestingPlatform.Application.Interfaces;

public interface IUserRepository
{
    /// <summary>
    /// Получить всех пользователей.
    /// </summary>
    /// <returns>Список пользователей.</returns>
    List<User> GetAll();

    /// <summary>
    /// Получить пользователя по id.
    /// </summary>
    /// <param name="id">Идентификатор пользователя.</param>
    /// <returns>Пользователь.</returns>
    User GetById(int id);

    /// <summary>
    /// Создать нового пользователя.
    /// </summary>
    /// <param name="user">Модель создания нового пользователя.</param>
    /// <returns>Идентификатор нового пользователя.</returns>
    int Create(User user);

    /// <summary>
    /// Обновить информацию о пользователе.
    /// </summary>
    /// <param name="user">Модель обновления пользователя.</param>
    void Update(User user);

    /// <summary>
    /// Удалить пользователя.
    /// </summary>
    /// <param name="id">Идентификатор пользователя.</param>
    void Delete(int id);
}
