namespace PraticandoOOPolimorf;

internal class Funcionario
{
    public string Nome { get; set; }
    public virtual string GerarRelatorio()
    {
        return "Relatório do funcionário";
    }
}
