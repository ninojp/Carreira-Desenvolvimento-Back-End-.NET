namespace ScreenSound;
internal class Episodio
{
    private List<string> listaConvidados = [];
    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; set; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", listaConvidados)}";

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        listaConvidados.Add(convidado);
    }
}
