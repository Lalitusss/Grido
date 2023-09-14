using BE_HelacorTest.Models;
using BE_HelacorTest.Models.Repository;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//CORS
//Para trabajar en entorno local
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
                                    builder => builder.AllowAnyOrigin()
                                                      .AllowAnyHeader()
                                                      .AllowAnyMethod()));
//Se agrega el contexto
builder.Services.AddDbContext<AplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion"));
});


//Automapper
builder.Services.AddAutoMapper(typeof(Program));

//Add Service
builder.Services.AddScoped<IRepartoRepository, RepartoRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Para utilizar cors
app.UseCors("AllowWebApp");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
