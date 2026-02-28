using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhesBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Para executar o método da classe ancestal, utilizamos a palavra reservada "base" seguida do nome do método que queremos executar.
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda bandaSelecionada = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nBanda: {bandaSelecionada.Nome}");
            Console.WriteLine($"A classe Banda foi Instânciada: {Banda.ContadorDeObjetos} vezes");
            Console.WriteLine($"Notas da Banda: {string.Join(", ", bandaSelecionada.ListaNotasBanda.Select(n => n.Nota))}");
            Console.WriteLine($"Média da Banda: {bandaSelecionada.MediaNotas}");
            foreach (var album in bandaSelecionada.ListaAlbunsDaBanda)
            {
                Console.WriteLine($"\nÁlbum: {album.Nome}");
                Console.WriteLine($"A classe Album foi Instânciada: {Album.ContadorDeObjetos} vezes");
                Console.WriteLine($"Notas do álbum: {string.Join(", ", album.ListaNotasAlbum.Select(n => n.Nota))}");
                Console.WriteLine($"Média do álbum: {album.MediaNotas}");
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
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
