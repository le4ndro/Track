using AutoMapper;

namespace Track.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(typeof(AutoMapperConfiguration).Assembly));
            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}