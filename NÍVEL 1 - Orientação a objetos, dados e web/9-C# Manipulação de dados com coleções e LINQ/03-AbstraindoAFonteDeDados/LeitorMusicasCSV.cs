using System.Collections;

namespace _03_AbstraindoAFonteDeDados;

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
                Duracao = Convert.ToInt32(partesDaLinha[2])
            };
            yield return musica;
            linha = leitorCSV.ReadLine();
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
