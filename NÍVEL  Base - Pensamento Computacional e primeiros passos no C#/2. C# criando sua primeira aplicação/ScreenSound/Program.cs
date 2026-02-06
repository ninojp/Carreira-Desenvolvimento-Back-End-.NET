// Console App - Screen Sound
string nome = "NinoJP";
//string mensagem = "Boas-Vindas: " + nome + ", ao Screen Sound!";
string mensagem = $"Boas-Vindas: {nome}, Ao Screen Sound!";
//==============================================================
void ExibirLogo()
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
List<string> listaDasBandas = new List<string>() { "Linkin Park", "U2", "Coldplay", "Iron Maiden" };

//==============================================================
void ExibirOpcoesMenu()
{
    ExibirLogo();
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
    switch (numeroEscolhido)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
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
//===================================================================
ExibirOpcoesMenu();
//===================================================================
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("******************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("******************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeBanda);
    Console.WriteLine($"A Banda: {nomeBanda}, foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirOpcoesMenu();
}
//===================================================================
void ExibirBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("Lista das Bandas Registradas");
    Console.WriteLine("****************************\n");
    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda - {banda}");
    }
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda - {listaDasBandas[i]}");
    //}
    Console.Write("\nDigite qualquer tecla para voltar ao Menu Principal! ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}