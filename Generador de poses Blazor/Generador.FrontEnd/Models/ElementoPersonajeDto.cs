namespace Generador.FrontEnd.Models;

public record class ElementoPersonajeDto
{
    public int Id { get; set; }
    public required string Nombre { get; set; } = string.Empty;
    public required string RutaImagen { get; set; } = string.Empty;

}
