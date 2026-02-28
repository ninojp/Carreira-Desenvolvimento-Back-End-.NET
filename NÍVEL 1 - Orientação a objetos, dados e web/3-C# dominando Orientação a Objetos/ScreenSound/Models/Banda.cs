namespace ScreenSound.Models;

internal class Banda : IAvaliavel
{
    private readonly List<Album> albunsDaBanda = new List<Album>();
    //Com get, Retorna a lista de álbuns da banda. Sem set, pois a lista de álbuns deve ser gerenciada apenas pela classe Banda.
    public IEnumerable<Album> ListaAlbunsDaBanda => albunsDaBanda;
    private readonly List<Avaliacao> notas = new();
    public List<Avaliacao> ListaNotasBanda => notas;
    public string Nome { get; }
    public static int ContadorDeObjetos;
    int IAvaliavel.ContadorDeObjetos => ContadorDeObjetos;
    public Banda(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++;
    }
    public double MediaNotas => notas.Count == 0 ? 0 : notas.Average(n => n.Nota);
    public void AdicionarNota(Avaliacao nota) => notas.Add(nota);
    public void AdicionarAlbum(Album album) => albunsDaBanda.Add(album);
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        albunsDaBanda?.ForEach(album => Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotalAlbum})"));
    }
}