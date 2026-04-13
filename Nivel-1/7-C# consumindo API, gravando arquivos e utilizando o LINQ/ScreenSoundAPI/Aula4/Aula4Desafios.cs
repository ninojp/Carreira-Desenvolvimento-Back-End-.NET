using System.Text.Json;
namespace ScreenSoundAPI.Aula4;

internal class Aula4Desafios
{
    internal static void Desafio1()
    {
        Pessoa pessoa = new();
        Console.WriteLine("Digite o nome da pessoa:");
        pessoa.Nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa:");
        pessoa.Idade = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digite o e-mail da pessoa:");
        pessoa.Email = Console.ReadLine();

        string jsonString = JsonSerializer.Serialize(pessoa);
        string fileName = "pessoaJSON.json";
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine($"Os dados foram salvos em {fileName}\nNo endereço: {Path.GetFullPath(fileName)}");
    }
    internal static void Desafio2()
    {
        // Nome do arquivo para ler
        string fileName = "pessoaJSON.json";
        // Verificar se o arquivo existe
        if (File.Exists(fileName))
        {
            // Ler conteúdo do arquivo JSON
            string jsonString = File.ReadAllText(fileName);
            // Desserializar JSON para objeto Pessoa
            Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);
            // Exibir informações da pessoa
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"E-mail: {pessoa.Email}");
        }
        else
        {
            Console.WriteLine($"O arquivo {fileName} não existe.");
        }
    }
    internal static void Desafio3()
    {
        List<Pessoa> pessoas = new();
        string fileName = "pessoasJSON.json";

        while (true)
        {
            Pessoa pessoa = new();
            Console.WriteLine("Digite o nome da pessoa (ou 'sair' para encerrar):");
            string nome = Console.ReadLine();
            if (nome.ToLower() == "sair")
                break;
            pessoa.Nome = nome;

            Console.WriteLine("Digite a idade da pessoa:");
            pessoa.Idade = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o e-mail da pessoa:");
            pessoa.Email = Console.ReadLine();

            pessoas.Add(pessoa);
        }
        string jsonString = JsonSerializer.Serialize(pessoas);
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"\nOs dados foram salvos em: {Path.GetFullPath(fileName)}");
    }
    internal static void Desafio4()
    {
        string nomeDoArquivo = "pessoasJSON.json";
        if (File.Exists(nomeDoArquivo))
        {
            string jsonString = File.ReadAllText(nomeDoArquivo);
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
            Console.WriteLine("\nPessoas cadastradas:");
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {nomeDoArquivo} não existe.");
        }
    }
    internal static void Desafio5()
    {
        string nomeDoArquivo = "pessoasJSON.json";
        if (File.Exists(nomeDoArquivo))
        {
            // Ler conteúdo do arquivo JSON
            string jsonString = File.ReadAllText(nomeDoArquivo);
            // Desserializar JSON para lista de pessoas
            List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
            // Permitir ao usuário inserir uma idade
            Console.Write("Digite a idade para buscar pessoas: ");
            int idadeParaBuscar = int.Parse(Console.ReadLine());
            // Filtrar pessoas com a idade especificada
            List<Pessoa> pessoasComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();
            if (pessoasComIdade.Any())
            {
                // Exibir informações das pessoas com a idade especificada
                Console.WriteLine($"Pessoas com {idadeParaBuscar} anos:");

                foreach (Pessoa pessoa in pessoasComIdade)
                {
                    Console.WriteLine($"Nome: {pessoa.Nome}, E-mail: {pessoa.Email}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhuma pessoa encontrada com {idadeParaBuscar} anos.");
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {nomeDoArquivo} não existe.");
        }
    }
}