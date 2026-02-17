using System.Runtime.Intrinsics.X86;
namespace ScreenSound;
//4. Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
//Garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade
//Mostrar detalhadamente as informações do produto.
internal class Produto{
    //Atributos, são variáveis declaradas dentro de uma classe que armazenam
    //dados associados a uma instância específica desta classe.
    private decimal precoAtributo;
    private int estoqueAtributo;
    //-------------------------------------------------------------------------------------
    //Propriedades, são uma abstração que fornece um meio de acessar e modificar os valores
    //dos atributos de uma classe, encapsulando a lógica de leitura e escrita.
    public string NomePropriedade { get; set; }
    public string MarcaPropriedade { get; set; }
    public decimal PrecoPropriedade
    //Para trabalhar com valores monetários, é recomendado usar o tipo decimal,
    //pois ele tem uma precisão maior do que o tipo float ou double,
    //o que é importante para evitar erros de arredondamento em cálculos financeiros.
    {
        get => precoAtributo;
        set
        {
            if (value > 0)
                precoAtributo = value;
            else
                precoAtributo = 10;
        }
    }
    public int EstoquePropriedade
    {
        get => estoqueAtributo;
        set
        {
            if (value > 0)
                estoqueAtributo = value;
            else
                estoqueAtributo = 0;
        }
    }
    public string DescricaoProduto => $"{this.NomePropriedade} {this.MarcaPropriedade} - {this.PrecoPropriedade}";
}
