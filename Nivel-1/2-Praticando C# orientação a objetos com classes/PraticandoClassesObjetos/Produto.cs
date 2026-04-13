namespace PraticandoClassesObjetos;

class Produto
{
    private int quantidadeEstoque;
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string Descricao => $"O Produto {Nome}, tem o preço de {Preco:C} e está {(quantidadeEstoque > 0 ? "disponível" : "indisponível")}.";
    public Produto(string nome, decimal preco, int quantidadeEstoque)
    {
        Nome = nome;
        Preco = preco;
        this.quantidadeEstoque = quantidadeEstoque;
    }
    public void Retirar(int quantidade)
    {
        if (quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine($"Quantidade {quantidade} produto(s), foi retirada do estoque.");
        }
        else
        {
            Console.WriteLine($"Quantidade {quantidade} insuficiente em estoque!");
        }
    }
    public void ExibirEstoque()
    {
        Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
    }

    //Método com retorno, string
    public string EstaDisponivel()
    {
        return quantidadeEstoque > 0 ? "Disponível" : "Indisponível";
    }
    //Método sem retorno, void e com parâmetro.
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco -= Preco * desconto;
        //preco = preco * (1 - desconto);
    }
}