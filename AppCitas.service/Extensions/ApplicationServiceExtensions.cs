using AppCitas.service.Data;
using AppCitas.service.Interfaces;
using AppCitas.service.Services;
using Microsoft.EntityFrameworkCore;

namespace AppCitas.service.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<ITokenService, TokenService>();
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        return services;
    }
}
