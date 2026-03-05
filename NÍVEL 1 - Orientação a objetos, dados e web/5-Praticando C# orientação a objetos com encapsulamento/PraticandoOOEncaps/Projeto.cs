namespace PraticandoOOEncaps;

internal class Projeto
{
    public string Nome { get; set; }
    private List<string> tarefas = [];
    public int QuantidadeTarefas => tarefas.Count;
    public Projeto(string nome)
    {
        Nome = nome;
    }
    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }
    public void ExibirTarefas()
    {
        Console.WriteLine("Projeto: " + Nome);
        Console.WriteLine("Tarefas:");
        foreach (string tarefa in tarefas)
        {
            Console.WriteLine("- " + tarefa);
        }
        Console.WriteLine("Total: " + QuantidadeTarefas + " tarefas");
    }
}
