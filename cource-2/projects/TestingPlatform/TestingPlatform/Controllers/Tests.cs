using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using practice.Requests.Test;
using practice.Responses.Test;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Application.Interfaces;

namespace TestingPlatform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestsController(ITestRepository testRepository, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTests()
    {
        var tests = await testRepository.GetAllAsync();
        return Ok(mapper.Map<IEnumerable<TestResponse>>(tests));
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTestById(int id)
    {
        var test = await testRepository.GetByIdAsync(id);
        return Ok(mapper.Map<TestResponse>(test));
    }

    [HttpPost]
    public async Task<IActionResult> CreateTest([FromBody] CreateTestRequest request)
    {
        var testDto = mapper.Map<TestDto>(request);
        var testId = await testRepository.CreateAsync(testDto);
        return StatusCode(StatusCodes.Status201Created, new { Id = testId });
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTest([FromBody] UpdateTestRequest request)
    {
        await testRepository.UpdateAsync(mapper.Map<TestDto>(request));
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTest(int id)
    {
        await testRepository.DeleteAsync(id);
        return NoContent();
    }
}