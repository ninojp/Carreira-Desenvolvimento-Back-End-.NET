namespace ScreenSound.Models;

internal class Musica : IAvaliavel
{
    private readonly List<Avaliacao> notas = new();
    public List<Avaliacao> ListaNotasMusica => notas;
    public string Nome { get; }
    public Banda Band { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public static int ContadorDeObjetos = 0;
    int IAvaliavel.ContadorDeObjetos => ContadorDeObjetos;
    //Construtor da classe Musica, que recebe o artista e o nome da música como parâmetros.
    //O contador de objetos é incrementado a cada nova instância criada.
    public Musica(Banda band, string nome, int duracao, bool disponivel)
    {
        Band = band;
        Nome = nome;
        Duracao = duracao;
        Disponivel = disponivel;
        ContadorDeObjetos++;
    }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Band.Nome}";

    public double MediaNotas => notas.Count == 0 ? 0 : notas.Average(n => n.Nota);
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Band.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}