using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Aula2;

internal class Filme
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("title")]
    public string? TituloFilme { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }
    public static void ExibirDetalhesDoFilme(Filme filme)
    {
        Console.WriteLine($"ID: {filme.Id}");
        Console.WriteLine($"Título: {filme.TituloFilme}");
        Console.WriteLine($"Ano: {filme.Ano}");
        Console.WriteLine();
    }
}
