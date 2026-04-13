using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }
        public void ExibirDadosFuncionario()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
        }
        public void Promover(string novoCargo)
        {
            if (novoCargo != Cargo)
            {
                Cargo = novoCargo;
                Console.WriteLine($"Funcionário {Nome} promovido para o cargo de {Cargo}.");
            }
            else
            {
                Console.WriteLine($"O funcionário {Nome} já ocupa o cargo de {Cargo}.");
            }
        }
    }
}
