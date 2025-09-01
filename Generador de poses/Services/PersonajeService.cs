using System;
using Generador_de_poses.Data;
using Generador_de_poses.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Generador_de_poses.Services;

public class PersonajeService
{
    private readonly PersonajesDbContext _dbContext;

    public PersonajeService(PersonajesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    //Metodo para obtener los elementos de los personajes
    public async Task<PersonajesDto> GetElementosAsync()
    {
        //Cosulta tablas y obtiene los datos
        var cuerpos = await _dbContext.Cuerpos.ToListAsync();
        var poses = await _dbContext.Poses.ToListAsync();
        var expresions = await _dbContext.Expresions.ToListAsync();

        //Mappeando los modelos de la bd a los dtos
        var cuerposDTo = cuerpos.Select(c => new ElementoPersonajeDto { Id = c.Id, Nombre = c.Nombre, RutaImagen = c.RutaImagen }).ToList();
        var posesDto = poses.Select(p => new ElementoPersonajeDto { Id = p.Id, Nombre = p.Nombre, RutaImagen = p.RutaImagen }).ToList();
        var expresionsDto = expresions.Select(e => new ElementoPersonajeDto { Id = e.Id, Nombre = e.Nombre, RutaImagen = e.RutaImagen }).ToList();


        //Creando el DTo final que se envia al controlador
        var personajesDto = new PersonajesDto
        {
            Cuerpos = cuerposDTo,
            Poses = posesDto,
            Expresions = expresionsDto
        };

        return personajesDto;


    }



}

