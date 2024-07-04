using Microsoft.EntityFrameworkCore;
using Proyecto.BW.Interfaces.SG;
using ServicioGestorProductos.BW.CU;
using ServicioGestorProductos.BW.Interfaces.BW;
using ServicioGestorProductos.SG;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

// Inyección de dependencias
builder.Services.AddTransient<IGestionarProductoBW, GestionarProductoBW>();

builder.Services.AddTransient<IGestionarEventoProductoSG, GestionarEventoProductoSG>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
