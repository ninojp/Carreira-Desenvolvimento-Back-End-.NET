using ScreenSoundAPI.Aula2;

namespace ScreenSoundAPI.Aula3;

internal class Aula3Desafios
{
    internal static void Desafio1()
    {
        int[] listaNumeros = [1, 2, 2, 3, 4, 4, 5, 6, 7, 8, 8, 9, 10, 10];
        listaNumeros.Distinct().ToList().ForEach(n => Console.WriteLine(n));
    }
    internal static void Desafio1_5()
    {
        int[] listNumeros = [0, 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 10];
        int[] list2Numeros = [10, 20, 3, 2, 4, 5, 3, 6, 70, 8, 90, 1];
        var numerosComuns = listNumeros.Intersect(list2Numeros);
        Console.WriteLine("Números presentes em ambas as listas:");
        foreach (var numero in numerosComuns)
        {
            Console.WriteLine(numero);
        }
    }
    internal static void Desafio2()
    {
        List<Livro> livros = new()
        {
            new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005 },
            new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
            new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
            new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
            new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
        };
        var titulosLivros = livros
            .Where(l => l.AnoPublicacao > 2000)
            .OrderBy(l => l.Titulo)
            .Select(l => l.Titulo);

        Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");
        foreach (var titulo in titulosLivros)
        {
            Console.WriteLine(titulo);
        }
    }
    internal static void Desafio3()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Laptop", Preco = 1200 },
            new Produto { Nome = "Smartphone", Preco = 800 },
            new Produto { Nome = "Tablet", Preco = 500 },
            new Produto { Nome = "Câmera", Preco = 300 }
        };
        decimal precoMedio = produtos.Average(p => p.Preco);
        Console.WriteLine($"Preço médio dos produtos: {precoMedio}");
    }
    internal static void Desafio4()
    {
        List<string> Palavras = ["cachorro", "gato", "elefante", "leão", "cobra", "Eu", "Ele"];
        var palavrasFiltradas = Palavras.Where(p => p.Length > 3).OrderBy(p => p.Length);

        Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas por comprimento:");
        foreach (var palavra in palavrasFiltradas)
        {
            Console.Write(palavra + ", ");
        }
    }
}
