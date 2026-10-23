using AutoMapper;
using practice.Requests.Answer;
using practice.Responses.Answer;
using TestingPlatform.Application.Dtos;

namespace practice.Mappings;

public class AnswerProfile : Profile
{
    public AnswerProfile()
    {
        CreateMap<AnswerDto, AnswerResponse>();
        CreateMap<CreateAnswerRequest, AnswerDto>();
        CreateMap<UpdateAnswerRequest, AnswerDto>();
    }
}