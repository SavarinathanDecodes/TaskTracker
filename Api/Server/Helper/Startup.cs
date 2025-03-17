using Server.Helper.Mapper;

namespace Server.Helper
{
    public static class Startup
    {
        public static IServiceCollection ServerSetup(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddAutoMapper(typeof(MappingProfile));
            return serviceDescriptors;
        }
    }
}
