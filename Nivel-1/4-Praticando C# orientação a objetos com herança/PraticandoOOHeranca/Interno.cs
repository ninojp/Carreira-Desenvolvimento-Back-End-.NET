namespace PraticandoOOHeranca;

internal class Interno : Funcionario
{
    public decimal Salario { get; }
    public Interno(string nome, string cargo, decimal salario) : base(nome, 0, "", cargo)
    {
        Salario = salario;
    }
}
