namespace PraticandoOOPolimorf;

internal class AulaGravada : Conteudo
{
    public int Duracao { get; set; }
    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Class, Aula Gravada: {Titulo}\nDuração: {Duracao} minutos\n");
    }
}
