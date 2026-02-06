using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ExerciciosPraticos
{
    internal class PraticandoAula3
    {
        public static void Main()
        {
            Console.WriteLine("\n");
            Console.WriteLine(@"Arquivo de exercícios práticos! Aula 3 
██████╗░██████╗░░█████╗░████████╗██╗░█████╗░░█████╗░███╗░░██╗██████╗░░█████╗░  ░█████╗░░░░██╗░██╗░
██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██║██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗  ██╔══██╗██████████╗
██████╔╝██████╔╝███████║░░░██║░░░██║██║░░╚═╝███████║██╔██╗██║██║░░██║██║░░██║  ██║░░╚═╝╚═██╔═██╔═╝
██╔═══╝░██╔══██╗██╔══██║░░░██║░░░██║██║░░██╗██╔══██║██║╚████║██║░░██║██║░░██║  ██║░░██╗██████████╗
██║░░░░░██║░░██║██║░░██║░░░██║░░░██║╚█████╔╝██║░░██║██║░╚███║██████╔╝╚█████╔╝  ╚█████╔╝╚██╔═██╔══╝
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░  ░╚════╝░░╚═╝░╚═╝░░░
             ");
            //=====================================================================================
            //1. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado
            //de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
            float valorA = 10.5f;
            float valorB = 5.2f;
            Console.WriteLine("\nPraticando2 - Exercício 1");
            Console.WriteLine($"\nResultados das operações com {valorA} e {valorB}:");
            Console.WriteLine($"Adição: {valorA + valorB}");
            Console.WriteLine($"Subtração: {valorA - valorB}");
            Console.WriteLine($"Multiplicação: {valorA * valorB}");
            Console.WriteLine($"Divisão: {valorA / valorB}");
            //2. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
            Console.WriteLine("\nPraticando2 - Exercício 2");
            List<string> bandasFamosas = new List<string>();
            bandasFamosas.Add("Ira!");
            bandasFamosas.Add("SlipkNot");
            bandasFamosas.Add("Linkin Park");
            bandasFamosas.Add("Tupac");
            bandasFamosas.Add("Racionais");

            //3.Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
            Console.WriteLine("\nPraticando2 - Exercício 3");
            Console.WriteLine("\n Usando o For, e exibindo o indice");
            for (Int16 i = 0; i < bandasFamosas.Count(); i++)
            {
                Console.WriteLine($"Banda {i} - {bandasFamosas[i]}");
            }
            Console.WriteLine("\nUsando o Foreach");
            foreach (string bandaFamosa in bandasFamosas)
            {
                Console.WriteLine($"Banda - {bandaFamosa}");
            }
            //4. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
            List<int> listaNumeros = new List<int>() { 1, 5, 10, 8, 4, 6, 7, 3, 9 };
            Console.WriteLine("\nPraticando2 - Exercício 4");
            void SomaTotal()
            {
                int valorSoma = 0;
                foreach (int num in listaNumeros)
                {
                    valorSoma += num;
                }
                Console.WriteLine($"\nA soma total dos números da lista é: {valorSoma}");
            }
            SomaTotal();

            //=======================================================================================
            //5. Criar um programa que calcula a média dos elementos de ponto flutuante em uma lista.
            List<double> numeros = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
            double soma = 0;
            foreach (double numero in numeros)
            {
                soma += numero;
            }
            double media = soma / numeros.Count;
            Console.WriteLine($"\nA média dos elementos da lista é: {media}");

            //6. Desenvolver um programa que exibe a tabuada de um número.
            int outroNumero = 5;
            Console.WriteLine($"\nTabuada do {outroNumero}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = outroNumero * i;
                Console.WriteLine($"{outroNumero} x {i} = {result}");
            }

            //7. Desenvolver uma calculadora simples que realiza as quatro operações básicas, a partir dado dois numeros e um operador.
            double numero1 = 5;
            double numero2 = 4;
            char operacao = '+';
            double resultado = 0;
            switch (operacao)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("\nOperação inválida.");
                    return;
            }
            Console.WriteLine($"\nResultado da operação: {resultado}");
            //=======================================================================================
            Console.WriteLine("\nDesafio da aula 3!");
            Console.WriteLine("\nUsando o For");
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                if (listaNumeros[i] % 2 == 0)
                {
                    Console.WriteLine($"Número {i}: {listaNumeros[i]}");
                }
            }
            Console.WriteLine("\nUsando o Foreach");
            foreach (int numero in listaNumeros)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"Número: {numero}");
                }
            }
        }
    }
}
