namespace PraticandoOOHeranca;

internal class Funcionario : Pessoa
{
    public string Departamento { get; }
    public string Cargo { get; }
    public Funcionario(string nome, int idade, string departamento, string cargo) : base(nome, idade)
    {
        Departamento = departamento;
        Cargo = cargo;
    }

}
