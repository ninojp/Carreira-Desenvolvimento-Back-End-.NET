using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public ContaBancaria(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public void Depositar(decimal valorDeposita)
        {
            Saldo += valorDeposita;
        }

        public void ExibirDadosContaBancaria()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo: {Saldo:C}");
        }
    }
}
