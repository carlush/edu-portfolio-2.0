using Microsoft.EntityFrameworkCore;
using practice.Models;

namespace TestingPlatform.Data;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // (необязательно) первичные данные, появятся после миграции
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, Login = "vanya123", Email = "vanya123@mail.com", FirstName = "Иван", MiddleName = "Иванович", LastName = "Иванов", Phone = "+71234567890", VkProfileLink = "http://vk.com/vanya123", CreatedAt = DateTimeOffset.Parse("2026-06-07T14:40:00+03:00") },
            new Student { Id = 2, Login = "maria", Email = "maria@mail.com", FirstName = "Мария", MiddleName = "Ивановна", LastName = "Иванова", Phone = "+71234567899", VkProfileLink = "http://vk.com/vanya123", CreatedAt = DateTimeOffset.Parse("2026-06-09T16:30:00+03:00") }
        );
    }
}
