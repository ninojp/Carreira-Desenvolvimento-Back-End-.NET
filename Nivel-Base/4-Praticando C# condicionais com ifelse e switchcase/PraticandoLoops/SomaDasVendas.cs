using System.ComponentModel;
using System.Drawing;

namespace PraticandoLoops;
internal class SomaDasVendas
{
    public void CalculaSomaDasVendas()
    {
        double valorVenda, somaVendas = 0;
        do
        {
            Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
            valorVenda = double.Parse(Console.ReadLine());
            somaVendas += valorVenda;
        } while (valorVenda != 0);
        Console.WriteLine($"A soma das vendas é: {somaVendas}");
        Console.WriteLine("Fim do programa.");
    }
}
