namespace PraticandoOOHeranca;

internal class Consultoria : IServico
{
    private string Titulo;
    private Funcionario Responsavel;
    public Consultoria(string titulo, Funcionario funcionario)
    {
        Titulo = titulo;
        Responsavel = funcionario;
    }
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de consultoria: {Titulo}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}\n");

    }
}
