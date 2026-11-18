using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using practice.Requests.Question;
using practice.Responses.Question;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Application.Interfaces;
using TestingPlatform.Requests.Question;

namespace practice.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionsController(IQuestionRepository questionRepository, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var questions = await questionRepository.GetAllAsync();
        return Ok(mapper.Map<IEnumerable<QuestionResponse>>(questions));
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var question = await questionRepository.GetByIdAsync(id);
        return Ok(mapper.Map<QuestionResponse>(question));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateQuestionRequest question)
    {
        var id = await questionRepository.CreateAsync(mapper.Map<QuestionDto>(question));
        return StatusCode(StatusCodes.Status201Created, new { id });
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateQuestionRequest question)
    {
        await questionRepository.UpdateAsync(mapper.Map<QuestionDto>(question));
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await questionRepository.DeleteAsync(id);
        return NoContent();
    }
}