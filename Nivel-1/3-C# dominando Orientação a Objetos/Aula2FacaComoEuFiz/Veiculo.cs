namespace Aula2FacaComoEuFiz;

internal class Veiculo
{
    public string Marca { get; }
    public string Modelo { get; }
    public int Ano { get; }
    public string Placa { get; }
    public Veiculo(string marca, string modelo, int ano, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Placa = placa;
    }
    public void ExibirInformacoesVeiculo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}
