using CloudGames.Users.Application.Services;
using CloudGames.Users.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CloudGames.Users.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddTransient<IJwtProvider, JwtProvider>();

        return services;
    }
}
