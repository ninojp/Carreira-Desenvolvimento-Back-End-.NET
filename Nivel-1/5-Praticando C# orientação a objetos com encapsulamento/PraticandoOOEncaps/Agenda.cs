namespace PraticandoOOEncaps;

internal class Agenda
{
    private readonly List<Contato> contatos;
    public string Proprietario { get; set; }
    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }
    public bool AdicionarContato(Contato contato)
    {
        //verifica se o nome já existe.
        if (contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine($"\nO Contato {contato.Nome}, já está na agenda.");
            return false;
        }
        contatos.Add(contato);
        return true;
    }
    public void ListarContatos()
    {
        Console.WriteLine($"\nAgenda de {Proprietario}");
        foreach (Contato contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
        }
    }

}
