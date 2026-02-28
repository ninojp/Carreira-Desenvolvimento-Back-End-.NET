using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda bandaEscolhida = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o Nome do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (bandaEscolhida.ListaAlbunsDaBanda.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album albumEscolhido = bandaEscolhida.ListaAlbunsDaBanda.First(album => album.Nome.Equals(tituloAlbum, StringComparison.OrdinalIgnoreCase))!;
                Console.Write($"Digite a nota para o álbum {tituloAlbum}, (de 0 a 10): ");
                Avaliacao nota = Avaliacao.Parsear(Console.ReadLine()!);
                albumEscolhido.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                //Thread.Sleep(2000);
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado para a banda {nomeDaBanda}!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
