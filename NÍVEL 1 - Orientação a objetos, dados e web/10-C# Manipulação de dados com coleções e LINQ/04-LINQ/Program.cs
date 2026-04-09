using _04_LINQ;
/*
Fluxo Padrão: Estágio 1 (Origem Dados) > Estágio 2 > ... > Estágio N
LINQ - Categorias de operações para manipulação de coleções
============================================================
Filtro (+)      | coleção c/ tam menor/igual atendendo condição | Where, Distinct
Projeção (+)    | coleção transformada, do mesmo tipo ou não     | Select, SelectMany
Ordenação (+)   | coleção ordenada pela expressão lambda        | OrderBy, ThenBy
Agregação (*)   | valor único a partir de operação de acúmulo   | Sum, Min, Max
Agrupamento (+) | coleção de grupos onde a chave é o argumento  | GroupBy
Elementos (*)   | elemento único T a partir do argumento        | First, Last, MinBy
Existência (*)  | booleano a partir da operação e argumento     | All, Any, Contains
Conversão (*)   | coleção em outra estrutura                    | ToList, ToArray

+ operações avalidas sob demanda (yield)
* operações avalidas imediatamente
*/
var leitorMusicas = new LeitorMusicasCSV("musicas.csv");
//=======================================================================
static void OperacoesVerificacoesDeExistencia(LeitorMusicasCSV leitorMusicas)
{
    Console.WriteLine("\nLINQ, Operações de Verificação de Existência:");
    var musicas = leitorMusicas.ToList();
    var artistas = musicas
        .GroupBy(m => m.Artista)
        .Where(g => g.Any(m => m.Duracao >= 500));
    Console.WriteLine("\nArtistas com músicas maiores que 500 segundos:");
    foreach (var grupo in artistas)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- {grupo.Key}");
        Console.ResetColor();
    }

    var reggae = musicas
    .GroupBy(m => m.Artista)
    .Where(g => g.Any(m => m.Generos.Contains("Reggae")));
    Console.WriteLine("\nArtistas com músicas do gênero Reggae:");
    foreach (var grupo in reggae)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- {grupo.Key}");
        Console.ResetColor();
    }
}
OperacoesVerificacoesDeExistencia(leitorMusicas);
//=======================================================================
static void ArtistaComMaiorQuantidadeDeMusicas(LeitorMusicasCSV leitorMusicas)
{
    Console.WriteLine("\nLINQ, Métodos de Quantificação: Artista Com Maior Quantidade De Musicas");
    var artistasComMuitasMusicas = leitorMusicas
        .GroupBy(m => m.Artista)
        .Select(g => new { Artista = g.Key, Musicas = g, Total = g.Count() })//cria um objeto anônimo para armazenar o nome do artista e a quantidade de músicas associadas a ele.
        .MaxBy(a => a.Total);
    if(artistasComMuitasMusicas != null)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"O Artista com maior quantidade de músicas é: {artistasComMuitasMusicas.Artista} - Total de músicas: {artistasComMuitasMusicas.Total}");
        Console.ResetColor();
    }
}
//ArtistaComMaiorQuantidadeDeMusicas(leitorMusicas);
//=======================================================================
static void ObtencaoDeUmElemento(LeitorMusicasCSV leitorMusicas)
{
    Console.WriteLine("\nLINQ, Métodos de Obtenção de um Elemento:");
    var musicas = leitorMusicas.ToList();
    var primeiraMusica = musicas.First(); //Categoria de Obtenção de um Elemento, retorna o primeiro elemento da coleção, lançando uma exceção se a coleção estiver vazia.
        //.FirstOrDefault(); //Categoria de Obtenção de um Elemento, retorna o primeiro elemento da coleção ou um valor padrão se a coleção estiver vazia.
    if (primeiraMusica != null)
    {
        Console.WriteLine("\nExibindo a primeira música da coleção:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{primeiraMusica.Artista} - {primeiraMusica.Titulo}, {primeiraMusica.Duracao} seg. - Gêneros: {string.Join(", ", primeiraMusica.Generos)}");
        Console.ResetColor();
    }
    var maiorMusica = musicas.MaxBy(m => m.Duracao); //Categoria de Obtenção de um Elemento, retorna o elemento com o valor máximo para a chave especificada.
    if (maiorMusica != null)
    {
        Console.WriteLine("\nExibindo a maior (duração) música da coleção:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{maiorMusica.Artista} - {maiorMusica.Titulo}, {maiorMusica.Duracao} seg. - Gêneros: {string.Join(", ", maiorMusica.Generos)}");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("A coleção de músicas está vazia.");
    }
}
//ObtencaoDeUmElemento(leitorMusicas);
//=======================================================================
static void AgruparMusicasPorArtista(LeitorMusicasCSV leitorMusicas)
{
    Console.WriteLine("\nLINQ, Métodos de Agrupamento: Exibindo músicas agrupadas por artista:");
    var musicasAgrupadas = leitorMusicas
        .GroupBy(m => m.Artista)//Categoria de Agrupamento, agrupa os elementos da coleção com base em uma chave especificada, retornando uma coleção de grupos.
        .OrderBy(g => g.Key);//Categoria de Ordenação, ordena os grupos pelo nome do artista (chave do grupo).
    foreach (var grupo in musicasAgrupadas.Take(5))
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nArtista: {grupo.Key} - Total de músicas: {grupo.Count()}");
        Console.ResetColor();
        foreach (var musica in grupo)
        {
            Console.WriteLine($"  - {musica.Titulo} ({musica.Duracao} seg.) - Gêneros: {string.Join(", ", musica.Generos)}");
        }
    }
}
//AgruparMusicasPorArtista(leitorMusicas);
//=======================================================================
//Agregações: São operações que produzem um único valor a partir de uma coleção de elementos, como contagem, soma, média, mínimo e máximo.
static void AgregacaoEstatisticasMusicas(LeitorMusicasCSV leitorMusicas)
{
    var collectionMusicas = leitorMusicas.ToList();//ToList() é usado para materializar a coleção, permitindo que as operações de agregação sejam realizadas de forma eficiente, evitando múltiplas iterações sobre a coleção original.
    //Após a materialização da coleção, percorremos apenas uma vez a coleção completa, evitando múltiplas iterações sobre a coleção original.
    Console.WriteLine("\nLINQ, Métodos de Agregação: Exibindo estatísticas das músicas:");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\nExistem {collectionMusicas.Count()} músicas na coleção.");
    Console.WriteLine($"\nExistem {collectionMusicas.Count(m => m.Duracao > 600)} músicas com mais do que 10 minutos na coleção.");
    Console.WriteLine($"\nA música com menor duração da coleção leva {collectionMusicas.Min(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nA música com maior duração da coleção leva {collectionMusicas.Max(m => m.Duracao)} segundos.");
    Console.WriteLine($"\nA duração média das músicas da coleção é {Math.Round(collectionMusicas.Average(m => m.Duracao))} segundos.");//sem casas decimais, arredondado para o inteiro mais próximo: Math.Round().
    Console.WriteLine($"\nVocê vai levar {Math.Round(TimeSpan.FromSeconds(collectionMusicas.Sum(m => m.Duracao)).TotalDays)} dias para ouvir toda a coleção!");
    Console.ResetColor();
}
//AgregacaoEstatisticasMusicas(leitorMusicas);
//=======================================================================
static void ProjecaoListaGeneros(LeitorMusicasCSV leitorMusicas)
{
    Console.WriteLine("\nLINQ, Métodos de Projeção: Exibindo lista de gêneros:");
    var generos = leitorMusicas
        .SelectMany(m => m.Generos)//SelectMany é usado para projetar e achatar coleções aninhadas.
        .Distinct()
        .OrderBy(g => g)
        .ToList();
    foreach (var genero in generos)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(genero);
        Console.ResetColor();
    }
}
//ProjecaoListaGeneros(leitorMusicas);
//=======================================================================
static void ProjecaoListaArtistas(LeitorMusicasCSV leitorMusicas)
{
    Console.WriteLine("\nLINQ, Métodos de Projeção: Exibindo lista de artistas:");
    var artistas = leitorMusicas
        .Select(m => m.Artista)//Categoria: Projeção (Transformação), Projeta cada elemento da coleção para um novo formato, retornando uma nova coleção com os elementos projetados.
        .Distinct()//Categoria: Distinct, Remove elementos duplicados da coleção, retornando uma nova coleção com elementos únicos.
        .OrderBy(a => a);//Categoria de Ordenação, ordenando pelo nome do artista
    foreach (var artista in artistas)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(artista);
        Console.ResetColor();
    }
}
//ProjecaoListaArtistas(leitorMusicas);
//=======================================================================
static void FiltroEOrdenacao(IEnumerable<Musica> leitorMusicas)
{
    Console.WriteLine("\nLINQ, Métodos de Filtro e Ordenação: Exibindo as músicas FILTRADAS e ORDENADAS:");
    IEnumerable<Musica> colecaoMusicas = 
        leitorMusicas
        .Where(m => m.Artista == "Coldplay")//Categoria de Filtro, retornando apenas as que atendem a condição especificada.
        .OrderBy(m => m.Titulo)//Categoria de Ordenação, ordena a coleção, retornando uma nova coleção ordenada de forma crescente.
                               //.OrderByDescending(m => m.Titulo)
                               //.ThenBy(m => m.Duracao)//Categoria de Ordenação Secundária, ordena(OrderBy) por título e depois(ThenBy) por duração
        .Skip(5 * 3)//Categoria de Paginação, ignora os primeiros N elementos da coleção, retornando o restante.
        .Take(5);//Categoria de Limitação, limita a coleção, retornando apenas os primeiros N elementos da coleção.

    ExibirMusicas(colecaoMusicas);
}
//OperacoesDeFiltroEOrdenacao(leitorMusicas);
//=====================================================================
static void ExibirMusicas(IEnumerable<Musica> musicas)
{
    //int contador = 1;
    Console.WriteLine("\nLINQ: Exibindo lista dos 20 primeiros elementos da coleção músicas:");
    for (Int16 i = 0; i < 20; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{i+1}: {musicas.ElementAt(i).Artista} - {musicas.ElementAt(i).Titulo}, {musicas.ElementAt(i).Duracao} seg. - {string.Join(", ", musicas.ElementAt(i).Generos)}");
        Console.ResetColor();
        //contador++;
        //if (i > 20) break;
    }
}
//ExibirMusicas(leitorMusicas);
//=====================================================================


/*
    Seja um arquivo com músicas em formato CSV (Comma Separated Values). 

    Implemente as funções abaixo:
    //     [x] Leia-o como uma coleção de músicas
    //     [x] Filtre a coleção por artista (por ex. Coldplay, Metallica, AC/DC)
    //     [x] Filtre a coleção por duração (por ex. maiores que 5 minutos)
    //     [x] Ordene a coleção por artista
    //     [x] Ordene a coleção por artista e em seguida por músicas com duração crescente
    //     [X] Recupere as 10 músicas mais longas
    //     [X] Crie uma coleção de artistas
    //     [X] Crie uma coleção de gêneros
    //     [X] Crie uma coleção de artistas e suas músicas
    //     [X] Informe a duração média das músicas da coleção
    //     [X] Informe a duração total das músicas da coleção
    //     [X] Informe qual artista tem mais músicas na coleção
    //     [X] Filtre a coleção por gênero (por ex. rock)
    
*/