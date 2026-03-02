using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PraticandoOOHeranca;
internal class Produto
{
    private string imagem;
    //public string Nome { get; protected set; }
    public string Nome { get; }
    public string Descricao { get; }
    public decimal Preco { get; private set; }
    public Produto(string nome, string descricao, decimal preco, string imagem)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Imagem = imagem;
    }
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto / 100);
    }
    public string Imagem
    {
        get
        {
            return imagem;
        }
        set
        {
            if (value.Length > 0)
            {
                this.imagem = value;
            }
        }
    }

}
