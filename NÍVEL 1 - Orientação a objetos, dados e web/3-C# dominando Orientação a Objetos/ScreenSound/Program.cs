using ScreenSound.Menus;
using ScreenSound.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        //Sem o uso do namespace, seria necessário usar o nome completo da classe:
        //ScreenSound.Models.Banda SlipknotBand = new ScreenSound.Models.Banda("Slipknot");
        Banda SlipknotBand = new("Slipknot");
        SlipknotBand.AdicionarAlbum(new Album("Iowa"));
        SlipknotBand.AdicionarNota(new Avaliacao(10));
        SlipknotBand.AdicionarNota(new Avaliacao(9));
        SlipknotBand.AdicionarNota(new Avaliacao(8));

        Banda LinkinParkBand = new("Linkin Park");
        LinkinParkBand.AdicionarAlbum(new Album("Meteora"));
        LinkinParkBand.AdicionarNota(new Avaliacao(10));
        LinkinParkBand.AdicionarNota(new Avaliacao(9));

        Banda TheBeatlesBand = new("The Beatles");
        TheBeatlesBand.AdicionarAlbum(new Album("Abbey Road"));
        TheBeatlesBand.AdicionarNota(new Avaliacao(10));
        TheBeatlesBand.AdicionarNota(new Avaliacao(8));
        TheBeatlesBand.AdicionarNota(new Avaliacao(7));
        TheBeatlesBand.AdicionarNota(new Avaliacao(5));

        Dictionary<string, Banda> bandasRegistradas = new();

        bandasRegistradas.Add(SlipknotBand.Nome, SlipknotBand);
        bandasRegistradas.Add(LinkinParkBand.Nome, LinkinParkBand);
        bandasRegistradas.Add(TheBeatlesBand.Nome, TheBeatlesBand);

        //Cria um dicionario para o menu
        Dictionary<int, Menu> opcoesMenu = new();
        opcoesMenu.Add(1, new MenuRegistrarBanda());
        opcoesMenu.Add(2, new MenuRegistrarAlbum());
        opcoesMenu.Add(3, new MenuExibirBandasRegistradas());
        opcoesMenu.Add(4, new MenuAvaliarBanda());
        opcoesMenu.Add(5, new MenuExibirDetalhes());
        opcoesMenu.Add(-1, new MenuSair());

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");
            //exibir quantas vezes a classe Album foi instânciada.
            Console.WriteLine($"\nForam criados {Album.ContadorDeObjetos} Objetos a partir da classe Album.");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoesMenu.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuEscolhido = opcoesMenu[opcaoEscolhidaNumerica];
                menuEscolhido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0 && opcaoEscolhidaNumerica <= 5) ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida, Digite um numero entre 1 e 5 ou -1 para sair");
            }
        }
        ExibirOpcoesDoMenu();
    }
}