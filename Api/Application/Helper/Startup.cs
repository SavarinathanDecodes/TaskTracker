using Application.Context;
using Application.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;

namespace Application.Helper
{
    /// <summary>
    /// Application layer startup file
    /// </summary>
    public static class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceDescriptors"></param>
        /// <param name="configuration"></param>
        public static IServiceCollection InjectApplication(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("Data Source=UT-LTP-887;Initial Catalog=TaskManagement;Persist Security Info=True;User ID=sa;Password=Utthunga@2024;Trust Server Certificate=True"),
                   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            serviceDescriptors.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>()!);

            serviceDescriptors.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            return serviceDescriptors;
        }
    }
}
