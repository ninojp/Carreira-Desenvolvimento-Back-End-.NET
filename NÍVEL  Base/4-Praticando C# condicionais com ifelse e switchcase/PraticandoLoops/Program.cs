using PraticandoLoops;
void exibiTitulo()
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("\n Curso Alura Praticando C# laços de repetição");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(@"
                                                           /\
                                                          /  \
                                                         /    \      Pressione uma tecla, que continua...
                                                        /      \
                                                        |      |===( )   //////
                                                        |      |    ||  | o o|  
                                                        |      |     || ( c  )            ____
                                                        |______|      || \= /            ||   \_
                                                                      ||||||             ||     |
                                                                      ||||||          ...||__/|-´
                                                                      ||||||       __|________|__
                                                                        |||       |______________|
                                                                        |||       || ||      || ||
                                                                        |||       || ||      || ||
            ------------------------------------------------------------|||-------||-||------||-||-------
                                                                        |__>      || ||      || ||");
    Console.ResetColor();
}
exibiTitulo();
//==============================================================================
/*
 * 
WhileLacoRepeticao whileLacoRepeticao = new WhileLacoRepeticao();
//==============================================================================

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Vídeo 1 - Laço de repetição (Loop) While");
Console.ResetColor();
whileLacoRepeticao.WhileLoop();
//==============================================================================

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Vídeo 2 - Laço de repetição (Loop) Do While");
Console.ResetColor();
whileLacoRepeticao.DoWhileComSwitchExpression();
//==============================================================================

// Importando, using PraticandoLoops, o namespace também usado na classe SomaDasVendas.
SomaDasVendas somaDasVendas = new SomaDasVendas();
//==============================================================================

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Desafio 1 - Soma das Vendas");
Console.ResetColor();
somaDasVendas.CalculaSomaDasVendas();
//==============================================================================

ControleDeEstoque controleDeEstoque = new ControleDeEstoque();
//==============================================================================

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Desafio 2 - Controle de Estoque");
Console.ResetColor();
controleDeEstoque.GerenciarEstoque();
//==============================================================================
*/

NumeroSecreto numeroSecreto = new NumeroSecreto();
//==============================================================================

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Desafio 3 - Número Secreto");
Console.ResetColor();
numeroSecreto.AdivinharNumeroSecreto();
//==============================================================================