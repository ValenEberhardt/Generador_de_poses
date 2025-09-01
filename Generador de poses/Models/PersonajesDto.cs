namespace Generador_de_poses.Models;

public record class PersonajesDto
{
    public required List<ElementoPersonajeDto> Cuerpos { get; set; }
    public required List<ElementoPersonajeDto> Poses { get; set; }
    public required List<ElementoPersonajeDto> Expresions { get; set; }

}
