using Microsoft.EntityFrameworkCore;
using Teste.Core.Data.Context;
using Teste.Core.Data.Repository;
using Teste.Core.Data.Service;
using Teste.Core.Domain.Interfaces.Repository;
using Teste.Core.Domain.Interfaces.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MyContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Connection") ?? throw new InvalidOperationException("Connection string 'Connection' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRegiaoDeInteresseRepository, RegiaoDeInteresseRepository>()
    .AddScoped<IRegiaoService, RegiaoService>()
    .AddDbContext<MyContext>();

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
