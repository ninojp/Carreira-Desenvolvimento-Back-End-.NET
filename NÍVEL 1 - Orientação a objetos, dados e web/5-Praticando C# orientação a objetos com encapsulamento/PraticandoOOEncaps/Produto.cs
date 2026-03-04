public class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;
    public Produto(string nome, string descricao, decimal preco, int estoque)
    {
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.estoque = estoque;
    }
    public bool EstaDisponivel()
    {
        return estoque > 0;
    }
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto);
    }
    //public void CriarProduto(string nome, string descricao, decimal preco, int estoque)
    //{
    //    this.nome = nome;
    //    this.descricao = descricao;
    //    this.preco = preco;
    //    this.estoque = estoque;
    //}
}