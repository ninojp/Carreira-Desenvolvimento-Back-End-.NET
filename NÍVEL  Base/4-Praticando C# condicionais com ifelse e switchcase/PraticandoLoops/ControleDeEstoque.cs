using Microsoft.Win32;
using System.Diagnostics;

namespace PraticandoLoops;
internal class ControleDeEstoque
{
    public void GerenciarEstoque()
    {
        //- Pergunte ao usuário se ele deseja registrar uma nova entrada.
        //- Se sim, solicitar a quantidade e atualizar o estoque.
        //- Repetir o processo até que o usuário decida encerrar.
        int estoque = 0;
        Console.WriteLine("Deseja adicionar um produto ao estoque?");
        Console.WriteLine("1 - Sim | 0 - Não");
        int resposta = int.Parse(Console.ReadLine());
        while (resposta == 1)
        {
            Console.WriteLine("Quantidade:");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            estoque += quantidade;
            Console.WriteLine($"Estoque atual: {estoque}");
            Console.WriteLine("Deseja continuar?");
            Console.WriteLine("1 - Sim | 0 - Não");
            resposta = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Obrigado por usar nosso sistema de estoque!");
    }
}
