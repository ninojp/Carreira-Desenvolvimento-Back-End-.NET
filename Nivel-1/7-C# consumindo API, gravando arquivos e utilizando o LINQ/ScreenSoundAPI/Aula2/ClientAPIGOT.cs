using System.Text.Json;
namespace ScreenSoundAPI.Aula2
{
    internal class ClientAPIGOT
    {
        internal static async Task<PersonagemGOT?> ConectAPIGOT()
        {
            using HttpClient client = new();
            try
            {
                string resposta = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
                return JsonSerializer.Deserialize<PersonagemGOT>(resposta)!;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nClasse ClientAPIGOT - Ocorreu um erro: {ex.Message}");
                Console.ResetColor();
                return null;
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nClasse ClientAPIGOT - Conexão feita e finalizada.");
                Console.ResetColor();
            }
        }
    }
}
