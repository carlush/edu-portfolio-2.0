using TestingPlatform.Application.Interfaces;
using TestingPlatform.Domain.Models;
using TestingPlatform.Migrations;

namespace TestingPlatform.Infrastructure.Repositories;

public class UserRepository(AppDbContext appDbContext) : IUserRepository
{
    public List<User> GetAll()
    {
        return appDbContext.Users.ToList();
    }

    public User GetById(int id)
    {
        var user = appDbContext.Users.FirstOrDefault(u => u.Id == id);

        if (user == null)
        {
            throw new Exception("Пользователь не найден.");
        }

        return user;
    }

    public int Create(User user)
    {
        appDbContext.Users.Add(user);
        appDbContext.SaveChanges();

        return user.Id;
    }

    public void Update(User user)
    {
        appDbContext.Users.Update(user);
        appDbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var user = appDbContext.Users.FirstOrDefault(u => u.Id == id);

        if (user == null)
        {
            throw new Exception("Пользователь не найден.");
        }

        appDbContext.Users.Remove(user);
        appDbContext.SaveChanges();
    }
}
