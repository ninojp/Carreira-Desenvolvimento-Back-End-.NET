using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

//=================================================================================
var musicas = ObterMusicasSafe(stream)
    .Take(10);

ExibirMusicasEmTabela(musicas);
//=====================================================
IEnumerable<Musica> ObterMusicasSafe(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');
        if (partes.Length == 5)
        {
            //int duracao = 350;
            //bool duracaoValida = int.TryParse(partes[2], out duracao);
            //var duracaoInt = int.TryParse(partes[2], out int duracaoParse);
            //Console.WriteLine($"Duração é válida: {duracaoValida}, após o parse: {duracao}");
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título Desconhecido" : partes[0],
                Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista Desconhecido" : partes[1],
                Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 0,
                Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
                Lancamento = DateTime.TryParse(partes[4], out var data) ? data : DateTime.Today
            };
            yield return musica;
        }
        linha = stream.ReadLine();
    }
}
//=================================================================================
//Heap (Heap Allocation Area) é a área de memória onde os objetos são alocados.
//O Heap é gerenciado pelo Garbage Collector, que é responsável por liberar a memória dos objetos que não são mais utilizados.
//=================================================================================
//STRING POOL: Entendendo como o .NET trabalha internamente com as strings.
void InterningDeStrings()
{
    //String Pool é uma área específica dentro do Heap onde as strings literais são armazenadas
    var artista1 = "Coldplay";//INTERNING, quando declaramos de forma "literal", o .NET utiliza o String Pool
    var artista2 = "Coldplay";
    var artista3 = new string("Coldplay");//Não faz o Interning, new string cria uma nova instância. 
    var artista4 = "COLDPLAY";
    var artista5 = artista1.ToUpper();//Não faz o Interning, e vai usar a memória comum, HEAP.
    var artista6 = string.Intern(artista1.ToUpper());//Faz o Interning, forçando a utilização do String Pool.
    Console.WriteLine(artista1 == artista2);//true
    Console.WriteLine(ReferenceEquals(artista1, artista2));//true, o .NET otimiza usando o String Pool.
    Console.WriteLine(ReferenceEquals(artista1, artista3));//false, não utiliza o String Pool.
    Console.WriteLine(ReferenceEquals(artista1, artista4));//false
    Console.WriteLine(ReferenceEquals(artista1, artista5));//false
    Console.WriteLine(ReferenceEquals(artista4, artista6));//true
}
//InterningDeStrings();
//=================================================================================
void ComparandoStrings()
{
    var musicas = ObterMusicas(stream)
        .Where(m => m.Artista.Equals("COLDPLAY", StringComparison.OrdinalIgnoreCase))
        .Take(20);
    // métodos que utilizam StringComparison
    "Coldplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase);
    "Coldplay".EndsWith("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".IndexOf("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Contains("OLD", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Replace("cold", "warm", StringComparison.OrdinalIgnoreCase);

    ExibirMusicasEmTabela(musicas);
}
//ComparandoStrings();
//=======================================================
void ExibirMusicasEmTabela(IEnumerable<Musica> musicas)
{
    Console.WriteLine("\nMúsicas do arquivo musicas.csv:");
    string colunaTitulo = "Título".PadRight(35);
    string colunaArtista = "Artista".PadRight(20);
    string colunaDuracao = "Duração".PadRight(15);
    string colunaLançamento = "Lançada em".PadRight(15);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLançamento}");
    //string borda = new('-', 95);
    string borda = "".PadRight(95, '-');
    Console.WriteLine(borda);
    Console.ResetColor();
    foreach (var musica in musicas)
    {
        var duracaoFormatada = string.Format("{0, -15:F2}", musica.Duracao / 60.0);//Poderiamos usar o método stático Format da classe string para formatar.
        Console.WriteLine($"{musica.Titulo,-35}{musica.Artista,-20}{duracaoFormatada}{musica.Lancamento,-15:dd/MM/yyyy}");
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(borda);
    Console.ResetColor();
}
//===========================================
void AlterandoOTitulo(StreamReader stream)
{
    //Aspas simples para char (apenas um caractere), aspas duplas para string (conjunto de caracteres)
    var musica = ObterMusicas(stream)
        .Where(m => m.Titulo.StartsWith('T'))
        .FirstOrDefault();
    Console.WriteLine($"\nTitulo da Musica: {musica?.Titulo}");
    //musica.Titulo.Replace("The ", "");//IMUTABILIDADE, Strings são imutáveis, ou seja, não podem ser alteradas. O método Replace retorna uma nova string com as alterações, mas não modifica a string original.
    musica.Titulo = musica.Titulo.Replace("The ", "");//Atribuindo a nova string à propriedade Titulo para atualizar o valor
    Console.WriteLine($"Titulo da Musica após replace: {musica?.Titulo}");
}
//AlterandoOTitulo(stream);
//===================================================================
static void ValidandoSenha()
{
    var senha = "Daniel123!";
    /* 0 - Possui pelo menos 8 caracteres
       1 - Possui pelo menos uma letra maiúscula
       2 - Possui pelo menos uma letra minúscula
       3 - Possui pelo menos um número
       4 - Possui pelo menos um caractere especial */
    var totalCaracteres = senha.Length;
    var totalLetrasMaiusculas = senha.Count(c => char.IsUpper(c));
    var totalLetrasMinusculas = senha.Count(c => char.IsLower(c));
    var totalNumeros = senha.Count(c => char.IsDigit(c));
    var totalCaracteresEspeciais = senha.Count(c => !char.IsLetterOrDigit(c));
    if (totalCaracteres < 8
        || totalLetrasMaiusculas == 0
        || totalLetrasMinusculas == 0
        || totalNumeros == 0
        || totalCaracteresEspeciais == 0)
    {
        Console.WriteLine("\nSenha fraca");
    }
    else
    {
        Console.WriteLine("\nSenha forte");
    }
}
//=============================================================================
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    //string titulo = new("\nMúsicas do arquivo musicas.csv:");//string object
    string titulo = "\nMúsicas do arquivo musicas.csv:";//string literal
    Console.WriteLine(titulo);
    foreach (var musica in musicas)
    {
        Console.WriteLine($"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao}s [{musica.Lancamento}]");
    }
}
//ExibirMusicas(musicasComT);

//=====================================================
IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');
        var musica = new Musica
        {
            Titulo = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            //Generos = partes[3].Split(',').Select(g => g.Trim()),//Select está criando novamente uma coleção de strings, onde cada string é um gênero musical o que não é muito performático.
            Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
            Lancamento = Convert.ToDateTime(partes[4])
        };
        yield return musica;
        linha = stream.ReadLine();
    }
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