using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using specmatic_order_api_csharp.services;
using Microsoft.OpenApi.Models;
using System.Diagnostics.CodeAnalysis;
[ExcludeFromCodeCoverage] // Exclude the entire class from code coverage
public class Program
{
    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddEndpointsApiExplorer(); // Add for OpenAPI/Swagger generation
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Order API", Version = "v1" });
            c.MapType<IFormFile>(() => new OpenApiSchema
            {
                Type = "string",
                Format = "binary"
            });
        });

// Register your custom services
        builder.Services.AddScoped<OrderService>();
        builder.Services.AddScoped<ProductService>();

// Register controllers
        builder.Services.AddControllers();

        var app = builder.Build();

// Enable Swagger UI in development
        if (app.Environment.IsDevelopment())
        {

        }

        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Order API V1");
            c.RoutePrefix = string.Empty; // Optional: Set Swagger UI to the root
        });
        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

// This line maps the controllers to their routes
        app.MapControllers();

        app.Run();
    }
}