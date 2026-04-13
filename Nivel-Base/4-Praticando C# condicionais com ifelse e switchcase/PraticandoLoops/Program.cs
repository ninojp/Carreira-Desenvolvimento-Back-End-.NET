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

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Desafio 1 - Soma das Vendas");
Console.ResetColor();
somaDasVendas.CalculaSomaDasVendas();
//==============================================================================

ControleDeEstoque controleDeEstoque = new ControleDeEstoque();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Desafio 2 - Controle de Estoque");
Console.ResetColor();
controleDeEstoque.GerenciarEstoque();
//==============================================================================
*/

//NumeroSecreto numeroSecreto = new NumeroSecreto();

//Console.ForegroundColor = ConsoleColor.DarkBlue;
//Console.WriteLine("\n Desafio 3 - Número Secreto");
//Console.ResetColor();
//numeroSecreto.AdivinharNumeroSecreto();
//==============================================================================

//Buscando em uma lista - Desafio 4
//BuscandoNome buscandoNome = new BuscandoNome();
//Console.ForegroundColor = ConsoleColor.DarkBlue;
//Console.WriteLine("\n Desafio 4 - Buscando um nome");
//Console.ResetColor();
//buscandoNome.BuscarUmNome();
//==============================================================================

//Senhas de atendimento - Desafio 5
//SenhasAtendimento senhasAtendimento = new SenhasAtendimento();
//Console.ForegroundColor = ConsoleColor.DarkBlue;
//Console.WriteLine("\n Desafio 5 - Senhas de Atendimento");
//Console.ResetColor();
//senhasAtendimento.ControleSenhas();
//===============================================================================

//Conversor de temperatura - Desafio 6
//ConversorTemperatura conversorTemperatura = new ConversorTemperatura();
//Console.ForegroundColor = ConsoleColor.DarkBlue;
//Console.WriteLine("\n Desafio 6 - Conversor de temperatura");
//Console.ResetColor();
//conversorTemperatura.ConverterTemperatura();
//================================================================================

// Aula 2 - Laço for - Vídeo 1
ForLacoRepeticao forLacoRepeticao = new ForLacoRepeticao();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\n Aula 2 - Laço for - Vídeo 1");
Console.ResetColor();
forLacoRepeticao.ForLoop();
//=================================================================================

//Aula 2 - Manipulando laços: break e continue - Vídeo 2
BreakContinue breakContinue = new BreakContinue();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 -  Manipulando laços: break e continue - Vídeo 2 ");
Console.ResetColor();
breakContinue.ControlandoLoops();
breakContinue.Exemplo();
//==================================================================================

//Aula 2 - Foreach - Vídeo 3
ForEach forEach = new ForEach();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 - Foreach - Vídeo 3");
Console.ResetColor();
forEach.ParaCada();
//===================================================================================

//Aula 2 - Pulando números - Desafio 1
PulandoNumeros pulandoNumeros = new PulandoNumeros();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 - Pulando números - Desafio 1");
Console.ResetColor();
pulandoNumeros.NumeroPular();
//====================================================================================

//Aula 2 - Tabela de multiplicação - Desafio 2
Tabuada tabuada = new Tabuada();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 - Tabela de multiplicação - Desafio 2");
Console.ResetColor();
tabuada.ATabuada();
//====================================================================================

//Aula 2 - Classificação de números - Desafio 3
ClassificaNumeros classificaNumeros = new ClassificaNumeros();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 - Classificação de números - Desafio 3");
Console.ResetColor();
classificaNumeros.ClassificarNumeros();
//=====================================================================================

//Aula 2 - O laço certo para o problema - Desafio 4
LacoCerto lacoCerto = new LacoCerto();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 - O laço certo para o problema - Desafio 4");
Console.ResetColor();
lacoCerto.LacoCertoParaOProblema();

//======================================================================================

//Aula 2 - Quantos ímpares foram digitados? - Desafio 5
QuantosImpares quantosImpares = new QuantosImpares();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("\nAula 2 - Quantos ímpares foram digitados? - Desafio 5");
Console.ResetColor();
quantosImpares.QuantosImparesTem();