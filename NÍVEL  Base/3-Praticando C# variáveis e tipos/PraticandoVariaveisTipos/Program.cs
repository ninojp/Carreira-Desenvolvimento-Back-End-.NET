Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\nCurso Alura C#: Praticando C# variáveis e tipos");
    Console.WriteLine(@"  
                                                            ░█████╗░░░░██╗░██╗░
                                                            ██╔══██╗██████████╗
                                                            ██║░░╚═╝╚═██╔═██╔═╝
                                                            ██║░░██╗██████████╗
                                                            ╚█████╔╝╚██╔═██╔══╝
                                                            ░╚════╝░░╚═╝░╚═╝░░░
");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 1: Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, calcule a idade com base no ano atual.");
Console.Write("\nDigite o seu ano de nascimento, com 4 dígitos: ");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
Console.ForegroundColor = ConsoleColor.Green;
int idade = anoAtual - anoNascimento;
Console.WriteLine($"Você tem {idade} anos.");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 2: Registro de doações");
//double é um tipo de dado que representa números com casas decimais, ou seja, números fracionários.
//Ele é usado para armazenar valores que podem ter uma parte decimal, como dinheiro, medidas,
//ou qualquer valor que não seja um número inteiro. O tipo double é capaz de representar uma ampla gama de valores,
//incluindo números muito grandes e muito pequenos, com precisão de até 15-16 dígitos decimais.
double valorRecebido = 500.00;
//float é um tipo de dado que representa números com casas decimais, mas com menor precisão do que o tipo double.
float valorDoacao = 250.00f;
//decimal é um tipo de dado que representa números com casas decimais, mas com maior precisão do que o tipo double,
//especialmente para valores monetários.
decimal valorRecebidoDecimal = 1000.00m;
//bool é um tipo de dado que representa um valor booleano, ou seja, verdadeiro (true) ou falso (false).
bool doacaoAnonima = true;
//char é um tipo de dado que representa um único caractere, como uma letra, número ou símbolo.
char tipoConta = 'P';
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nValor recebido: R${valorRecebido}");
Console.WriteLine($"Valor da doação: R${valorDoacao}");
Console.WriteLine($"Valor recebido (decimal): R${valorRecebidoDecimal}");
Console.WriteLine($"Doação anônima: {doacaoAnonima}");
Console.WriteLine($"Tipo de conta: {tipoConta}");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 3: Convertendo distâncias");
double distanciaMilhas = 10.0;
//1 milha = 1.60934 quilômetros.
double distanciaQuilometros = distanciaMilhas * 1.60934;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nA distancia de {distanciaMilhas} milhas é igual a {distanciaQuilometros} quilômetros.");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 4: Convertendo horas para minutos");
int totalMinutos = 250;
int horas = totalMinutos / 60;
//O operador de módulo (%) é usado para obter o restante da divisão inteira entre dois números.
int minutos = totalMinutos % 60;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n{totalMinutos} minutos é igual a {horas} horas e {minutos} minutos.");
Console.ResetColor();

// área = largura * comprimento 
Console.WriteLine("\nDESAFIO 5: Calculando a área de um retângulo");
double largura = 10.5;
double comprimento = 20.3;
double area = largura * comprimento;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nA área do retângulo é: {area} metros quadrados.");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 6: Calculando a média de notas");
float nota1 = 7.2f;
float nota2 = 8.3f;
float nota3 = 9.1f;
float media = (nota1 + nota2 + nota3) / 3;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nA média das notas é: {media:F2}");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 7: Convertendo tipos");
//Receber o peso total em toneladas (decimal)
decimal pesoContainer = 18.75m;
//Converter para inteiro descartando a parte decimal
int quantidadeVeiculos = (int)pesoContainer;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nA quantidade mínima de veículos (cada veículo 1 tonelada) necessários: {quantidadeVeiculos}");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 8: Controle de vidas em um jogo");
//Declarar uma variável com o número inicial de vidas.
int vidas = 5;
//Simular uma situação em que o jogador erra.
vidas--;
//Simular que o jogador acerta duas vezes.
vidas++;
vidas++;
//Armazene o valor final das vidas em uma nova variável.
int vidasFinais = vidas;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Vidas finais: " + vidasFinais);
Console.ResetColor();

Console.WriteLine("\nDESAFIO 9: Aumento de salário");
//Defina uma variável para o salário atual (decimal).
decimal salarioAtual = 3500.00m;
//Defina uma variável para o percentual de aumento (decimal).
decimal percentualAumento = 10.0m;
//Calcule o novo salário e o salve em uma nova variável (decimal). formula: salarioAtual + (salarioAtual * percentualAumento / 100)
decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100);
//Por fim, exiba o novo salário.
Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("O novo salário é de R$" + novoSalario.ToString("F2")); 
Console.WriteLine($"\nO novo salário após o aumento é: R${novoSalario:F2}");
Console.ResetColor();

Console.WriteLine("\nDESAFIO 10: Calculando a área e o perímetro");
//Declare uma variável que receba o valor de PI (considere PI como sendo igual a 3.14159).
double piValor = 3.14159;
//Em C#, podemos usar a palavra-chave 'const' para declarar uma constante, o que indica que o valor não pode ser alterado após a atribuição inicial. Então, podemos declarar PI como uma constante da seguinte forma:
const double PI = 3.14159;
//Em C#, a constante Math.PI já fornece o valor de PI com alta precisão, então podemos usar isso diretamente.
double pi = Math.PI;
//Declare uma variável que receba o valor do raio do círculo.
double raio = 5.0;
//Calcule e armazene em uma variável a área do círculo utilizando a fórmula: área = pi x raio x raio.
double areaCirculo = pi * raio * raio;
//Calcule e armazene em uma variável o perímetro do círculo utilizando a fórmula: 2 * pi * raio.
double perimetroCirculo = 2 * pi * raio;
//Exiba os resultados no console.
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nValor de Math.PI: {pi}");
Console.WriteLine($"Valor de PI: {PI:F2}");
Console.WriteLine($"Raio do círculo: {raio}");
Console.WriteLine($"A área do círculo é: {areaCirculo:F2}");
Console.WriteLine($"O perímetro do círculo é: {perimetroCirculo:F2}");
Console.ResetColor();
