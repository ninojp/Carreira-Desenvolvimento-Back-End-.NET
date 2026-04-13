namespace Aula2FacaComoEuFiz;

internal class Medico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
    public void ExibirInformacoesMedico()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Especialidade: {Especialidade}");
    }
}
