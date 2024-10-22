using Libreria.Business.Services;
using Libreria.Data;
using Libreria.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyectar contexto de DB
builder.Services.AddDbContext<AppDBContext>(context => { context.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")); });

//Inyectar repositorios
builder.Services.AddScoped<AutorRepository>();
builder.Services.AddScoped<LibroRepository>();


//Inyectando servicio
builder.Services.AddScoped<IBuscaLibroService, BuscaLibroServiceImpl>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
