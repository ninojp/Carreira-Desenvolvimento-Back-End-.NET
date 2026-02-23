namespace AluraDesafios.Filmes;
internal class Artista
{
    public string NomeArtista { get; set; }
    public int IdadeArtista { get; set; }
    public List<string> FilmesParticipados { get; set; } = new();
    public int QtdFilmesParticipados => FilmesParticipados.Count;

    public Artista(string nomeArtista, int idadeArtista)
    {
        NomeArtista = nomeArtista;
        IdadeArtista = idadeArtista;
        FilmesParticipados = new();
    }
    void AdicionarFilme(string nomeFilme)
    {
        FilmesParticipados.Add(nomeFilme);
    }
    public void ExibirFilmesParticipados()
    {

        if (this.FilmesParticipados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {this.NomeArtista}");
            return;
        }

        Console.WriteLine($"Filmes de {this.NomeArtista}...");
        foreach (var filme in FilmesParticipados)
        {
            Console.WriteLine($"Filme: {filme}");
        }
    }

}
