namespace PraticandoOOHeranca;

internal class Passageiro : Pessoa
{
    public int QuantidadeBilhetes { get; }
    public Passageiro(string nome, int idade, int quantidadeBilhetes) : base(nome, idade)
    {
        QuantidadeBilhetes = quantidadeBilhetes;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Passageiro: {Nome}, Idade: {Idade}, Quantidade de Bilhetes: {QuantidadeBilhetes}");
    }
}
