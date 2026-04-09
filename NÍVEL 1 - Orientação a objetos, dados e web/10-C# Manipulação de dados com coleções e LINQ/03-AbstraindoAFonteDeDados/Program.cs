using _03_AbstraindoAFonteDeDados;

// O LeitorMusicasCSV encapsula a lógica de leitura do arquivo e permite múltiplas iterações
// abrindo o arquivo novamente a cada iteração, economizando memória.
var leitorMusicas = new LeitorMusicasCSV("musicas.csv");

// 1ª Estágio: Ler os Dados, seja arquivo CSV, texto, .JSON, APIExterna.
// 2ª Estágio: Manipular os dados, filtrar, ordenar...
IEnumerable<Musica> colecaoMusicasColdplay =
    leitorMusicas
    .Where(static m => m.Artista.StartsWith(value: "C"))
    .Where(m => m.Duracao > 400);
    //.FiltrarPor(m => m.Duracao > 400);
    //.FiltrarPor(static m => m.Artista.StartsWith(value: "C"))
    //.FiltrarPor(m => m.Artista == "Coldplay")

Console.WriteLine("\nExibindo as 10 primeiras músicas que começam com C:");
ExibirMusicas(colecaoMusicasColdplay);

//Resetar o StreamReader, reseta a posição do leitor para o início do arquivo, permitindo uma nova leitura.
//leitorCSV.BaseStream.Seek(0, SeekOrigin.Begin);
//leitorCSV.DiscardBufferedData();
//=======================================================================
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    int contador = 1;
    foreach (var musica in musicas)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{musica.Artista} - {musica.Titulo}, {musica.Duracao} segundos");
        Console.ResetColor();
        contador++;
        if (contador > 20) break; //Limita a exibição a 20 músicas para evitar poluição visual.
    }
}
Console.WriteLine("\nExibindo as 20 primeiras músicas do Arquivo CSV:");
IEnumerable<Musica> colecaoMusicas = leitorMusicas; //A coleção de músicas é obtida diretamente do leitor, que lê o arquivo CSV.
//.ToList(); //Poderia! Lê o arquivo UMA vez, guarda tudo na memória
ExibirMusicas(colecaoMusicas);
//=====================================================================
bool FiltrarPorArtista(Musica musica) => musica.Artista == "Coldplay";

Func<Musica, bool> condicao = FiltrarPorArtista; //DELEGATE: Representa um método que pode ser passado como argumento para outro método, permitindo a execução de código personalizado. Func<Musica, bool> é um tipo de delegate que representa um método que recebe um objeto do tipo Musica e retorna um valor booleano (true ou false). Nesse caso, condicao é uma variável do tipo Func<Musica, bool> que armazena a referência ao método FiltrarPorArtista. Isso permite que o método FiltrarPorArtista seja chamado indiretamente através da variável condicao, facilitando a reutilização do código e a aplicação de diferentes critérios de filtragem sem modificar a lógica principal.

/************************************************************************************************************************
    Seja um arquivo com músicas em formato CSV (Comma Separated Values), valores separados por um caractere de separação. 

    Implemente as funções abaixo:
    //     [X] Leia-o como uma coleção de músicas
    //     [X] Filtre a coleção por artista (por ex. Coldplay, Metallica, AC/DC)
    //     [] Filtre a coleção por gênero (por ex. rock)
    //     [X] Filtre a coleção por duração (por ex. maiores que 5 minutos)
    //     [X] Ordene a coleção por artista
    //     [] Ordene a coleção por artista e em seguida por músicas com duração crescente
    //     [ ] Crie uma coleção de artistas e suas músicas
    //     [ ] Informe a duração média das músicas da coleção
    //     [ ] Informe a duração total das músicas da coleção
    //     [ ] Informe qual artista tem mais músicas na coleção
 
*/