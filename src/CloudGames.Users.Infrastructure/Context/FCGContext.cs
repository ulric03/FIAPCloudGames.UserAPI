﻿using CloudGames.Users.Application.Utils;
using CloudGames.Users.Domain.Entities;
using CloudGames.Users.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CloudGames.Users.Infrastructure.Context;

public class FCGContext : DbContext
{
    public FCGContext(DbContextOptions<FCGContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
}

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FullName = "Administrator",
                Login = "administrator",
                Password = Utils.HashPassword("123456"),
                Email = "adm@adm.com",
                UserType = UserRole.Admin,
                IsActive = true,
                CreatedAt = new DateTime(2025, 5, 30, 12, 50, 51, 795, DateTimeKind.Utc).AddTicks(8972)
            }
        );
    }
}
