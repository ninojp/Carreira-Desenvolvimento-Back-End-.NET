using _02_OperacoesEmColecoes;
using System.Collections;

Musica musica1 = new() { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
Musica musica2 = new() { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 205 };
Musica musica3 = new() { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 330 };
Musica musica4 = new() { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 230 };
Musica musica5 = new() { Titulo = "Lavo ta novo", Artista = "Raimundos", Duracao = 430 };
Musica musica6 = new() { Titulo = "Pais e Filhos", Artista = "Legião Urbana", Duracao = 300 };
Musica musica7 = new() { Titulo = "Me Adora", Artista = "Pitty", Duracao = 240 };
Musica musica8 = new() { Titulo = "Mulher de Fases", Artista = "Raimundos", Duracao = 210 };
Musica musica9 = new() { Titulo = "O Segundo Sol", Artista = "Nando Reis", Duracao = 260 };
PlayList rockNacional = new() { Nome = "Rock Nacional" };
rockNacional.Add(musica1);
rockNacional.Add(musica2);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);
rockNacional.Add(musica6);
rockNacional.Add(musica7);
rockNacional.Add(musica8);
rockNacional.Add(musica9);
//rockNacional.Add(musica2);// Ao tentar adicionar o mesmo Objeto musica2, não será adicionado.
//rockNacional.Add(new Musica() { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 });// Ao tentar adicionar um NOVO Objeto com os mesmos dados de musica1, será adicionado.
PlayList.ExibirPlayList(rockNacional);
//------------------------------------
PlayList PlaylistLegiao = new() { Nome = "PlayList Legião Urbana" };
PlaylistLegiao.Add(musica1);
PlaylistLegiao.Add(musica3);
PlaylistLegiao.Add(musica4);
PlaylistLegiao.Add(musica6);
//PlayList.ExibirPlayList(PlaylistLegiao);
//------------------------------------
var playerMusica = new PlayerDeMusica();
playerMusica.AdicionarNaFila(musica7);
playerMusica.AdicionarNaFila(rockNacional);
//=====================================================
void ExibirFilaDeReproducao(PlayerDeMusica player)
{
    Console.WriteLine("\nExibindo fila de reprodução:");
    foreach (var musica in player.Fila())
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- {musica.Titulo} - {musica.Artista}");
        Console.ResetColor();
    }
}
ExibirFilaDeReproducao(playerMusica);
//=====================================================
void ExibirHistoricoDeReproducao(PlayerDeMusica player)
{
    Console.WriteLine("\nExibindo histórico de reprodução:");
    foreach (var musica in player.Historico())
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- {musica.Titulo} - {musica.Artista}");
        Console.ResetColor();
    }
}
ExibirHistoricoDeReproducao(playerMusica);
//=====================================================
void ProximaMusica(PlayerDeMusica player)
{
    Console.WriteLine("\nExibindo fila de reprodução:");
    var proximaMusica = player.ProximaMusicaDaFila();
    if (proximaMusica is not null)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Tocando música: {proximaMusica.Titulo} - {proximaMusica.Artista}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nA fila de reprodução está vazia!");
        Console.ResetColor();
    }
}
ProximaMusica(playerMusica);
//=====================================================
ExibirHistoricoDeReproducao(playerMusica);
//=====================================================
void MusicaAnterior(PlayerDeMusica player)
{
    Console.WriteLine("\nExibindo fila de reprodução:");
    var musicaAnterior = player.MusicaAnterior();
    if (musicaAnterior is not null)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Tocando música: {musicaAnterior.Titulo} - {musicaAnterior.Artista}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nO histórico de reprodução está vazio!");
        Console.ResetColor();
    }
}
MusicaAnterior(playerMusica);
//=====================================================
ExibirHistoricoDeReproducao(playerMusica);
//=====================================================
void ExibirMaisTocadas(PlayList playList1, PlayList playList2)
{
    //Musica (chave/key), Contagem (valor/value)
    Dictionary<Musica, int> ranking = [];
    foreach (var musica in playList1)
    {
        ranking.Add(musica, 1);
    }
    foreach (var musica in playList2)
    {
        if (ranking.TryGetValue(musica, out int contagem))
        {
            contagem++;
            ranking[musica] = contagem;
        }
        else
        {
            ranking[musica] = 1;
        }
    }
    List<KeyValuePair<Musica, int>> top3 = new(ranking); //[..ranking]
    top3.Sort(new PorContagem());
    Console.WriteLine("\nTop 3 músicas mais incluídas nas playlists:");
    int contador = 1;
    foreach (var par in top3)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"- {par.Key.Titulo} ({par.Value} vezes)");
        Console.ResetColor();
        contador++;
        if (contador > 3) break;
    }
}
//ExibirMaisTocadas(rockNacional, PlaylistLegiao);
//=====================================================
void obterPorTitulo(PlayList playList, string titulo)
{
    var musicaEncontrada = playList.ObterMusicaPeloTitulo(titulo);
    if (musicaEncontrada is not null)
    {
        Console.WriteLine($"\nObter música pelo título: {musicaEncontrada.Titulo}");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Música encontrada: {musicaEncontrada.Titulo} - {musicaEncontrada.Artista}");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("\nMúsica não encontrada na playlist!");
    }
}
//obterPorTitulo(rockNacional, "Geração Coca-Cola");
//=======================================================================
void RemoverPorTitulo(PlayList playList, string titulo)
{
    var musicaEncontrada = playList.ObterMusicaPeloTitulo(titulo);
    if (musicaEncontrada is not null)
    {
        Console.WriteLine($"\nRemovendo a musica -> {musicaEncontrada.Titulo}...");
        var resultadoRemocao = playList.Remove(musicaEncontrada);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(resultadoRemocao ? "Música removida com sucesso!" : "Falha ao remover a música.");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("\nMúsica não encontrada na playlist!");
    }
    PlayList.ExibirPlayList(playList);
}
//RemoverPorTitulo(rockNacional, "Geração Coca-Cola");
//=======================================================================
void ObterMAleatoria(PlayList playList)
{
    var musicaAleatoria = playList.ObterMusicaAleatoria();
    Console.WriteLine("\nObtendo música aleatória da playlist...");
    if (musicaAleatoria is not null)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Música aleatória: {musicaAleatoria.Titulo} - {musicaAleatoria.Artista}");
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine("A playlist está vazia!");
    }
}
//ObterMAleatoria(rockNacional);
//=======================================================================
void OrdenarPorArtista(PlayList playList)
{
    Console.WriteLine("\nOrdenando músicas por artista...");
    playList.OrdenarMusicasPorArtista();
    PlayList.ExibirPlayList(playList);
}
//OrdenarPorArtista(rockNacional);
//-----------------------------------------------------------------------
void OrdenarPorDuracao(PlayList playList)
{
    Console.WriteLine("\nOrdenando músicas por duração...");
    playList.OrdenarMusicasPorDuração();
    PlayList.ExibirPlayList(playList);
}
//OrdenarPorDuracao(rockNacional);
//-----------------------------------------------------------------------
void OrdenarPorTitulo(PlayList playList)
{
    Console.WriteLine("\nOrdenando músicas por título...");
    playList.OrdenarMusicasPorTitulo();
    PlayList.ExibirPlayList(playList);
}
//OrdenarPorTitulo(rockNacional);
//-----------------------------------------------------------------------


