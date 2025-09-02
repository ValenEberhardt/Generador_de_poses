namespace Generador.FrontEnd.Models;

public record class PersonajesDto
{
    public required List<ElementoPersonajeDto> Cuerpos { get; set; } = new List<ElementoPersonajeDto>();
    public required List<ElementoPersonajeDto> Poses { get; set; } = new List<ElementoPersonajeDto>();
    public required List<ElementoPersonajeDto> Expresions { get; set; } = new List<ElementoPersonajeDto>();

}
