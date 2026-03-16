using ScreenSoundAPI.Models;
namespace ScreenSoundAPI.Filtros;
internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(m => m.Genero).Distinct().ToList();
        foreach (var genero in todosGenerosMusicais)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Gênero: {genero}");
            Console.ResetColor();
        }
    }
    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(m => m.Genero != null && m.Genero.Contains(genero, StringComparison.OrdinalIgnoreCase))
                                       .Select(m => m.Artista)
                                       .Distinct()
                                       .ToList();
        Console.WriteLine($"\nArtistas do gênero {genero}:");
        foreach (var artista in artistasPorGenero)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(artista);
            Console.ResetColor();
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(m => m.Artista != null && m.Artista.Contains(nomeDoArtista, StringComparison.OrdinalIgnoreCase))
                                      .ToList();
        Console.WriteLine($"\nMúsicas do artista {nomeDoArtista}:");
        foreach (var musica in musicasDoArtista)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(musica.SongNome);
            Console.ResetColor();
        }
    }
    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.SongNome) // ordena as músicas pelo nome
            .Select(musicas => musicas.SongNome) // seleciona apenas o nome das músicas
            .Distinct() // remove as duplicidades
            .ToList(); // converte o resultado em uma lista
        Console.WriteLine($"\nMúsicas do ano {ano}:");
        foreach (var musica in musicasDoAno)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(musica);
            Console.ResetColor();
        }
    }
}