/***********************************************************************************************************************
    Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas favoritas em 
    playlists personalizadas. Para cada playlist, é essencial que o usuário tenha controle total sobre a sequência
    de reprodução das músicas, permitindo reordená-las livremente a qualquer momento. Além disso, o aplicativo precisa
    oferecer a funcionalidade de reprodução aleatória para uma playlist específica, proporcionando uma experiência de
    audição dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio é criar uma
    estrutura robusta que suporte a adição e remoção eficiente de músicas, a reordenação flexível dentro das playlists
    e a seleção de faixas tanto em modo sequencial quanto aleatório.

    Funções que vamos implementar:
    //     [X] Criar as classes para musicas e playlist
    //     [X] Listar músicas da playlist
    //     [X] Adicionar música à playlist
    //     [X] Obter uma música específica da playlist
    //     [X] Remover música da playlist
    //     [X] Tocar músicas da playlist em modo aleatório 
    //     [X] Reordenar músicas segundo alguma lógica específica (ex. duração)
    //     [ ] Uma playlist não pode ter músicas repetidas
    //     [ ] Exibir as 10 músicas mais tocadas em todas as playlists (ranking)
    //     [ ] Player de música com:
    //     [ ] - Fila de reprodução (para músicas avulsas e/ou playlists)
    //     [ ] - Histórico de reprodução 
*/
