using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Role> Roles { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<SurveyType> SurveyTypes { get; set; }
    public DbSet<Survey> Surveys  { get; set; }
    public DbSet<QuestionType> QuestionTypes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionOption> QuestionOptions { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<InviteCode> InviteCodes { get; set; }
    public DbSet<Response> Responses { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<AnswerOption> AnswerOptions { get; set; }
    
}

