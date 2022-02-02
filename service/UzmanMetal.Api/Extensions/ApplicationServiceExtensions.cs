using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using UzmanMetal.Api.Services.Email;
using UzmanMetal.Api.Settings;
using UzmanMetal.Data;

namespace UzmanMetal.Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "UzmanMetal.Api", Version = "v1" });
            });

            services.AddDbContext<DataContext>(options =>
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                string connStr;

                // Depending on if in development or production, use either server-provided
                // connection string, or development connection string from env var.
                if (env == "Development")
                {
                    // Use connection string from file.
                    connStr = config.GetConnectionString("DefaultConnection");
                    options.UseSqlite(connStr);
                }
                else
                {
                    //will be configured later on.
                }
            });

            services.Configure<MailSettings>(config.GetSection("MailSettings"));
            services.AddTransient<IMailService, MailService>();

            return services;
        }

    }
}