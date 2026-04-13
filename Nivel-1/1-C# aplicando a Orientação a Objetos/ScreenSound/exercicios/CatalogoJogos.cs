namespace ScreenSound.exercicios;

internal class CatalogoJogos
{
    private List<Jogo> Jogos { get; set; }

    // Propriedade que retorna se o catálogo está vazio
    public bool CatalogoVazio => Jogos.Count == 0;

    // Construtor para inicializar o catálogo de jogos vazio
    public CatalogoJogos()
    {
        Jogos = new List<Jogo>();
    }
    //menu de opções
    public void ExibirMenu()
    {
        int opcaoMenu;
        do
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("[1]. Adicionar Jogo");
            Console.WriteLine("[2]. Listar Jogos");
            Console.WriteLine("[3]. Sair\n");
            Console.Write("Escolha uma opção: ");
            if (!int.TryParse(Console.ReadLine(), out opcaoMenu))
            {
                Console.WriteLine("\nEntrada inválida! Digite um número válido!");
                continue;
            }

            if (opcaoMenu == 0 || opcaoMenu > 3 || opcaoMenu < 0)
            {
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                continue;
            }
            else
            {
                switch (opcaoMenu)
                {
                    case 1:
                        Console.Write("Digite o nome do jogo: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o gênero do jogo: ");
                        string genero = Console.ReadLine();
                        Console.Write("Digite o ano de lançamento do jogo: ");
                        int anoLancamento = int.Parse(Console.ReadLine());
                        AdicionarJogo(nome, genero, anoLancamento);
                        break;
                    case 2:
                        ListarJogos();
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        } while (opcaoMenu != 3);
    }

    // Método para adicionar um jogo ao catálogo
    public void AdicionarJogo(string nome, string genero, int anoLancamento)
    {
        Jogo novoJogo = new Jogo(nome, genero, anoLancamento);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }

    // Método para listar todos os jogos no catálogo
    public void ListarJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio.");
        }
        else
        {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano de Lançamento: {jogo.AnoLancamento}");
            }
        }
    }
}
