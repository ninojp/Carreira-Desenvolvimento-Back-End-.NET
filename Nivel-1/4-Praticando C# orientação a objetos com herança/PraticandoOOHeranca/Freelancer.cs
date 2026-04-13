namespace PraticandoOOHeranca;

internal class Freelancer : Funcionario
{
    public decimal ValorProjeto { get; }
    public Freelancer(string nome, string cargo, decimal valorProjeto) : base(nome, 0, "", cargo)
    {
        ValorProjeto = valorProjeto;
    }
}
