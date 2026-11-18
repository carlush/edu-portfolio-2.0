using AutoMapper;
using practice.Requests.Question;
using practice.Responses.Question;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Requests.Question;

namespace TestingPlatform.Mappings;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<QuestionDto, QuestionResponse>();

        CreateMap<CreateQuestionRequest, QuestionDto>()
            .ForMember(d => d.Id, m => m.Ignore())
            .ForMember(d => d.Answers, m => m.Ignore());

        CreateMap<UpdateQuestionRequest, QuestionDto>()
            .ForMember(d => d.Answers, m => m.Ignore());
    }
}