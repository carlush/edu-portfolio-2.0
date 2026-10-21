using AutoMapper;
using TestingPlatform.Responses.Project;
using TestingPlatform.Application.Dtos;

namespace TestingPlatform.Mappings;

public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<ProjectDto, ProjectResponse>();
    }
}

