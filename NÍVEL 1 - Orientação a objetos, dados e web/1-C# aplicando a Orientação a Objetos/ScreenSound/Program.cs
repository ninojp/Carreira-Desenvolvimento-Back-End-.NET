using ScreenSound;

void ExibirLogo()
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(" Curso Alura C#: aplicando a Orientação a Objetos ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(@"
                ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
                ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
                ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
                ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
                ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
                ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.ResetColor();
}
ExibirLogo();
//==============================
/*****************************************************************************
 * Aulas 1 e 2: Orientação a Objetos - conceitos básicos
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
//musica1.EscreveDisponivel(true);
musica1.Disponivel = true;
Console.WriteLine($"\n O nome do artista é {musica1.Artista} e sua musica: {musica1.Nome}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(musica1.LeDisponivel());
Console.WriteLine(musica1.Disponivel);
musica1.ExibirFichaTecnica();
//musica1.DescricaoResumida = "qualquer coisa";
Console.WriteLine(musica1.DescricaoResumida);
Console.ResetColor();

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
//musica2.EscreveDisponivel(false);
Console.WriteLine($"\n O nome do artista é {musica2.Artista} e sua musica: {musica2.Nome}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(musica2.LeDisponivel());
Console.WriteLine(musica2.Disponivel);
musica2.ExibirFichaTecnica();
Console.ResetColor();
*/
//===========================================================================================
//Aula 3 e 4: Orientação a Objetos - relacionamentos entre classes

//Instância os objetos, a partir das classes e atribui seus valores.
Genero generoRock = new("Rock");
Artista artistaQueen = new("Queen");
Musica musica1 = new("Love of My Life", artistaQueen, 217, true);
Musica musica2 = new("Bohemian Rhapsody", artistaQueen, 354, false);
Album albumQueen = new("A Night at the Opera", artistaQueen, generoRock);

//Popula os objetos com os relacionamentos entre eles, utilizando os métodos e propriedades criados nas classes.
artistaQueen.AdicionarAlbumAoArtista(albumQueen);
albumQueen.AdicionarMusicaAoAlbum(musica1);
albumQueen.AdicionarMusicaAoAlbum(musica2);

//Exibe as informações do álbum, incluindo o nome do álbum, o nome do artista, a lista de músicas e a duração total do álbum.
Console.ForegroundColor = ConsoleColor.DarkYellow;
artistaQueen.ExibirArtistaEAlbuns();
albumQueen.ExibirDetalhesDoAlbum();
Console.ResetColor();

//Aula 3 - Desafio:
//Crie uma classe chamada Genero, que armazena o nome do gênero musical,
//e crie um relacionamento desta nova classe em nossa aplicação.


/****************************************************************************************************/

//Instância a classe ExecutarExercicios e chama o método que executa os exercícios propostos.
ExecutarExercicios.ExecutarOsExercicios();
