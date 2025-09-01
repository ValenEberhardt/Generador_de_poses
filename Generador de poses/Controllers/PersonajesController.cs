using Generador_de_poses.Models;
using Generador_de_poses.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Generador_de_poses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly PersonajeService _personajeService;

        //El controlador recibe el servicio por medio de inyeccion de dependencia
        public PersonajesController(PersonajeService personajeService)
        {
            _personajeService = personajeService;
        }

        //Endpoint GET para optener los elementos
        [HttpGet]
        public async Task<ActionResult<PersonajesDto>> Get()
        {
            var elementos = await _personajeService.GetElementosAsync();

            return Ok(elementos);
        }

    }
}
