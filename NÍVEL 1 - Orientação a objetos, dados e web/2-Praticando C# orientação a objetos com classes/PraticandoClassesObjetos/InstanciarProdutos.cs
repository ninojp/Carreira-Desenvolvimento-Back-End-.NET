namespace PraticandoClassesObjetos;

internal class InstanciarProdutos
{
    public Produto ProdutoTeclado { get; private set; }
    public Produto ProdutoCadeira { get; private set; }

    public InstanciarProdutos()
    {
        ProdutoTeclado = new Produto("Teclado", 80.00m, 15);
        ProdutoCadeira = new Produto("Cadeira gamer", 600.00m, 0);
    }
}
