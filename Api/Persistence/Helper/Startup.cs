using Application.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Service.Implementation;
using Persistence.Service.Interface;

namespace Persistence.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceDescriptors"></param>
        /// <param name="configuration"></param>
        public static IServiceCollection InjectPersistence(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {


            serviceDescriptors.InjectApplication(configuration);
            serviceDescriptors.AddScoped<IUserService, UserService>();

            return serviceDescriptors;
        }
    }
}
