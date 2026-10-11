var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactPolicy", policy =>
    {
        policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("ReactPolicy");

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        mensagem = "API do Controle de Gastos funcionando!"
    });
});

app.Run();