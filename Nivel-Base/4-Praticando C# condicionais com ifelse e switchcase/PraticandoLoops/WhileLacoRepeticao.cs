class WhileLacoRepeticao
{
    public void WhileLoop()
    {
        int contador = 5;
        while (contador > 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Contador: {contador}");
            contador--;
            Console.ResetColor();
        }
        Console.WriteLine("\n Fim do laço de repetição While.");
    }
    /* 
     * O laço de repetição Do-While é semelhante ao While, mas a diferença é que o bloco de código 
     * dentro do Do-While é executado pelo menos uma vez, mesmo que a condição seja falsa.
    public void DoWhileLoop()
    {   
        int opcao;
        do
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1 - Ver produtos");
            Console.WriteLine("2 - Fazer pedido");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Mostrando produtos.");
                    break;
                case 2:
                    Console.WriteLine("Pedido realizado!");
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while ( opcao > 0);
    }
    */
    public void DoWhileComSwitchExpression()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("[1] Ver produtos");
            Console.WriteLine("[2] Fazer pedido");
            Console.WriteLine("[0] Sair");
            Console.Write("Digite um numero (0, 1, 2) para acessar as opções: ");
            opcao = int.Parse(Console.ReadLine());
            //A expressão switch funciona perfeitamente dentro de qualquer
            //Estrutura de repetição (while, do-while, for, foreach).
            string mensagem = opcao switch
            {
                1 => "Mostrando produtos.",
                2 => "Pedido realizado!",
                0 => "Saindo...",
                _ => "Opção inválida!"
            };
            Console.WriteLine(mensagem);
        } while (opcao > 0 && opcao < 3);
    }
}
