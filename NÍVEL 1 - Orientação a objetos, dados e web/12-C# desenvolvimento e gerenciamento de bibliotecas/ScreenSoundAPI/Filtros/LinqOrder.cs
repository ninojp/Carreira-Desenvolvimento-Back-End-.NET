using ScreenSoundAPI.Models;
namespace ScreenSoundAPI.Filtros;
internal class LinqOrder
{
    public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.Select(m => m.Artista).Distinct().OrderBy(a => a).ToList();
        Console.WriteLine("Artistas ordenados alfabeticamente:");
        foreach (var artista in artistasOrdenados)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(artista);
            Console.ResetColor();
        }
    }
}
