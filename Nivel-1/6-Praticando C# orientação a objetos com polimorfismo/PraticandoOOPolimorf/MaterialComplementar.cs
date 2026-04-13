namespace PraticandoOOPolimorf;

internal class MaterialComplementar : Conteudo
{
    public string Descricao { get; set; }
    public MaterialComplementar(string titulo, string descricao) : base(titulo)
    {
        Descricao = descricao;
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Class, Material Complementar: {Titulo}\nDescrição: {Descricao}\n");
    }
}
