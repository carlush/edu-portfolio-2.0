using Microsoft.EntityFrameworkCore;
using TestingPlatform.Domain.Models;
using TestingPlatform.Domain.Enums;

namespace TestingPlatform.Migrations;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Group> Groups => Set<Group>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Direction> Directions => Set<Direction>();
    public DbSet<Test> Tests => Set<Test>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<Answer> Answers => Set<Answer>();
    public DbSet<Attempt> Attempts => Set<Attempt>();
    public DbSet<UserAttemptAnswer> UserAttemptAnswers => Set<UserAttemptAnswer>();
    public DbSet<UserSelectedOption> UserSelectedOptions => Set<UserSelectedOption>();
    public DbSet<UserTextAnswer> UserTextAnswers => Set<UserTextAnswer>();
    public DbSet<TestResult> TestResults => Set<TestResult>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        base.OnModelCreating(b);

        b.Entity<User>(e =>
        {
            e.Property(x => x.Login).IsRequired();
            e.Property(x => x.PasswordHash).IsRequired();
            e.Property(x => x.Email).IsRequired();
            e.Property(x => x.FirstName).IsRequired();
            e.Property(x => x.LastName).IsRequired();
            e.Property(x => x.Role).HasConversion<string>();
            e.Property(x => x.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
            e.HasIndex(x => x.Login).IsUnique();
            e.HasIndex(x => x.Email).IsUnique();

            e.HasOne(x => x.Student)
             .WithOne(s => s.User)
             .HasForeignKey<Student>(s => s.UserId)
             .OnDelete(DeleteBehavior.Cascade);
        });

        b.Entity<Student>(e =>
        {
            e.Property(x => x.Phone).IsRequired().HasMaxLength(30);
            e.Property(x => x.VkProfileLink).IsRequired();
            e.HasIndex(x => x.UserId).IsUnique();

            e.HasMany(x => x.Groups).WithMany(g => g.Students)
             .UsingEntity(j => j.ToTable("group_students"));
        });

        b.Entity<Group>(e =>
        {
            e.Property(x => x.Name).IsRequired();
            e.HasIndex(x => x.Name).IsUnique();

            e.HasOne(x => x.Direction).WithMany(d => d.Groups)
             .HasForeignKey(x => x.DirectionId).OnDelete(DeleteBehavior.Restrict);
            e.HasOne(x => x.Course).WithMany(c => c.Groups)
             .HasForeignKey(x => x.CourseId).OnDelete(DeleteBehavior.Restrict);
            e.HasOne(x => x.Project).WithMany(p => p.Groups)
             .HasForeignKey(x => x.ProjectId).OnDelete(DeleteBehavior.Restrict);
        });

        b.Entity<Course>(e =>
        {
            e.Property(x => x.Name).IsRequired();
            e.HasIndex(x => x.Name).IsUnique();
        });

        b.Entity<Project>(e =>
        {
            e.Property(x => x.Name).IsRequired();
            e.HasIndex(x => x.Name).IsUnique();
        });

        b.Entity<Direction>(e =>
        {
            e.Property(x => x.Name).IsRequired();
            e.HasIndex(x => x.Name).IsUnique();
        });

        b.Entity<Test>(e =>
        {
            e.Property(x => x.Title).IsRequired();
            e.Property(x => x.Description).IsRequired();
            e.Property(x => x.Type).HasConversion<string>();
            e.Property(x => x.IsRepeatable).HasDefaultValue(false);
            e.Property(x => x.IsPublic).HasDefaultValue(false);
            e.Property(x => x.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

            e.HasMany(x => x.Questions).WithOne(q => q.Test)
             .HasForeignKey(q => q.TestId).OnDelete(DeleteBehavior.Cascade);

            e.HasMany(x => x.Students).WithMany(s => s.Tests)
             .UsingEntity(j => j.ToTable("test_students"));
            e.HasMany(x => x.Projects).WithMany(p => p.Tests)
             .UsingEntity(j => j.ToTable("test_projects"));
            e.HasMany(x => x.Courses).WithMany(c => c.Tests)
             .UsingEntity(j => j.ToTable("test_courses"));
            e.HasMany(x => x.Groups).WithMany(g => g.Tests)
             .UsingEntity(j => j.ToTable("test_groups"));
            e.HasMany(x => x.Directions).WithMany(d => d.Tests)
             .UsingEntity(j => j.ToTable("test_directions"));
        });

        b.Entity<Question>(e =>
        {
            e.Property(x => x.Text).IsRequired();
            e.Property(x => x.Description).HasMaxLength(2000);
            e.Property(x => x.AnswerType).HasConversion<string>();
            e.Property(x => x.IsScoring).HasDefaultValue(true);
            e.HasIndex(x => new { x.TestId, x.Number }).IsUnique();
        });

        b.Entity<Answer>(e =>
        {
            e.Property(x => x.Text).IsRequired();
            e.HasOne(x => x.Question).WithMany(q => q.Answers)
             .HasForeignKey(x => x.QuestionId).OnDelete(DeleteBehavior.Cascade);
        });

        b.Entity<Attempt>(e =>
        {
            e.Property(x => x.StartedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
            e.HasOne(x => x.Test).WithMany(t => t.Attempts)
             .HasForeignKey(x => x.TestId).OnDelete(DeleteBehavior.Restrict);
            e.HasOne(x => x.Student).WithMany(s => s.Attempts)
             .HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.Cascade);
        });

        b.Entity<UserAttemptAnswer>(e =>
        {
            e.HasOne(x => x.Attempt).WithMany(a => a.UserAttemptAnswers)
             .HasForeignKey(x => x.AttemptId).OnDelete(DeleteBehavior.Cascade);
            e.HasOne(x => x.Question).WithMany(q => q.UserAttemptAnswers)
             .HasForeignKey(x => x.QuestionId).OnDelete(DeleteBehavior.Restrict);
            e.HasIndex(x => new { x.AttemptId, x.QuestionId }).IsUnique();
        });

        b.Entity<UserSelectedOption>(e =>
        {
            e.HasOne(x => x.UserAttemptAnswer).WithMany(a => a.UserSelectedOptions)
             .HasForeignKey(x => x.UserAttemptAnswerId).OnDelete(DeleteBehavior.Cascade);
            e.HasOne(x => x.Answer).WithMany(a => a.UserSelectedOptions)
             .HasForeignKey(x => x.AnswerId).OnDelete(DeleteBehavior.Restrict);
        });

        b.Entity<UserTextAnswer>(e =>
        {
            e.Property(x => x.TextAnswer).IsRequired();
            e.HasOne(x => x.UserAttemptAnswer).WithOne(a => a.UserTextAnswer)
             .HasForeignKey<UserTextAnswer>(x => x.UserAttemptAnswerId)
             .OnDelete(DeleteBehavior.Cascade);
        });

        b.Entity<TestResult>(e =>
        {
            e.HasOne(x => x.Test).WithMany(t => t.TestResults)
             .HasForeignKey(x => x.TestId).OnDelete(DeleteBehavior.Restrict);
            e.HasOne(x => x.Attempt).WithMany(a => a.TestResults)
             .HasForeignKey(x => x.AttemptId).OnDelete(DeleteBehavior.Cascade);
            e.HasOne(x => x.Student).WithMany(s => s.TestResults)
             .HasForeignKey(x => x.StudentId).OnDelete(DeleteBehavior.Cascade);
            e.HasIndex(x => new { x.TestId, x.StudentId, x.AttemptId }).IsUnique();
        });

        b.Entity<Direction>().HasData(
            new Direction { Id = 1, Name = "Backend" },
            new Direction { Id = 2, Name = "Frontend" },
            new Direction { Id = 3, Name = "QA" },
            new Direction { Id = 4, Name = "Design" });

        b.Entity<Course>().HasData(
            new Course { Id = 1, Name = "1 курс" },
            new Course { Id = 2, Name = "2 курс" },
            new Course { Id = 3, Name = "3 курс" });

        b.Entity<Project>().HasData(
            new Project { Id = 1, Name = "Проект A" },
            new Project { Id = 2, Name = "Проект B" });
    }
}
