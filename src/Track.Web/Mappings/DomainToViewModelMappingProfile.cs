using AutoMapper;
using Track.Model.Models;
using Track.Web.ViewModels;

namespace Track.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Project, ProjectViewModel>();
        }

        public override string ProfileName => GetType().Name;
    }
}