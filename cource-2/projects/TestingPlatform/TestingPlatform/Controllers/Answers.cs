using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using practice.Requests.Answer;
using practice.Responses.Answer;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Application.Interfaces;

namespace TestingPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnswersController(IAnswerRepository answerRepository, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAnswers()
    {
        var answers = await answerRepository.GetAllAsync();
        return Ok(mapper.Map<IEnumerable<AnswerResponse>>(answers));
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAnswerById(int id)
    {
        var answer = await answerRepository.GetByIdAsync(id);
        return Ok(mapper.Map<AnswerResponse>(answer));
    }

    [HttpPost]
    public async Task<IActionResult> CreateAnswer([FromBody] CreateAnswerRequest request)
    {
        var answerDto = mapper.Map<AnswerDto>(request);
        var answerId = await answerRepository.CreateAsync(answerDto);
        return StatusCode(StatusCodes.Status201Created, new { Id = answerId });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAnswer([FromBody] UpdateAnswerRequest request)
    {
        await answerRepository.UpdateAsync(mapper.Map<AnswerDto>(request));
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAnswer(int id)
    {
        await answerRepository.DeleteAsync(id);
        return NoContent();
    }
}