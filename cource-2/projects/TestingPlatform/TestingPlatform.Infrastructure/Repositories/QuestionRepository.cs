using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Application.Interfaces;
using TestingPlatform.Domain.Models;
using TestingPlatform.Infrastructure.Exceptions;
using TestingPlatform.Migrations;

namespace TestingPlatform.Infrastructure.Repositories;

public class QuestionRepository(AppDbContext appDbContext, IMapper mapper) : IQuestionRepository
{
    public async Task<IEnumerable<QuestionDto>> GetAllAsync()
    {
        var questions = await appDbContext.Questions
            .AsNoTracking()
            .ToListAsync();

        return mapper.Map<IEnumerable<QuestionDto>>(questions);
    }

    public async Task<QuestionDto> GetByIdAsync(int id)
    {
        var question = await appDbContext.Questions
            .AsNoTracking()
            .FirstOrDefaultAsync(q => q.Id == id);

        if (question is null)
            throw new EntityNotFoundException("Вопрос не найден.");

        return mapper.Map<QuestionDto>(question);
    }

    public async Task<int> CreateAsync(QuestionDto questionDto)
    {
        var question = mapper.Map<Question>(questionDto);

        await appDbContext.AddAsync(question);
        await appDbContext.SaveChangesAsync();

        return question.Id;
    }

    public async Task UpdateAsync(QuestionDto questionDto)
    {
        var question = await appDbContext.Questions.FirstOrDefaultAsync(q => q.Id == questionDto.Id);

        if (question is null)
            throw new EntityNotFoundException("Вопрос не найден.");

        question.Text = questionDto.Text;
        question.Number = questionDto.Number;
        question.Description = questionDto.Description;
        question.AnswerType = questionDto.AnswerType;
        question.IsScoring = questionDto.IsScoring;
        question.MaxScore = questionDto.MaxScore;
        question.TestId = questionDto.TestId;

        await appDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var question = await appDbContext.Questions.FirstOrDefaultAsync(q => q.Id == id);

        if (question is null)
            throw new EntityNotFoundException("Вопрос не найден.");

        appDbContext.Questions.Remove(question);
        await appDbContext.SaveChangesAsync();
    }
}