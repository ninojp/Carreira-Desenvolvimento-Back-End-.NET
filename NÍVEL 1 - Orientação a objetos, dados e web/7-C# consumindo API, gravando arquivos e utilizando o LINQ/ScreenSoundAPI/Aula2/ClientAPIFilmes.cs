using System.Text.Json;

namespace ScreenSoundAPI.Aula2;

internal class ClientAPIFilmes
{
    public async Task ClientAPIFIlmesConect()
    {
        using HttpClient client = new();
        try
        {
            string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nResposta(string) sem formatação(Serializada): {resposta}");
            var listaFilmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
            Console.WriteLine($"\nResposta Formatada (Desserializada): {listaFilmes.Count}");
            foreach (var filme in listaFilmes)
            {
                Filme.ExibirDetalhesDoFilme(filme);
            }
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            Console.ResetColor();
        }
    }
}
