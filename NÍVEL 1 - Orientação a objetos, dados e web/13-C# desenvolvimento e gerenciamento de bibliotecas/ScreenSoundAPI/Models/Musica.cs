using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Musica
{
    // string[] É uma declaração de Array(tem um tamanho fixo) e NÃO uma LISTA List<string>, Lista é uma coleção dinâmica.
    private readonly string[] _listTonalidade = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

    [JsonPropertyName("song")]
    public string? SongNome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    private int? _key;

    [JsonPropertyName("key")]
    public int? KeyNumero
    {
        get => _key;
        set => _key = value;
    }
    public string? Tonalidade
    {
        get
        {
            if (_key != null && _key >= 0 && _key < _listTonalidade.Length)
            {
                return _listTonalidade[_key.Value];
            }
            else
            {
                return null;
            }
        }
    }

    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano => int.Parse(AnoString!);

    public void ExibirDetalhesDaMusica()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Música: {SongNome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Duração: {Duracao /1000} segundos");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}\n");
        Console.ResetColor();
    }
}
