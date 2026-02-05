using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPraticos
{
    internal class Praticando
    {
        public static void Main()
        {
            Console.WriteLine("\n");
            Console.WriteLine(@"Arquivo de exercícios práticos!

██████╗░██████╗░░█████╗░████████╗██╗░█████╗░░█████╗░███╗░░██╗██████╗░░█████╗░  ░█████╗░░░░██╗░██╗░
██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██║██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗  ██╔══██╗██████████╗
██████╔╝██████╔╝███████║░░░██║░░░██║██║░░╚═╝███████║██╔██╗██║██║░░██║██║░░██║  ██║░░╚═╝╚═██╔═██╔═╝
██╔═══╝░██╔══██╗██╔══██║░░░██║░░░██║██║░░██╗██╔══██║██║╚████║██║░░██║██║░░██║  ██║░░██╗██████████╗
██║░░░░░██║░░██║██║░░██║░░░██║░░░██║╚█████╔╝██║░░██║██║░╚███║██████╔╝╚█████╔╝  ╚█████╔╝╚██╔═██╔══╝
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░  ░╚════╝░░╚═╝░╚═╝░░░
             ");
            //1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
            int notaMedia = 5;
            if (notaMedia >= 5)
            {
                Console.WriteLine("\n Exercício 1: Nota suficiente para aprovação");
            }
            else
            {
                Console.WriteLine("\n Exercício 1: Nota insuficiente!");
            }
            //2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
            List<String> listaDeLinguagens = new List<string> { "C#", "Java", "JavaScript" };
            // percorer o array
            Console.WriteLine("\n Exercício 2: Exibindo itens do array: ");
            listaDeLinguagens.ForEach((item) =>
            {
                Console.WriteLine($"Item: {item}");

            });
            //3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
            Console.WriteLine($"\n Exercício 3:{listaDeLinguagens[0]}");
            //Console.WriteLine($"\n Exercício 3:{listaDeLinguagens[2]}");
            //4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
            Console.Write("\nExercício 4: Digite a posição desejada na lista: ");
            int posicao = int.Parse(Console.ReadLine());
            Console.WriteLine(listaDeLinguagens[posicao]);
        }
    }
}
