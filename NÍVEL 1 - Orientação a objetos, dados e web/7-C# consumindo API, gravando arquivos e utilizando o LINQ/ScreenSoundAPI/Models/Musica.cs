using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? SongNome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"\nMúsica: {SongNome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao /1000} segundos");
        Console.WriteLine($"Gênero: {Genero}\n");
    }
}
