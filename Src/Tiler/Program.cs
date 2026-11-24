using Tiler.Contract;
using Tiler.Services;

namespace Tiler;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();
        
        ConfigurateServices(builder.Services);

        var app = builder.Build();

// Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        

        app.MapControllers();
        app.UseSwagger();
        app.UseSwaggerUI();
        
        Console.WriteLine("Swagger url: " + app.Configuration["ASPNETCORE_URLS"]?.Split(';')[0] + "/swagger");
        
        app.UseCors(policy => 
            policy.WithOrigins("http://localhost:5173")  // разрешить только ваш фронт
                .AllowAnyMethod()
                .AllowAnyHeader()
        );

        app.Run();
    }

    private static void ConfigurateServices(IServiceCollection services)
    {
        services.AddSingleton<ITileService, TileService>();
    }
}

