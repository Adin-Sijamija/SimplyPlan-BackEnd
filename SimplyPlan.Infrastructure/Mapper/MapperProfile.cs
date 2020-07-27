using AutoMapper;
using SimplyPlan.Core.DTOs;
using SimplyPlan.Core.Entities;

namespace SimplyPlan.Infrastructure.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() : base()
        {

            CreateMap<Project, UserProjectsDTO>();
        }
    }
}
