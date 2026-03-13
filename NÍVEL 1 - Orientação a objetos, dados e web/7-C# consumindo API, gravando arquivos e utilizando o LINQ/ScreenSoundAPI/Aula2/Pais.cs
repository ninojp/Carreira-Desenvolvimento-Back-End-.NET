using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Aula2;

internal class Pais
{
    [JsonPropertyName("continente")]
    public string Continente { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    public static void ExibirDetalhesDoPais(Pais pais)
    {
        Console.WriteLine($"\nContinente: {pais.Continente}");
        Console.WriteLine($"Nome: {pais.Nome}");
        Console.WriteLine($"Idioma: {pais.Idioma}");
        Console.WriteLine($"Capital: {pais.Capital}");
        Console.WriteLine($"População: {pais.Populacao}");
    }
}
