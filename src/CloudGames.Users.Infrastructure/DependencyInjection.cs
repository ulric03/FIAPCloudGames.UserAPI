﻿using CloudGames.Users.Domain.Interfaces;
using CloudGames.Users.Domain.Repositores;
using CloudGames.Users.Infrastructure.Context;
using CloudGames.Users.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CloudGames.Users.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDatabase(configuration);
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }

    private static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

        services.AddDbContextPool<FCGContext>(options =>
        {
            options.UseSqlServer(connectionString,
            op =>
            {
                op.CommandTimeout(300);
                op.MaxBatchSize(1);
            });
        })
        .AddLogging();

        return services;
    }
}
