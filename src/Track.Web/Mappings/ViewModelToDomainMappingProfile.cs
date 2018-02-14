using AutoMapper;
using Track.Model.Models;
using Track.Web.ViewModels;

namespace Track.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProjectViewModel, Project>();
        }

        public override string ProfileName => GetType().Name;
    }
}