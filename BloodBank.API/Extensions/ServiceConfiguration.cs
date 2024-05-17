using BloodBank.API.Filters;
using BloodBank.API.Middleware;
using BloodBank.Application.Commands.Donations.Send;
using BloodBank.Application.Validators.Address;
using BloodBank.Core.Repositories;
using BloodBank.Infrastructure.Persistence;
using BloodBank.Infrastructure.Repositories;
using Microsoft.OpenApi.Models;
using FluentValidation.AspNetCore;
using Serilog;

namespace BloodBank.API.Extensions;

public static class ServiceConfiguration
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.ConfigureDependencyInjection();
        builder.ConfigureOthersServices();

        builder.Services.AddControllers();

        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "BloodBank.API",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "Erick Goldberg",
                    Email = "erick_goldberg@hotmail.com",
                    Url = new Uri("https://github.com/ErickGoldberg")
                }
            });
        });

        return builder;
    }
    
    public static IServiceCollection ConfigureDependencyInjection(this WebApplicationBuilder builder)
    {
        var services = builder.Services;

        //services.AddScoped<IFinancialGoalRepository, FinancialGoalRepository>();
        //services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ICepRepository, CepRepository>();
        services.AddTransient<GlobalExceptionHandler>();

        return services;
    }

    public static IServiceCollection ConfigureOthersServices(this WebApplicationBuilder builder)
    {
        var services = builder.Services;

        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(SendDonationCommand).Assembly);
        });

        services.AddControllers(options => options.Filters.Add(typeof(ValidationFilter)))
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddressModelValidator>());

        builder.Services.AddDbContext<BloodBankDbContext>(options
            => options.UseSqlServer(builder.Configuration.GetConnectionString("FinancialGoalManagerDb")));

        builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.PostgreSQL(
                    connectionString: "",
                    tableName: "Logs",
                    needAutoCreateTable: true
                )
                .WriteTo.Console()
                .CreateLogger();
        }).UseSerilog();

        //services.AddHostedService<RememberDaysLeftJob>();

        return services;
    }
}