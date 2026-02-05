// Console App - Screen Sound
string nome = "NinoJP";
//string mensagem = "Boas-Vindas: " + nome + ", ao Screen Sound!";
string mensagem = $"Boas-Vindas: {nome}, Ao Screen Sound!";
//==============================================================
void ExibirMensagemNaTela()
{
    Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagem);
}
//==============================================================
void ExibirOpcoesMenu()
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média das notas de uma banda");
    Console.WriteLine("Digite -1 para sair");
    //O Write escreve na mesma linha
    Console.Write("\nEscolha uma opção: ");
    //O ReadLine lê a linha toda
    //O ! indica que nós (desenvolvedor), estamos certos que o valor não será nulo.
    String opcaoEscolhida = Console.ReadLine()!;
    //para exibir o tipo da variável
    //Console.WriteLine(opcaoEscolhida.GetType());
    int numeroEscolhido = int.Parse(opcaoEscolhida);
    //if (numeroEscolhido == 1)
    //{ Console.WriteLine($"Você escolheu a opção: {numeroEscolhido}");
    //}else if (numeroEscolhido == 2)
    //{ Console.WriteLine($"Você escolheu a opção: {numeroEscolhido}");
    //}else
    //{ Console.WriteLine("Opção inválida!");}
    switch (numeroEscolhido)
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção: {numeroEscolhido}");
            break;
        case 2:
            Console.WriteLine($"Você escolheu a opção: {numeroEscolhido}");
            break;
        case 3:
            Console.WriteLine($"Você escolheu a opção: {numeroEscolhido}");
            break;
        case 4:
            Console.WriteLine($"Você escolheu a opção: {numeroEscolhido}");
            break;
        case -1:
            Console.WriteLine($"Opção de saida!: {numeroEscolhido}");
            break;
        default:
            Console.WriteLine($"Opção inválida!: {numeroEscolhido}");
            break;
    }
}
//=====================
ExibirMensagemNaTela();
ExibirOpcoesMenu();