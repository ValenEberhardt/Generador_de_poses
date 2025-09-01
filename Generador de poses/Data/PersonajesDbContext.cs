using System;
using Microsoft.EntityFrameworkCore;
using Generador_de_poses.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace Generador_de_poses.Data;

public class PersonajesDbContext : DbContext
{
    //Constructor
    public PersonajesDbContext(DbContextOptions<PersonajesDbContext> options) : base(options)
    {

    }

    //Tablas de la base de datos

    public DbSet<Cuerpo> Cuerpos { get; set; }
    public DbSet<Pose> Poses { get; set; }
    public DbSet<Expresion> Expresions { get; set; }



    //Configuracion del seeding (se ejecuta cuando se cree la BD)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cuerpo>().HasData(
            new Cuerpo { Id = 1, Nombre = "Musculoso", RutaImagen = "muscles.png" }, // RUTA DE LAS IMG
            new Cuerpo { Id = 2, Nombre = "Delgado", RutaImagen = "slim.png" }
            //Y aca se pueden agegar mas tipos de cuerpos
        );

        modelBuilder.Entity<Pose>().HasData(
            new Pose { Id = 1, Nombre = "Parado", RutaImagen = "parado.png" },
            new Pose { Id = 2, Nombre = "Agachado", RutaImagen = "agachado.png" }

        );

        modelBuilder.Entity<Expresion>().HasData(
            new Expresion { Id = 1, Nombre = "Normal", RutaImagen = "normal.png" },
            new Expresion { Id = 2, Nombre = "Alegre", RutaImagen = "alegre.png" }
        );

        base.OnModelCreating(modelBuilder); // 

    }



}
