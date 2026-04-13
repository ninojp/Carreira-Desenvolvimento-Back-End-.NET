namespace ScreenSound;
internal class Album
{
    // Construtor para inicializar as propriedades do álbum
    public Album(string nomeDoAlbum, Artista artista, Genero genero)
    {
        this.NomeDoAlbum = nomeDoAlbum;
        this.Artista = artista;
        this.Genero = genero;
    }
    // Propriedades do álbum
    public string NomeDoAlbum { get; set; }
    public Artista Artista { get; set; }
    private List<Musica> listaMusicas = [];
    public Genero Genero { get; }
    public int DuracaoTotal => listaMusicas.Sum(m => m.Duracao);
    // Método para adicionar uma música ao álbum
    public void AdicionarMusicaAoAlbum(Musica musica)
    {
        listaMusicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        for (int i = 0; i < listaMusicas.Count; i++)
        {
            Console.WriteLine($"Música {i + 1}: {listaMusicas[i].NomeDaMusica} - {listaMusicas[i].Duracao} segundos, Disponibilidade: {listaMusicas[i].ExibirDisponibilidade()}");
        }
    }
    public void ExibirDetalhesDoAlbum()
    {
        Console.WriteLine($"\nO Álbum: {this.NomeDoAlbum}");
        Console.WriteLine($"Gênero: {this.Genero.NomeGenero}");
        Console.WriteLine($"Pertence ao Artista: {this.Artista.NomeArtista}");
        Console.WriteLine($"E tem {listaMusicas.Count} músicas, com um tempo total de {this.DuracaoTotal} segundos.");
        ExibirMusicasDoAlbum();
    }
}
