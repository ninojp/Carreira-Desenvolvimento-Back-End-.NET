namespace ScreenSound;
internal class Artista
{
    private string nomeArtista;
    public string NomeArtista
    {
        get => nomeArtista;
        set => nomeArtista = value;
    }
    public List<Album> Albuns { get; set; } = new List<Album>();

}
