using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PraticandoIfElse
{
    internal class AulaPratica2
    {
        public AulaPratica2()
        {
        }
        // Calculadora de operações básicas - Aula 2 Desafio 1
        public void Calculadora()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 2, Desafio 1: Calculadora de operações básicas.");
            Console.Write("\nDigite um numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite o Segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a operação (+, -, *, /): ");
            string operacao = Console.ReadLine();
            Console.ResetColor();
            //switch (operacao) {
            //    case "+":
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\nResultado: {num1 + num2}");
            //        break;
            //    case "-":
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\nResultado: {num1 - num2}");
            //        break;
            //    case "*":
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\nResultado: {num1 * num2}");
            //        break;
            //    case "/":
            //        if (num2 != 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine($"\nResultado: {num1 / num2}");
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("\nErro: Divisão por zero não é permitida.");
            //        }
            //        break;
            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\nOperação inválida.");
            //        break;
            //}
            //--------------------------------------------------------------------------------
            //Switch-Case simplificado usando a expressão switch, que é uma
            //forma mais concisa de escrever um switch case tradicional.
            double resultado = operacao switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" when num2 != 0 => num1 / num2,
                "/" => throw new DivideByZeroException("Erro: Divisão por zero não é permitida."),
                _ => throw new InvalidOperationException("Operação inválida.")
            };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nResultado: {resultado}"); Console.ForegroundColor = ConsoleColor.Green;

            Console.ResetColor();
        }
        //Saudação personalizada - Desafio 2
        public void SaudacaoPersonalizada()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 2, Desafio 2: Saudação personalizada.\n");
            Console.WriteLine(@"1 - Manhã
2 - Tarde
3 - Noite
Digite dos números e escolha qual é o seu momento do dia:");
            int periodoDia = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o nome do usuário: ");
            string nomeUser = Console.ReadLine();
            Console.ResetColor();
            //switch(periodoDia)
            //{
            //    case 1:
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\nBom dia, {nomeUser}!");
            //        break;
            //    case 2:
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\nBoa tarde, {nomeUser}!");
            //        break;
            //    case 3:
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"\nBoa noite, {nomeUser}!");
            //        break;
            //    default:
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\nOpção inválida. Por favor, escolha 1, 2 ou 3.");
            //        break;
            //}
            //Console.ResetColor();
            //--------------------------------------------------------------------------------
            //Switch-Case simplificado usando a expressão switch,
            string msgSaudacao = periodoDia switch
            {
                1 => $"Bom dia, {nomeUser}!",
                2 => $"Boa tarde, {nomeUser}!",
                3 => $"Boa noite, {nomeUser}!",
                _ => "Opção inválida. Por favor, escolha 1, 2 ou 3."
            };
            Console.WriteLine(msgSaudacao);
        }
        //Sistema de recompensas - Desafio 3
        public void SistemaRecompensas()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 2, Desafio 3: Sistema de recompensas.\n");
            Console.WriteLine("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):");
            Console.ResetColor();
            string codigo = Console.ReadLine();
            string mensagem = codigo switch
            {
                "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
                "CURAR" => "Poção de cura adquirida!",
                "OURO" => "+1000 moedas de ouro!",
                "ESPECIAL" => "Item lendário desbloqueado!",
                _ => "Recompensa indisponível."
            };
            Console.WriteLine(mensagem);
        }
        //Refatorando a organização de livros - Desafio 4
        public void OrganizaLivros()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 2, Desafio 4: Organização de livros.\n");
            Console.WriteLine("Digite o código do livro: ");
            Console.ResetColor();
            int codigo = int.Parse(Console.ReadLine());
            // CÓDIOGO A SER REFATORADO
            //if (codigo >= 100 && codigo <= 199)
            //{
            //    Console.WriteLine("Ficção Científica");
            //}
            //else if (codigo >= 200 && codigo <= 299)
            //{
            //    Console.WriteLine("Literatura Clássica");
            //}
            //else if (codigo >= 300 && codigo <= 399)
            //{
            //    Console.WriteLine("Fantasia");
            //}
            //else if (codigo >= 400 && codigo <= 499)
            //{
            //    Console.WriteLine("Romance");
            //}
            //else if (codigo >= 500 && codigo <= 599)
            //{
            //    Console.WriteLine("Suspense/Mistério");
            //}
            //else if (codigo >= 600 && codigo <= 699)
            //{
            //    Console.WriteLine("Não Ficção");
            //}
            //else if (codigo >= 700 && codigo <= 799)
            //{
            //    Console.WriteLine("Biografias/Memórias");
            //}
            //else if (codigo >= 800 && codigo <= 899)
            //{
            //    Console.WriteLine("Distopia");
            //}
            //else if (codigo >= 900 && codigo <= 999)
            //{
            //    Console.WriteLine("Infantojuvenil");
            //}
            //else
            //{
            //    Console.WriteLine("Código inexistente");
            //}
            //O Switch Pattern Matching, não usa uma expressão booleana normal.
            //No contexto de patterns (padrões), o C# usa palavras-chave especiais:
            //•	and - combina padrões(similar ao &&)
            //•	or - alternativa de padrões(similar ao ||)
            //•	not - negação de padrão(similar ao !)
            string categoria = codigo switch
            {
                >= 100 and <= 199 => "Ficção Científica",
                >= 200 and <= 299 => "Literatura Clássica",
                >= 300 and <= 399 => "Fantasia",
                >= 400 and <= 499 => "Romance",
                >= 500 and <= 599 => "Suspense/Mistério",
                >= 600 and <= 699 => "Não Ficção",
                >= 700 and <= 799 => "Biografias/Memórias",
                >= 800 and <= 899 => "Distopia",
                >= 900 and <= 999 => "Infantojuvenil",
                _ => "Código inexistente"
            };
        }
        //Autenticação de usuário - Aula 2 Desafio 5
        public void AutentificaUsuario()
        {
            string ADMIN_USER = "Admin";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 2, Desafio 5: Autenticação de usuário.\n");
            Console.WriteLine("Sistema de Autenticação");
            Console.WriteLine("-----------------------");
            Console.Write("Digite seu nome de usuário: ");
            Console.ResetColor();
            string username = Console.ReadLine();
            if (username == ADMIN_USER)
            {
                Console.WriteLine($"Bem-vindo, {username}!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Usuário não cadastrado.");
                Console.WriteLine("Opções disponíveis:");
                Console.WriteLine("[1] Cadastrar novo usuário");
                Console.WriteLine("[2] Acessar como convidado");
                Console.WriteLine("[3] Sair");
                Console.ResetColor ();
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Novo usuário '{username}' cadastrado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Acesso concedido como convidado.");
                        break;

                    case 3:
                        Console.WriteLine("Saindo do sistema...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. O sistema será encerrado.");
                        break;
                }
            }
        }

    }
}
