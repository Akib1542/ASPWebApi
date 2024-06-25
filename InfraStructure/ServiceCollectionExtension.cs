using Application.Repositories;
using InfraStructure.Contexts;
using InfraStructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace InfraStructure
{
    public static class ServiceCollectionExtension
    {
        public  static IServiceCollection AddInfraStructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddTransient<IPropertyRepo,PropertyRepo>()
                .AddTransient<IImageRepo,ImageRepo>()
                .AddDbContext<ApplicationDbContext>(Options => Options
                    .UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
