using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;

namespace ExerciciosPraticos
{
    public class PraticandoAula4
    {
        Dictionary<string, Dictionary<string, List<int>>> notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
            { "Ana", new Dictionary<string, List<int>> {
                { "C#", new List<int> { 8, 7, 6 } },
                { "Java", new List<int> { 7, 6, 5 } },
                { "Python", new List<int> { 9, 8, 8 } }
            }},
            { "Maria", new Dictionary<string, List<int>> {
                { "C#", new List<int> { 6, 5, 4 } },
                { "Java", new List<int> { 8, 7, 6 } },
                { "Python", new List<int> { 6, 10, 5 } }
            }},
            { "Luiza", new Dictionary<string, List<int>> {
                { "C#", new List<int> { 2, 3, 10 } },
                { "Java", new List<int> { 8, 8, 8 } },
                { "Python", new List<int> { 7, 7, 7 } }
            }}
        };
        void CalculaMediaNotaAlunoDisciplina(string nomeAluno, string nomeDisciplina)
        {
            if (notasAlunos.ContainsKey(nomeAluno) && notasAlunos[nomeAluno].ContainsKey(nomeDisciplina))
            {
                var notas = notasAlunos[nomeAluno][nomeDisciplina];
                var media = notas.Average();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nA média das notas de {nomeAluno} na disciplina {nomeDisciplina} é: {media}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nAluno ou disciplina não encontrado.");
                Console.ResetColor();
            }
        }
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nCalculando a média das notas dos alunos por disciplina:");
            Console.ResetColor();
            var praticandoAula4Exercicio1 = new PraticandoAula4();
            Console.ForegroundColor = ConsoleColor.Green;
            praticandoAula4Exercicio1.CalculaMediaNotaAlunoDisciplina("Luiza", "C#");
            praticandoAula4Exercicio1.CalculaMediaNotaAlunoDisciplina("Maria", "Python");
            praticandoAula4Exercicio1.CalculaMediaNotaAlunoDisciplina("Ana", "Java");
            Console.ResetColor();

            //1.Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDesafios: \n1. Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.");
            Console.ResetColor();
            var NinoJP = new Dictionary<string, List<double>> {
                { "Nino", new List<double> { 8.5, 7.0, 9.0 } }
            };
            var mediaNino = NinoJP["Nino"].Average();
            //exibir apenas dois dígitos após a vírgula
            Console.WriteLine($"\nA média das notas de Nino é: {mediaNino:F2}");

            //2. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n2. Armazenar produtos e suas quantidades em estoque e mostre");
            Console.ResetColor();
            Dictionary<string, int> produtosEstoque = new Dictionary<string, int>();
            produtosEstoque.Add("Camiseta", 50);
            produtosEstoque.Add("Calça", 30);
            produtosEstoque.Add("Tênis", 20);
            produtosEstoque.Add("Boné", 15);
            foreach (string produto in produtosEstoque.Keys)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Produto: {produto}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($", Quantidade em estoque: {produtosEstoque[produto]}");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nDigite o nome do produto para verificar a quantidade em estoque:");
            Console.ResetColor();
            string produtoDigitado = Console.ReadLine().ToLower();
            var produtosEstoqueLower = produtosEstoque.ToDictionary(kvp => kvp.Key.ToLower(), kvp => kvp.Value);
            if (produtosEstoqueLower.ContainsKey(produtoDigitado))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nProduto: {produtoDigitado}, Quantidade em estoque: {produtosEstoqueLower[produtoDigitado]}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nProduto não encontrado!");
                Console.ResetColor();
            }

            //3. Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n3. meuQuiz, simples de perguntas e respostas");
            Console.ResetColor();
            Dictionary<string, string> meuQuiz = new Dictionary<string, string>();
            meuQuiz.Add("Qual é a capital da França?", "Paris");
            meuQuiz.Add("Qual é a capital da Itália?", "Roma");
            meuQuiz.Add("Qual é a capital do Brasil?", "Brasília");
            int pontuacao = 0;
            foreach (string pergunta in meuQuiz.Keys)
            {
                Console.WriteLine($"\n{pergunta}");
                string respostaUsuario = Console.ReadLine();
                if (respostaUsuario.Equals(meuQuiz[pergunta], StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Resposta correta {meuQuiz[pergunta]}, Pontuação: {++pontuacao}!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Resposta incorreta! A resposta correta é: {meuQuiz[pergunta]}");
                    Console.ResetColor();
                }
            }
            //4. Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n4. Simulando um sistema de login");
            Console.ResetColor();
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            Console.Write("\nDigite o nome do novo usuário: ");
            string novoUsuario = Console.ReadLine();
            Console.Write("Digite a senha do novo usuário: ");
            string novaSenha = Console.ReadLine();
            usuarios.Add(novoUsuario, novaSenha);
            Console.Write("\nDigite o nome de usuário para login: ");
            string usuarioLogin = Console.ReadLine();
            Console.Write("Digite a senha do usuário: ");
            string senhaLogin = Console.ReadLine();
            if (usuarios.ContainsKey(usuarioLogin) && usuarios[usuarioLogin] == senhaLogin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLogin bem-sucedido!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNome de usuário ou senha incorretos!");
                Console.ResetColor();
            }
            //Faça como eu fiz:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nFaça como eu fiz:\n Crie um dicionário que armazene o nome de carros e suas estatisticas de vendas.\n");
            Console.ResetColor();
            Dictionary<string, List<int>> vendasCarros = new() {
                { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
                { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
                { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
                { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
                { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
            };
            foreach (string carro in vendasCarros.Keys)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Carro: {carro}");
                Console.ResetColor();
            }
            void CalculaMediaVendasCarro(string nomeCarro)
            {
                if (vendasCarros.ContainsKey(nomeCarro))
                {
                    var vendas = vendasCarros[nomeCarro];
                    var media = vendas.Average();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nA média de vendas do {nomeCarro} é: {media}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nCarro não encontrado.");
                    Console.ResetColor();
                }
            }
            Console.Write("\nDigite o nome do carro para calcular a média de vendas: ");
            string carroDigitado = Console.ReadLine();
            CalculaMediaVendasCarro(carroDigitado);

        }
    }
}
