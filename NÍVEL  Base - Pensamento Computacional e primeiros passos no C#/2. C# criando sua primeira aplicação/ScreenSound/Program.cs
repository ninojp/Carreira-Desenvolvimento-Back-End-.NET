// Console App - Screen Sound
void ExibirLogo()
{
    Console.Clear();
    string nome = "NinoJP";
    string mensagem = $"Boas-Vindas: {nome}, Ao Screen Sound!";
    Console.WriteLine(mensagem);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@"
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.ResetColor();
}
//=======================================================================================================
//List<string> listaDasBandas = new List<string>() { "Linkin Park", "U2", "Coldplay", "Iron Maiden" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>() { 10, 9, 8 });
bandasRegistradas.Add("Raimundos", new List<int>());
bandasRegistradas.Add("Tupac", new List<int>() { 10, 9 });
//==============================================================
void ExibirOpcoesMenu()
{
    ExibirLogo();
    ExibirTituloOpcao("Menu:");
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
            AvaliarUmaBanda();
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
    ExibirLogo();
    ExibirTituloOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A Banda: {nomeBanda}, foi registrada com sucesso!");
    Thread.Sleep(3000);
    ExibirOpcoesMenu();
}
//===================================================================
void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloOpcao("Bandas Registradas");
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda - {banda}");
    }
    Console.Write("\nDigite qualquer tecla para voltar ao Menu Principal! ");
    Console.ReadKey();
    ExibirOpcoesMenu();
}
//===================================================================
void ExibirTituloOpcao(string titulo)
{
    Console.WriteLine("\n");
    int quantidadeDeLetras = titulo.Length;
    //string asteriscos = new string('*', quantidadeDeLetras);
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
//===================================================================
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloOpcao("Avaliar uma Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Digite a nota da banda (0 a 10): ");
        string notaStr = Console.ReadLine()!;
        int nota = int.Parse(notaStr);
        if (nota >= 0 && nota <= 10)
        {
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpcoesMenu();
        }
        else
        {
            Console.WriteLine($"\nNota {nota}, inválida! Digite uma nota de 0 a 10.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpcoesMenu();
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não está registrada.");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }
}