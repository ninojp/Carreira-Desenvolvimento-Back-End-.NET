namespace _03_AbstraindoAFonteDeDados;

static class MusicasExtensions
{
    public static IEnumerable<T> FiltrarPor<T>(this IEnumerable<T> colecao, Func<T, bool> condicao)
    {
        foreach (var elemento in colecao)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (condicao(elemento)) yield return elemento;
            Console.ResetColor();
        }
    }
    //=======================================================================
    //public static IEnumerable<Musica> FiltrarDuracaoMaiorQue(this IEnumerable<Musica> musicas, int duracao)
    //{
    //    foreach (var musica in musicas)
    //    {
    //        Console.ForegroundColor = ConsoleColor.Cyan;
    //        if (musica.Duracao >= duracao) yield return musica;
    //        Console.ResetColor();
    //    }
    //}
    //=======================================================================
}
