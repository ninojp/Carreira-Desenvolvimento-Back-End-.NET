
namespace ScreenSound.exercicios;
internal class ControleDeEstoque
{
    //
    List<string> ListaProdutosEstoque = new() { "Mouse", "Teclado", "Monitor" };

    public void exibirMenu()
    {
        int opcaoMenu;
        do
        {
            Console.WriteLine("\nDigite o numero de uma opção");
            Console.WriteLine("[1] Listar Produtos do estoque.");
            Console.WriteLine("[2] Adicionar Produto no estoque.");
            Console.WriteLine("[3] Sair.\n");

            if (!int.TryParse(Console.ReadLine(), out opcaoMenu))
            {
                Console.WriteLine("\nEntrada inválida! Digite um número válido!");
                continue;
            }

            if (opcaoMenu == 0 || opcaoMenu > 3 || opcaoMenu < 0)
            {
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                continue;
            } else
            {
                switch (opcaoMenu)
                {
                    case 1:
                        ListarProdutos();
                        break;
                    case 2:
                        Produto produto = new Produto();
                        AdicionarProduto(produto);
                        break;
                    case 3:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }
            }
        } while (opcaoMenu != 3 );

    }
    public void ListarProdutos()
    {
        Console.WriteLine("\nProdutos no estoque:");
        for (int i = 0; i < ListaProdutosEstoque.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {ListaProdutosEstoque[i]}");
        }
    }
    public void AdicionarProduto(Produto produto)
    {
        Console.WriteLine("\nDigite o nome do Produto, para adicionar ao estoque: ");
        string NovoProduto = Console.ReadLine();
        produto.NomePropriedade = NovoProduto;
        ListaProdutosEstoque.Add(produto.NomePropriedade);
        Console.WriteLine($"\nProduto {produto.NomePropriedade} adicionado ao estoque.");
    }

}
