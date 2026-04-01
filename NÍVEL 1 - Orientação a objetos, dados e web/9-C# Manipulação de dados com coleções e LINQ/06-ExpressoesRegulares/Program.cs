using System.Text.RegularExpressions;
//Expressões regulares são padrões usados para encontrar combinações de caracteres em strings.
//Elas são muito úteis para validação, extração e manipulação de texto.
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

//var linha = "The Broken Road;Rolling Stones;6:39;Rock, Blues Rock;13/09/1974";
/*
    [X] encontrando artistas com caracteres especiais
    [X] encontrando títulos com duas palavras
    [X] encontrando títulos que começam e terminam com a mesma palavra
    [X] encontrando títulos com letras repetidas mais ou igual a 3 vezes
    [X] encontrando títulos com números romanos
*/
//=============================================================================
void MusicasComNumerosRomanos()
{
    Console.WriteLine($"\nEncontrando títulos com números romanos");
    var regex = new Regex(@"\b[IVXLCDM]+\b");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);
    ExibirMusicasEmTabela(musicas);
}
MusicasComNumerosRomanos();
//=============================================================================
void MusicasComLetrasRepetidas()
{
    Console.WriteLine($"\nEncontrando títulos com letras repetidas mais ou igual a 3 vezes");
    //var regex = new Regex(@"(\w).*\1.*\1");
    var regex = new Regex(@"\w*(\w)\1{2,}\w*");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);
    ExibirMusicasEmTabela(musicas);
}
//MusicasComLetrasRepetidas();
//=============================================================================
void MusicasComecamETerminamMesmaPalavra()
{
    Console.WriteLine($"\nEncontrando títulos que começam e terminam com a mesma palavra");
    var regex = new Regex(@"^(\w+).*\1$");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);

    ExibirMusicasEmTabela(musicas);
}
//MusicasComecamETerminamMesmaPalavra();
//=============================================================================
void MusicasComDuasPalavras()
{
    Console.WriteLine($"\nEncontrando títulos com duas palavras");
    var regex = new Regex(@"^\w+\s\w+$");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(10);

    ExibirMusicasEmTabela(musicas);
}
//MusicasComDuasPalavras();
//=============================================================================
void ArtistasComCaracteresEspeciais()
{
    Console.WriteLine($"\nEncontrando artistas com caracteres especiais");
    var regex = new Regex(@"[^a-zA-Z0-9 ]");//Instanciar primeiro a expressão regular, para depois usar o método IsMatch, evitando a necessidade de criar um novo objeto Regex a cada iteração do loop.
    var artistas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Artista))
        .Select(m => m.Artista)
        .Distinct()
        .OrderBy(a => a);
    foreach (var artista in artistas) Console.WriteLine(artista); ;
}
//ArtistasComCaracteresEspeciais();
//=============================================================================
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:"; // string literal
                                          //var titulo = new string("\nMúsicas do arquivo:");

    Console.WriteLine(titulo);
    foreach (var musica in musicas)
    {
        var linha = $"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao}s [{musica.Lancamento}]";
        Console.WriteLine(linha);
    }
}

void ExibirMusicasEmTabela(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:"; // string literal
    Console.WriteLine(titulo);

    var colunaTitulo = "Título".PadRight(40);
    var colunaArtista = "Artista".PadRight(30);
    var colunaDuracao = "Duração".PadRight(10);
    var colunaLancamento = "Lançada Em".PadRight(15);
    Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
    var borda = "".PadRight(100, '=');
    Console.WriteLine(borda);

    foreach (var musica in musicas)
    {
        var duracao = string.Format("{0,-10:F3}", musica.Duracao / 60.0);
        var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{duracao}{musica.Lancamento,-15:dd/MM/yyyy}";
        Console.WriteLine(linha);
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');

        var duracao = 0; // valor padrão caso a duração não seja encontrada ou seja inválida
        var correspondente = Regex.Match(linha, @"(\d?\d):(\d\d)");
        if (correspondente.Success)
        {
            var minutos = int.TryParse(correspondente.Groups[1].Value, out int min) ? min : 0;
            var segundos = int.TryParse(correspondente.Groups[2].Value, out int seg) ? seg : 0;
            //Console.WriteLine($"Duração encontrada! {minutos} minutos e {segundos} segundos");
            duracao = (minutos * 60 + segundos);
        }
        else
        {
            Console.WriteLine("Duração não encontrada!");
        }

        if (partes.Length == 5)
        {
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título não encontrado" : partes[0],
                Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista não encontrado" : partes[1],
                //Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 350,
                Duracao = duracao,
                Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
                Lancamento = DateTime.TryParse(partes[4], out var data) ? data : DateTime.Today
            };
            yield return musica;
        }
        linha = stream.ReadLine();
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Fim da leitura do arquivo.csv.\n");
    Console.ResetColor();
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
    public DateTime Lancamento { get; set; }

    public override string ToString()
    {
        return $"{Titulo} ({Artista}) - {Duracao}s [{Lancamento}]";
    }
}