using Contracts;
using Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace FavoritosTest.Extensions
{
  public static class ServiceExt
  {
    public static void AccessCors(this IServiceCollection services)
    {
      services.AddCors(options =>
      {
        options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
      });
    }

    public static void IISIntegration(this IServiceCollection services)
    {
      services.Configure<IISOptions>(options =>
      {

      });
    }

    public static void ConfigureMySQLContext(this IServiceCollection services, IConfiguration config)
    {
      var connectionString = config["mysqlconnection:connectionString"];
      services.AddDbContext<RepositoryContext>(r => r.UseMySql(connectionString));
    }

    public static void ConfigureRepositoryWrapper(this IServiceCollection services)
    {
      services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
    }
  }
}
