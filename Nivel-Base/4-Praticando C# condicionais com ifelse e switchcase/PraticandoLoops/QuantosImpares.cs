namespace PraticandoLoops;
internal class QuantosImpares
{
    public void QuantosImparesTem()
    {
        int qtdImpares = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 != 0)
            {
                qtdImpares++;
            }
        }
        Console.WriteLine($"Você digitou {qtdImpares} números ímpares.");
    }
}
