internal class Produto
{
    private string imagemUrl; //Mantém porque tem validação
    public string ImagemUrl
    {
        get => imagemUrl;
        set
        {
            if (value.Length > 0)
                imagemUrl = value;
        }
    }
    // Auto-properties - sem backing fields necessários, ou seja, sem necessidade de variáveis privadas (atributos) para armazenar os valores
    public string Nome { get; }
    public string Descricao { get; set; }
    public decimal Preco { get; private set; } // private set protege contra alteração externa
    public int Estoque { get; private set; }
    public Produto(string nome, string descricao, decimal preco, int estoque, string imagemUrl)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
        ImagemUrl = imagemUrl;
    }
    public bool EstaDisponivel()
    {
        return Estoque > 0;
    }
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto);
    }
}