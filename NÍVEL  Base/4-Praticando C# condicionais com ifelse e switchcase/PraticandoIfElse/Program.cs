void exibiTitulo()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n Desafios práticos.");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@"
                  _
                 | |
                 | |===( )   //////
                 |_|   |||  | o o|   Hit any key to continue...
                        ||| ( c  )                  ____
                         ||| \= /                  ||   \_
                          ||||||                   ||     |
                          ||||||                ...||__/|-´
                          ||||||             __|________|__
                            |||             |______________|
                            |||             || ||      || ||
                            |||             || ||      || ||
    ------------------------|||-------------||-||------||-||-------
                            |__>            || ||      || ||
    ");
}
string VerificaCondicaoSaldo()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n Desafio 1: Verificando o saldo da conta.");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nDigite o saldo (ex: 10.00): ");
    Console.ResetColor();
    string input = Console.ReadLine();
    decimal saldo;
    //Verifica se a entrada é um número decimal válido
    if (!decimal.TryParse(input, out saldo))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        return "\nValor inválido. Por favor, digite um número.";
        Console.ResetColor();
    }
    else
    {
        if (saldo > 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"\nO Saldo atual de {saldo}, é Positivo!";
            Console.ResetColor();
        }
        else if (saldo == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"\nO Saldo atual de {saldo}, é ZERO!";
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"\nO Saldo atual de {saldo}, é Negativo!";
            Console.ResetColor();
        }
    }
}
exibiTitulo();
string resultado = VerificaCondicaoSaldo();
Console.WriteLine($"\n{resultado}");
Console.ResetColor();

void ExibiMSG()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n Desafio 2: Classificação de produtos.");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nDigite o código do produto (1 ou 2): ");
    Console.ResetColor();
    string input = Console.ReadLine();
    if (input == "1")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\nProduto Perecivel, o código digitado foi {input}");
        Console.ResetColor();
    }
    else if (input == "2")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\nProduto Não Perecivel, o código digitado foi {input}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"\nCódigo inválido. Por favor, digite 1 ou 2.");
        Console.ResetColor();
    }
}
ExibiMSG();

//Classificando a nota de um aluno
//Informe a nota final do aluno: 8,5
