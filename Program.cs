using MinimalApi.Infraestrutura.Db;
using MinimalApi.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MinimalApi.Dominio.Servicos;

// Video "Configurando modelo de veiculos"

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();

app.MapGet("/", () => "Hello Minimal API!");

app.MapPost("/login", ([FromBody] LoginDTO loginDTO, AdministradorServico administradorServico) => {
    if(administradorServico.Login(loginDTO) != null)
        return Results.Ok("Login com sucesso");
    
    else
        return Results.Unauthorized();   
});

app.Run();

