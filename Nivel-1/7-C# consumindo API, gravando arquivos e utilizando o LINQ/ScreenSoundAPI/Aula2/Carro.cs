using System.Text.Json.Serialization;
namespace ScreenSoundAPI.Aula2;
internal class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }

    [JsonPropertyName("ano")]
    public int Ano { get; set; }

    [JsonPropertyName("tipo")]
    public string Tipo { get; set; }

    [JsonPropertyName("motor")]
    public string Motor { get; set; }

    [JsonPropertyName("transmissao")]
    public string Transmissao { get; set; }

    public static void ExibirDetalhesDoCarro(Carro carro)
    {
        Console.WriteLine($"\nMarca: {carro.Marca}");
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Ano: {carro.Ano}");
        Console.WriteLine($"Tipo: {carro.Tipo}");
        Console.WriteLine($"Motor: {carro.Motor}");
        Console.WriteLine($"Transmissão: {carro.Transmissao}");
    }
}
