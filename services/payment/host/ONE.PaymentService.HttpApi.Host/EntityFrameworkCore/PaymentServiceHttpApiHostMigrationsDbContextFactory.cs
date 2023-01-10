﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ONE.PaymentService.EntityFrameworkCore;

public class PaymentServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<PaymentServiceHttpApiHostMigrationsDbContext>
{
    public PaymentServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PaymentServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("PaymentService"));

        return new PaymentServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
