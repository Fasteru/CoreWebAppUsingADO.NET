using Repository.ConnectionFactory;
using Repository.Data_Access_Layer.Contracts;
using Repository.Data_Access_Layer.Implementations;

namespace CoreWebAppUsingADO.NET.ServicesExtension
{
    public static class ServicesExtension
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGetData, GetDataProcessor>();
            services.AddScoped<IDbConnectionFactory>(f => new DBConnectionFactory(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
