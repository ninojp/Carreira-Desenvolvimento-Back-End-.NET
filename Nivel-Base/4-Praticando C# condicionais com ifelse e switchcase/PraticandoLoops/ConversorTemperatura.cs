using Microsoft.VisualBasic;

namespace PraticandoLoops;
internal class ConversorTemperatura
{
    public void ConverterTemperatura()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n[1] Celsius para Fahrenheit");
            Console.WriteLine("[2] Fahrenheit para Celsius");
            Console.WriteLine("[3] Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: 
                    Console.WriteLine("\nDigite a temperatura em Celsius: ");
                    int tempCelsius = int.Parse(Console.ReadLine());
                    //Fórmula para conversão de Celsius para fahrenheit: (celsius * 9 / 5) + 32
                    int tempCelsiusParaFahrenheit = (tempCelsius * 9 / 5) + 32;
                    Console.WriteLine($"\nA temperatura {tempCelsius} convertida para Fahrenheit é: {tempCelsiusParaFahrenheit}");
                    break;
                case 2:
                    Console.WriteLine("\nDigite a temperatura em Fahrenheit: ");
                    int tempFahrenheit = int.Parse(Console.ReadLine());
                    //Fórmula para conversão de fahrenheit para Celsius: (fahrenheit - 32) * 5 / 9
                    int tempFahrenheitParaCelsius = (tempFahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"\nA temperatura {tempFahrenheit} convertida para Celsius é: {tempFahrenheitParaCelsius}");
                    break;
                case 3:
                    Console.WriteLine("\nDigite qualquer (menos, barraDeEspaço kkkk) tecla pra sair.");
                    Console.ReadLine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite uma opção válida!");
                    Console.ResetColor();
                    break;
            }
        } while (opcao != 3);
    }
}
