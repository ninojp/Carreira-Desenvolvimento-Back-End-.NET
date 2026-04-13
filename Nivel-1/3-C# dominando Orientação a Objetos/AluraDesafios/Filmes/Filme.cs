namespace AluraDesafios.Filmes;
internal class Filme
{
    private List<string> listaElenco { get; set; }
    public string Titulo { get; set; }
    public string Duracao { get; set; }
    public object?[] Elenco { get; internal set; }

    public Filme(string titulo, string duracao, List<string>? elenco)
    {
        if (elenco == null)
        {
            listaElenco = new List<string>();
            Elenco = Array.Empty<object>();
        }
        else
        {
            listaElenco = elenco;
            Elenco = elenco.ToArray();
        }
        Titulo = titulo;
        Duracao = duracao;
    }
    public void AdicionarElenco(string nomeAtor)
    {
        if (listaElenco.Count == 0)
        {
           Console.WriteLine("O elenco do filme ainda não foi definido." +
               " O ator será adicionado como o primeiro membro do elenco.");

        }
        else
        {
            Console.WriteLine("Elenco... ");
            foreach (var ator in listaElenco)
            {
                Console.WriteLine(ator);
            }
        }
    }
}
