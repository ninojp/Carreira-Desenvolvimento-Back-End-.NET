namespace PraticandoOOHeranca;

internal class Pessoa
{
    public string Nome { get; }
    public int Idade { get; set; }
    public string Email { get; set; } = string.Empty;
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
