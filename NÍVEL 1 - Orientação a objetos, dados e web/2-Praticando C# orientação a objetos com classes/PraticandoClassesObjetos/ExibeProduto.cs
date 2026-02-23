namespace PraticandoClassesObjetos;

internal class ExibeProduto
{
    public void ExibirDadosProduto(Produto produto, decimal desconto)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        produto.ExibirEstoque();
        Console.WriteLine($"O Produto {produto.Nome} está: {produto.EstaDisponivel()}");
        produto.AlterarPrecoComDesconto(desconto);
        Console.WriteLine($"Desconto de {desconto:P0} aplicado.\nNovo preço: {produto.Preco:C}");
        Console.ResetColor();
    }
}
