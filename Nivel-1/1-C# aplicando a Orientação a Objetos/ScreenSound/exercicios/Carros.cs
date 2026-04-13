namespace ScreenSound.exercicios;
internal class Carros
//Aula 1
//4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
{
    //Atributos, são variáveis declaradas dentro de uma classe que armazenam
    //dados associados a uma instância específica desta classe.
    private int anoAtributo;
    public string FabricantePropriedade { get; set; }
    //Propriedades, são uma abstração que fornece um meio de acessar e modificar os valores
    //dos atributos de uma classe, encapsulando a lógica de leitura e escrita.
    public string ModeloPropriedade { get; set; }
    public int AnoPropriedade {
        get => anoAtributo;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }else
            {
                anoAtributo = value;
            }
        }
    }
    public string DescricaoDetalhada => $"O Carro tem modelo: {this.ModeloPropriedade}, Fabricante: {this.FabricantePropriedade} e Ano: {this.AnoPropriedade}";
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando...");
    }
    public void Frear()
    {
        Console.WriteLine("O carro está freando...");
    }
    public void Buzinar()
    {
        Console.WriteLine("O carro está buzinando...");
    }
    //Aula 2
    //2. Reescrever os atributos da classe Carro, de modo que eles sejam properties,
    //e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

}
