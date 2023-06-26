using Microsoft.EntityFrameworkCore;
using back_bitadora.Context;
using back_bitadora.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ListadoDeRemitosContext>( options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Database"))
);

builder.Services.AddScoped<IAgenciaService, AgenciaServices>();

// Configuro el CORS para aceptar todas las conexiones
builder.Services.AddCors(options => {
    options.AddPolicy("AllowCredentials",app=>{
      app.AllowAnyOrigin()
      .AllowAnyHeader()
      .AllowAnyMethod();
    });
});

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
