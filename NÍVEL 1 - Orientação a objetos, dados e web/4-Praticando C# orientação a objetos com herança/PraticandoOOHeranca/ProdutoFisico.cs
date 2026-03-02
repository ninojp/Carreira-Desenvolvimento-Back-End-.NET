namespace PraticandoOOHeranca;

internal class ProdutoFisico : Produto
{
    public int Estoque { get; }
    public ProdutoFisico(string nome, string descricao, decimal preco, string imagem)
        : base(nome, descricao, preco, imagem)
    {
        Estoque = 0;
    }
    public bool EstaDisponivel()
    {
        return Estoque > 0;
    }
}
