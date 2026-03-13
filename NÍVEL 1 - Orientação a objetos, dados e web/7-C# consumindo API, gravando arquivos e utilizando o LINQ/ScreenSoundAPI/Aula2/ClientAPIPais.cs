using System.Text.Json;

namespace ScreenSoundAPI.Aula2;

internal class ClientAPIPais
{
    internal static async Task<List<Pais>?> ConectionAPIPais()
    {
        using HttpClient client = new();
        try
        {
            string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
            return JsonSerializer.Deserialize<List<Pais>>(resposta)!;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Class ClientAPIPais: Ocorreu um erro: {ex.Message}");
            Console.ResetColor();
            return null;
        }
    }
}
