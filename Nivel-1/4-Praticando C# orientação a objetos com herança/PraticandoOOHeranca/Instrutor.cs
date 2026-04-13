namespace PraticandoOOHeranca;

internal class Instrutor : Pessoa
{
    public string Especialidade { get; }
    public Instrutor(string nome, int idade, string especialidade) : base(nome, idade)
    {
        Especialidade = especialidade;
    }
}
