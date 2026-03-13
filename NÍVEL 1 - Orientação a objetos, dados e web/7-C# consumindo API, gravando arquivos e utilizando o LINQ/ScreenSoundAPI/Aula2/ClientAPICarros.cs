using System.Text.Json;

namespace ScreenSoundAPI.Aula2;

internal class ClientAPICarros
{
    public static async Task<List<Carro>?> ConectAPICarros()
    {
        using HttpClient client = new();
        try
        {
            string respostaCarros = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
            return JsonSerializer.Deserialize<List<Carro>>(respostaCarros)!;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nClasse ClientAPICarros - Ocorreu um erro: {ex.Message}");
            Console.ResetColor();
            return null;
        }
        finally
        {
            Console.WriteLine("\nClasse ClientAPICarros - Conexão finalizada.");
        }
    }
}
