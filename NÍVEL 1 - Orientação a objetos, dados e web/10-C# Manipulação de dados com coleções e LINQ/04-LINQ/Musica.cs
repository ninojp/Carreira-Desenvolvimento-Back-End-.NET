namespace _04_LINQ;

internal class Musica
{
    public required string Titulo { get; set; }
    public required string Artista { get; set; }
    public required int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; } = [];

}
