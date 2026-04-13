using System.Collections;
namespace _04_LINQ;

internal class LeitorMusicasCSV : IEnumerable<Musica>
{
    private readonly string _caminhoArquivo;

    public LeitorMusicasCSV(string caminhoArquivo)
    {
        _caminhoArquivo = caminhoArquivo;
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        using var arquivoCSV = new FileStream(_caminhoArquivo, FileMode.Open, FileAccess.Read);
        using var leitorCSV = new StreamReader(arquivoCSV);

        var linha = leitorCSV.ReadLine(); //Lê a primeira linha do arquivo
        while (linha != null)
        {
            var partesDaLinha = linha.Split(";");
            Musica musica = new()
            {
                Titulo = partesDaLinha[0],
                Artista = partesDaLinha[1],
                Duracao = Convert.ToInt32(partesDaLinha[2]),
                Generos = partesDaLinha[3].Split(",").Select(g => g.Trim())
            };
            yield return musica;
            linha = leitorCSV.ReadLine();
        }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Leitura completa, Fim do arquivo.");
        Console.ResetColor();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
