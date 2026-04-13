using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Aula2;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }

    [JsonPropertyName("autor")]
    public string Autor { get; set; }

    [JsonPropertyName("ano_publicacao")]
    public int AnoPublicacao { get; set; }

    [JsonPropertyName("genero")]
    public string Genero { get; set; }

    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    [JsonPropertyName("editora")]
    public string Editora { get; set; }

    public static void ExibirDetalhesDoLivro(Livro livro)
    {
        Console.WriteLine($"\nTítulo: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
        Console.WriteLine($"Ano de Publicação: {livro.AnoPublicacao}");
        Console.WriteLine($"Gênero: {livro.Genero}");
        Console.WriteLine($"Número de Páginas: {livro.Paginas}");
        Console.WriteLine($"Editora: {livro.Editora}");
    }
}
