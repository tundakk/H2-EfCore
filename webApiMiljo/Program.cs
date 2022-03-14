using Microsoft.EntityFrameworkCore;
using webApiMiljo.INTERFACES;
using webApiMiljo.MODELS;
using webApiMiljo.REPO;
using webApiMiljo.SERVICES;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var config = builder.Configuration; //henter connectionstring fra appsettings.json

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(opt => opt.UseSqlServer(config.GetConnectionString("SqlServer")), ServiceLifetime.Transient);
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IService, Service>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
