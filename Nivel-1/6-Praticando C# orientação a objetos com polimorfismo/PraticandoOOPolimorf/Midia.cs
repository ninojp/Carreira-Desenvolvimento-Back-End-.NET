namespace PraticandoOOPolimorf;

internal class Midia
{
    public string Nome { get; set; }
    public Midia(string nome)
    {
        Nome = nome;
    }
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"ClassBase Midia, Nome: {Nome}");
    }
}
