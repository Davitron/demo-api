var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var message = Environment.GetEnvironmentVariable("MY_MESSAGE") ?? "No message set.";
    return Results.Ok(new { message });
});

app.Run();