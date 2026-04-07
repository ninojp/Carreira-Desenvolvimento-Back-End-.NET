using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Models;
using System.Text.Json;
using ReportGenerator;
using ScreenSoundAPI;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nAdicionando a Biblioteca que criamos, para gerar relatórios em um arquivo.CSV");
        Console.ResetColor();

        List<Dictionary<string, string>> reportData = new();

        foreach (var musica in musicas)
        {
            var record = new Dictionary<string, string>
            {
                {"Nome", musica.SongNome },
                {"Artista", musica.Artista },
                {"Genero", musica.Genero },
                {"Tonalidade", musica.Tonalidade },
                {"Ano", musica.Ano.ToString() }
            };
        reportData.Add(record);
        }
        //IReportGenerator reportGenerator = new CSVReporterGenerator(reportData);
        //reportGenerator.Title = "Relatório de Músicas";

        CSVGenerator reportGenerator = new CSVGenerator(reportData);
        string caminhoRelatorio = reportGenerator.GerarRelatorio("relatorio_musicas.csv");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nRelatório gerado com sucesso! Caminho: {caminhoRelatorio}");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        Console.ResetColor();
    }
}
//===============================================================
