using AutoMapper;
using practice.Requests.Test;
using practice.Responses.Test;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class TestProfile : Profile
{
    public TestProfile()
    {
        CreateMap<TestDto, TestResponse>();
        CreateMap<CreateTestRequest, TestDto>();
        CreateMap<UpdateTestRequest, TestDto>();
    }
}