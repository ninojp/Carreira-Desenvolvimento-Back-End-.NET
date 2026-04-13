namespace ScreenSound.Models;

internal class Album : IAvaliavel
{
    private readonly List<Musica> musicasDoAlbum = new();
    public List<Musica> ListaMusicasDoAlbum => musicasDoAlbum;

    private readonly List<Avaliacao> notas = new();
    public List<Avaliacao> ListaNotasAlbum => notas;
    public string Nome { get; }
    public static int ContadorDeObjetos = 0;
    int IAvaliavel.ContadorDeObjetos => ContadorDeObjetos;
    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++;
    }
    public double MediaNotas => notas.Count == 0 ? 0 : notas.Average(n => n.Nota);
    public void AdicionarNota(Avaliacao nota) => notas.Add(nota);
    public int DuracaoTotalAlbum => musicasDoAlbum.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica) => musicasDoAlbum.Add(musica);
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicasDoAlbum)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotalAlbum}");
    }
}