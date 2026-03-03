namespace PraticandoOOHeranca;

internal class Manutencao : IServico
{
    private string Titulo;
    private Funcionario Responsavel;
    public Manutencao(string titulo, Funcionario funcionario)
    {
        Titulo = titulo;
        Responsavel = funcionario;
    }

    public void ExecutarServico()
    {
        Console.WriteLine($"Executando serviço de manutenção: {Titulo}");
        Console.WriteLine($"Responsável: {Responsavel.Nome} - Departamento: {Responsavel.Departamento}\n");

    }
}
