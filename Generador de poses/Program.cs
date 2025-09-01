using Microsoft.EntityFrameworkCore;
using Generador_de_poses.Data;
using Generador_de_poses.Services;



var builder = WebApplication.CreateBuilder(args);

//añadimos los servicios al contenedor
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuracion de la base de datos
builder.Services.AddDbContext<PersonajesDbContext>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

//Agregamos la configuración del servicio
builder.Services.AddScoped<PersonajeService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
