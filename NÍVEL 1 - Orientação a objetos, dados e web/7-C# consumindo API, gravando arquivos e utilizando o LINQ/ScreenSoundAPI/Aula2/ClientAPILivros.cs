using System.Text.Json;
namespace ScreenSoundAPI.Aula2;
internal class ClientAPILivros
{
    public static async Task<List<Livro>?> ConectAPILivros()
    {
        using HttpClient client = new();
        try
        {
            string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
            return JsonSerializer.Deserialize<List<Livro>>(resposta);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nClasse ClientAPILivros - Ocorreu um erro: {ex.Message}");
            Console.ResetColor();
            return null;
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nClasse ClientAPILivros - Conexão finalizada.");
            Console.ResetColor();
        }
    }
}
