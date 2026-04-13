using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoIfElse
{
    internal class AulaPratica1
    {
        // Construtor padrão sem parâmetros
        public AulaPratica1()
        {
        }
        public string VerificaCondicaoSaldo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 1, Desafio 1: Verificando o saldo da conta.");
            Console.Write("\nDigite o saldo (ex: 10.00): ");
            Console.ResetColor();
            string input = Console.ReadLine();
            decimal saldo;
            //Verifica se a entrada é um número decimal válido
            if (!decimal.TryParse(input, out saldo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string mensagemErro = "\nValor inválido. Por favor, digite um número.";
                Console.ResetColor();
                return mensagemErro;
            }
            string resultado;
            if (saldo > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                resultado = $"\nO Saldo atual de {saldo}, é Positivo!";
            }
            else if (saldo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                resultado = $"\nO Saldo atual de {saldo}, é ZERO!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                resultado = $"\nO Saldo atual de {saldo}, é Negativo!";
            }
            Console.ResetColor();
            return resultado;
        }


        //======================================================================
        public void ExibiMSG()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 1, Desafio 2: Classificação de produtos.");
            Console.Write("\nDigite o código do produto (1 ou 2): ");
            Console.ResetColor();

            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (input == "1")
            {
                Console.WriteLine($"\nProduto Perecivel, o código digitado foi {input}");
            }
            else if (input == "2")
            {
                Console.WriteLine($"\nProduto Não Perecivel, o código digitado foi {input}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nCódigo inválido. Por favor, digite 1 ou 2.");
            }
            Console.ResetColor();
        }
        //======================================================================

        public void ClassificacaoAluno()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 1, Desafio 3: Classificando a nota de um aluno.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nDigite a nota final do Aluno, número entre 0 e 10: ");
            Console.ResetColor();
            string inputNota = Console.ReadLine();
            //Verifica se a entrada é um número double válido e se está dentro do intervalo permitido
            //Mas não está funcionando com 8.5, por exemplo, então o problema é que o TryParse está usando a cultura atual do sistema, que pode estar configurada para usar vírgula como separador decimal. Para resolver isso, podemos especificar a cultura invariante ao chamar TryParse, assim ele sempre usará o ponto como separador decimal. Aqui está a correção:
            if (double.TryParse(inputNota, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double nota) && nota >= 0 && nota <= 10)
            {
                if (nota >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nA");
                }
                else if (nota >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nB");
                }
                else if (nota >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nC");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nD");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nValor inválido. Por favor, digite um número entre 0 e 10.");
            }
            Console.ResetColor();
        }
        //=========================================================================
        public void VerificaAcesso()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 1, Desafio 4: Verificando acesso a área restrita.");
            Console.Write("\nDigite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o nível de acesso: ");
            int nivel = int.TryParse(Console.ReadLine(), out int tempNivel) ? tempNivel : 0;

            Console.ResetColor();
            if (senha == 42 && nivel >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAcesso liberado.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nAcesso negado.");
            }
            Console.ResetColor();
        }
        //=========================================================================
        //Classificando a faixa etária
        /*
        Receba a idade do cliente como entrada.
        Classifique-o em uma das faixas
        Infantil (0 a 12 anos)
        Adolescente (13 a 17 anos)
        Adulto (18 a 59 anos)
        Idoso (60 anos ou mais)
        Exiba a categoria correspondente
        */
        public void ClassificaFaixaEtaria()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Aula 1, Desafio 5: Classificando a faixa etária.");
            Console.Write("\nDigite a idade do cliente: ");
            Console.ResetColor();
            string inputIdade = Console.ReadLine();
            if (int.TryParse(inputIdade, out int idade) && idade >= 0)
            {
                if (idade <= 12)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nInfantil");
                }
                else if (idade <= 17)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nAdolescente");
                }
                else if (idade <= 59)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nAdulto");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nIdoso");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nValor inválido. Por favor, digite uma idade válida.");
            }
            Console.ResetColor();
        }
    }
}
