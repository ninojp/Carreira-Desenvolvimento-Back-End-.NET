namespace PraticandoOOPolimorf;

internal class Video : Midia
{
    public int Duracao { get; set; }
    public Video(string nome, int duracao) : base(nome)
    {
        this.Duracao = duracao;
    }
    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($"ClassDerivada Video, Duração do Vídeo: {Duracao} segundos");
    }
}
