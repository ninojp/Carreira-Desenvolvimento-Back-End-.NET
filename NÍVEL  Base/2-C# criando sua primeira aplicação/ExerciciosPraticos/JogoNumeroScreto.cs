//Jogo do numero secreto!
using System;
public class JogoDoNumeroSecreto
{
    public static void Jogar()
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101);
        Console.Clear();
        Console.WriteLine("\n");
        Console.WriteLine(@"Arquivo de exercícios práticos! Aula 2

██████╗░██████╗░░█████╗░████████╗██╗░█████╗░░█████╗░███╗░░██╗██████╗░░█████╗░  ░█████╗░░░░██╗░██╗░
██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██║██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗  ██╔══██╗██████████╗
██████╔╝██████╔╝███████║░░░██║░░░██║██║░░╚═╝███████║██╔██╗██║██║░░██║██║░░██║  ██║░░╚═╝╚═██╔═██╔═╝
██╔═══╝░██╔══██╗██╔══██║░░░██║░░░██║██║░░██╗██╔══██║██║╚████║██║░░██║██║░░██║  ██║░░██╗██████████╗
██║░░░░░██║░░██║██║░░██║░░░██║░░░██║╚█████╔╝██║░░██║██║░╚███║██████╔╝╚█████╔╝  ╚█████╔╝╚██╔═██╔══╝
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░  ░╚════╝░░╚═╝░╚═╝░░░
             ");

        Console.WriteLine("\n Exercício 5: Bem-vindo ao Jogo do Número Secreto!");
        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");
        do
        {
            Console.Write("\nDigite um número entre 1 e 100: ");
            int chute = int.Parse(Console.ReadLine());

            if (chute == numeroSecreto)
            {
                Console.WriteLine("\nParabéns! Você acertou o número.");
                break;
            }
            else if (chute < numeroSecreto)
            {
                Console.WriteLine("\nO número é maior.");
            }
            else
            {
                Console.WriteLine("\n O número é menor.");
            }

        } while (true);

        Console.WriteLine("\n O jogo acabou. Você acertou o número secreto!");
    }
}