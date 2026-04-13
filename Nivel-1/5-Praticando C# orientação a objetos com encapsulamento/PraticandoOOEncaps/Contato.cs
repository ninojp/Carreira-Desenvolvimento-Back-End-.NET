namespace PraticandoOOEncaps;

internal class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }
}
