namespace ScreenSound;

internal class Album
{
    private List<Musica> listaMusicas = new List<Musica>();
    public string NomeDoAlbum { get; set; }
    public Artista Artista { get; set; }
    public int DuracaoTotal => listaMusicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        listaMusicas.Add(musica);
    }
    public void ExibirDetalhesDoAlbum()
    {
        Console.WriteLine($"\nO Álbum: {this.NomeDoAlbum}");
        //para exibir o artista aqui?
        Console.WriteLine($"Pertence ao Artista: {this.Artista.NomeArtista}");
        Console.WriteLine($"E tem {listaMusicas.Count} músicas.\n");
        ExibirMusicasDoAlbum();
    }
    public void ExibirMusicasDoAlbum()
    {
        for (int i = 0; i < listaMusicas.Count; i++)
        {
            Console.WriteLine($"Música {i + 1}: {listaMusicas[i].NomeDaMusica} - {listaMusicas[i].Duracao} segundos");
            Console.WriteLine($"Gênero: {listaMusicas[i].Genero.NomeGenero}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos.");
    }
}
