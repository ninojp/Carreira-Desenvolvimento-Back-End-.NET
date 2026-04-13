namespace PraticandoOOPolimorf;

internal class Imagem : Midia
{
    public string Resolucao { get; set; }
    public Imagem(string nome, string resolucao) : base(nome)
    {
        this.Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        Console.WriteLine($"ClassDerivada Imagem, Resolução da Imagem: {Resolucao}");
    }
}