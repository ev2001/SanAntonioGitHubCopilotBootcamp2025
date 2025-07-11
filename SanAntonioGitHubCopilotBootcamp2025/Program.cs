var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Mild", "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast");

// Create a new GET endpoint that gives the wheather forecast for a specific city
app.MapGet("/weatherforecast/{city}", (string city) =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return Results.Ok(new { City = city, Forecast = forecast });
    })
    .WithName("GetWeatherForecastByCity");
app.MapGet("/greet", () =>
    {
        return "Hello, welcome to the San Antonio GitHub Copilot Bootcamp 2025!";
    })
    .WithName("GetGreeting");
app.MapGet("/willitrain", () =>
    {
        var willRain = Random.Shared.Next(2) == 0;
        return new { WillItRain = willRain, Message = willRain ? "Yes, it will rain." : "No, it will not rain." };
    })
    .WithName("WillItRain");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}