using System.Text.RegularExpressions;
using System.Text.Json;

using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

/*
    1. Crie uma coleção de artistas com suas músicas ordenadas por data de lançamento. 
        Inclua o total de músicas em uma propriedade separada. 
    2. Gere um arquivo no formato JSON com essa coleção 
*/

var artistas = ObterMusicas(stream)
    .GroupBy(m => m.Artista)
    .Select(g => new
        {
            Artista = g.Key,
            Musicas = g.OrderBy(m => m.Lancamento),
            TotalMusicas = g.Count()
        })
    .ToList();

var nomeArquivoJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "artistas.json");

using var arquivoJson = new FileStream(nomeArquivoJson, FileMode.Create, FileAccess.Write);

// Utf8JsonWriter é uma classe de baixo nível para escrever JSON de forma eficiente, mas requer mais código para estruturar o JSON corretamente IDENTADO.
using var jsonWriter = new Utf8JsonWriter(arquivoJson, new JsonWriterOptions { Indented = true });
// JsonSerializer é uma classe de alto nível que simplifica a serialização de objetos para JSON, mas pode não ser tão eficiente quanto o Utf8JsonWriter para grandes volumes de dados.
JsonSerializer.Serialize(jsonWriter, artistas);
//Poderia ser feito assim também:
//var serializerOptions = new JsonSerializerOptions { WriteIndented = true };
//JsonSerializer.Serialize(jsonWriter, artistas, serializerOptions);

Console.WriteLine($"Arquivo JSON gerado: {nomeArquivoJson}");

//-----------------------------------------------------------------------------
foreach (var artista in artistas)
{
    Console.WriteLine($"\nArtista: {artista.Artista} - Total de Músicas: {artista.TotalMusicas}");
    for (int i = 0; i < artista.Musicas.Count(); i++)
    {
        var musica = artista.Musicas.ElementAt(i);
        Console.WriteLine($"{i +1} - {musica.Titulo} ({musica.Lancamento:yyyy})");
    }
}
//============================================================================
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:";
    Console.WriteLine(titulo);
    foreach (var musica in musicas)
    {
        var linha = $"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao}s [{musica.Lancamento}]";
        Console.WriteLine(linha);
    }
}

void ExibirMusicasEmTabela(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:"; // string literal
    Console.WriteLine(titulo);
    var colunaTitulo = "Título".PadRight(40);
    var colunaArtista = "Artista".PadRight(30);
    var colunaDuracao = "Duração".PadRight(10);
    var colunaLancamento = "Lançada Em".PadRight(15);
    Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
    var borda = "".PadRight(100, '=');
    Console.WriteLine(borda);
    foreach (var musica in musicas)
    {
        var duracao = string.Format("{0,-10:F3}", musica.Duracao / 60.0);
        var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{duracao}{musica.Lancamento,-15:dd/MM/yyyy}";
        Console.WriteLine(linha);
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');
        int duracao = 350;
        var match = Regex.Match(linha, @"(\d?\d):(\d\d)");
        if (match.Success)
        {
            var minutos = int.Parse(match.Groups[1].Value);
            var segundos = int.Parse(match.Groups[2].Value);
            duracao = (minutos * 60) + segundos;
        }
        if (partes.Length == 5)
        {
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título não encontrado" : partes[0],
                Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista não encontrado" : partes[1],
                Duracao = duracao,
                Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
                Lancamento = DateTime.TryParse(partes[4], out var data) ? data : DateTime.Today
            };
            yield return musica;
        }
        linha = stream.ReadLine();
    }
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
    public DateTime Lancamento { get; set; }

    public override string ToString()
    {
        return $"{Titulo} ({Artista}) - {Duracao}s [{Lancamento}]";
    }
}