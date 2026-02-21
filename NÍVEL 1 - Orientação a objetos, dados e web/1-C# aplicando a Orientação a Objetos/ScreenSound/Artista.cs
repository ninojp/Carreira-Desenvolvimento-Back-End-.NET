namespace ScreenSound;
internal class Artista
{
    public Artista(string nomeArtista)
    {
        this.NomeArtista = nomeArtista;
    }
    // Atributos e Propriedades
    private string nomeArtista;
    private List<Album> albunsDoArtista = [];
    public List<Album> AlbunsDoArtista { get; set; }
    //----------------------------------------------
    public string NomeArtista { get; }
    public void ExibirArtistaEAlbuns()
    {
        Console.WriteLine($"\nÁlbuns do Artista: {this.NomeArtista}\n");
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
