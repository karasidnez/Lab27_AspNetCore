var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-233! Aвтор:Тимонини И.В");

app.Run();
