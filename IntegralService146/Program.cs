using IntegralService146.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using TestService.Models;

namespace IntegralService146
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddTransient<ICalculatorService, CalculatorService>();

            var server = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            var port = Environment.GetEnvironmentVariable("DB_PORT") ?? "1433";
            var dbName = Environment.GetEnvironmentVariable("DB_NAME") ?? "questionsdb";
            var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME") ?? "SA";
            var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD") ?? "arS12qt@16mv";

            builder.Services.AddDbContext<QuestionContext>(options =>
            options.UseSqlServer($"Server={server},{port};Initial Catalog={dbName};User ID ={dbUser};Password={dbPassword};TrustServerCertificate=True;MultipleActiveResultSets=True;"));

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                app.UseCors(options =>
                {
                    options.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}