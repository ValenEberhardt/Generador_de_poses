namespace Generador_de_poses.Models;

public record class ElementoPersonajeDto
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string RutaImagen{ get; set; }

}
