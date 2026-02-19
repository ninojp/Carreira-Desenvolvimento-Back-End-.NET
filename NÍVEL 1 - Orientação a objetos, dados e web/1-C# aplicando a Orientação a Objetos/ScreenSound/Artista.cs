namespace ScreenSound;
internal class Artista
{
    private List<Album> albunsDoArtista = [];
    public List<Album> AlbunsDoArtista { get; set; }
    //----------------------------------------------
    private string nomeArtista;
    public string NomeArtista
    {
        get => nomeArtista;
        set => nomeArtista = value;
    }
    public void ExibirArtistaEAlbuns()
    {
        Console.WriteLine($"\nÁlbuns do Artista: {this.NomeArtista}");
        for (int i = 0; i < albunsDoArtista.Count; i++)
        {
            Console.WriteLine($"Álbum {i + 1}: {albunsDoArtista[i].NomeDoAlbum} - Duração Total: {albunsDoArtista[i].DuracaoTotal} segundos");
        }
    }
    public void AdicionarAlbumAoArtista(Album album)
    {
        albunsDoArtista.Add(album);
    }
}
