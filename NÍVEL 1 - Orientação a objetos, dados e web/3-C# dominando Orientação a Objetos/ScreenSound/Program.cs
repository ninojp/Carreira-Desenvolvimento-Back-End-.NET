using ScreenSound.Menus;
using ScreenSound.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        //Sem o uso do namespace, seria necessário usar o nome completo da classe:
        //ScreenSound.Models.Banda SlipknotBand = new ScreenSound.Models.Banda("Slipknot");
        Banda IraBand = new("Ira");
        IraBand.AdicionarNota(new Avaliacao(5));
        IraBand.AdicionarNota(new Avaliacao(4));
        IraBand.AdicionarNota(new Avaliacao(6));
        IraBand.AdicionarAlbum(new Album("ABC"));
        Album ABC = IraBand.ListaAlbunsDaBanda[0];
        ABC.AdicionarNota(new Avaliacao(2));
        ABC.AdicionarNota(new Avaliacao(4));
        IraBand.AdicionarAlbum(new Album("Vivendo e Aprendendo"));
        Album vivendoAprendendo = IraBand.ListaAlbunsDaBanda[1];
        vivendoAprendendo.AdicionarNota(new Avaliacao(5));
        vivendoAprendendo.AdicionarNota(new Avaliacao(6));
        vivendoAprendendo.AdicionarNota(new Avaliacao(7));

        Banda SlipknotBand = new("Slipknot");
        SlipknotBand.AdicionarNota(new Avaliacao(9));
        SlipknotBand.AdicionarNota(new Avaliacao(9));
        SlipknotBand.AdicionarNota(new Avaliacao(8));
        SlipknotBand.AdicionarAlbum(new Album("Iowa"));
        Album Iowa = SlipknotBand.ListaAlbunsDaBanda[0];
        Iowa.AdicionarNota(new Avaliacao(10));
        Iowa.AdicionarNota(new Avaliacao(10));
        Musica Psychosocial = new(SlipknotBand, "Psychosocial", 4, true);

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

        bandasRegistradas.Add(IraBand.Nome, IraBand);
        bandasRegistradas.Add(SlipknotBand.Nome, SlipknotBand);
        bandasRegistradas.Add(LinkinParkBand.Nome, LinkinParkBand);
        bandasRegistradas.Add(TheBeatlesBand.Nome, TheBeatlesBand);

        //Após a troca de List para IEnumerable na classe Banda, não é mais possível usar os métodos de modificação da coleção, como Clear, Add, Remove,
        //etc. Isso é intencional, pois IEnumerable é uma interface de leitura que não permite modificações diretas na coleção.
        //TheBeatlesBand.ListaAlbunsDaBanda.Clear();

        //Cria um dicionario para o menu
        Dictionary<int, Menu> opcoesMenu = new();
        opcoesMenu.Add(1, new MenuRegistrarBanda());
        opcoesMenu.Add(2, new MenuRegistrarAlbum());
        opcoesMenu.Add(3, new MenuExibirBandasRegistradas());
        opcoesMenu.Add(4, new MenuAvaliarBanda());
        opcoesMenu.Add(5, new MenuAvaliarAlbum());
        opcoesMenu.Add(6, new MenuExibirDetalhesBanda());
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
            Console.WriteLine("Digite 4 para avaliar uma Banda");
            Console.WriteLine("Digite 5 para avaliar um Album");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");
            //exibir quantas vezes a classe Album foi instânciada.
            Console.WriteLine($"\nA classe Banda foi Instânciada: {Banda.ContadorDeObjetos} vezes");
            Console.WriteLine($"A classe Album foi Instânciada: {Album.ContadorDeObjetos} vezes");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoesMenu.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuEscolhido = opcoesMenu[opcaoEscolhidaNumerica];
                menuEscolhido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0 && opcaoEscolhidaNumerica <= 6) ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida, Digite um numero entre 1 e 6 ou -1 para sair");
            }
        }
        ExibirOpcoesDoMenu();
    }
}