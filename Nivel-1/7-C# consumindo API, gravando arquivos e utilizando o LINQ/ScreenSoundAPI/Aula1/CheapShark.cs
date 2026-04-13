namespace ScreenSoundAPI.Aula1;

internal class CheapShark
{
    public string? ConnectionAPICheapShark()
    {
        using HttpClient client = new();
        try
        {
            string resposta = client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals").Result;
            return resposta;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            Console.ResetColor();
            return null;
        }
    }
}
