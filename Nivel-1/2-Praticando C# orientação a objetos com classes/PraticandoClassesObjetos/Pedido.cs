using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class Pedido
    {
        public string NumeroPedido { get; set; }
        public string NomeCliente { get; set; }
        public string Status { get; set; }

        public Pedido(string numeroPedido, string nomeCliente, string status)
        {
            NumeroPedido = numeroPedido;
            NomeCliente = nomeCliente;
            Status = status;
        }
        public void AtualizarStatus(string novoStatus)
        {
            Status = novoStatus;
            Console.WriteLine($"\nO status do pedido {NumeroPedido} foi atualizado para: {Status}");
        }
        public void ExibirDetalhesPedido()
        {
            Console.WriteLine($"Número do Pedido: {NumeroPedido}");
            Console.WriteLine($"Nome do Cliente: {NomeCliente}");
            Console.WriteLine($"Status do Pedido: {Status}");
        }
    }
}
