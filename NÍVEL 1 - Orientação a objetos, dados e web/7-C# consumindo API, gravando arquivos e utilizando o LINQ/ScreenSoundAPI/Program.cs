using ScreenSoundAPI.Aula2;
using ScreenSoundAPI.Aula3;
using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nQuantidade de musicas: {musicas.Count}\n");
        //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
        //LinqOrder.ExibirListaArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "Rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Linkin Park");
        LinqFilter.FiltrarMusicasPeloAno(musicas, 2020);
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        Console.ResetColor();
    }
}
//===============================================================

// Aula 1 - Exercícios
//ClassInicial classInicial = new();
//classInicial.Executar();
//===============================================================

//Aula 2 - Exercício 1. Modelar e desserializar a classe Filme
//ClientAPIFilmes clientAPIFilmes = new();
//await clientAPIFilmes.ClientAPIFIlmesConect();
//===============================================================

//Aula 2 - Exercício 2. Modelar e desserializar a classe Pais
//List<Pais>? listaPaises = await ClientAPIPais.ConectionAPIPais();
//Console.ForegroundColor = ConsoleColor.DarkYellow;
////Console.WriteLine($"\nResposta da API de países:\n {respostaPais}");
//if (listaPaises != null)
//{
//    Console.WriteLine($"Quantidade de países: {listaPaises.Count}");
//    foreach (Pais pais in listaPaises)
//    {
//        Pais.ExibirDetalhesDoPais(pais);
//    }
//}
//Console.ResetColor();
//===============================================================

// Aula 2 - 3. Modelar e desserializar a classe Carro
//List<Carro>? listaCarros = await ClientAPICarros.ConectAPICarros();
//if (listaCarros != null)
//{
//    Console.ForegroundColor = ConsoleColor.DarkYellow;
//    Console.WriteLine($"\nQuantidade de carros: {listaCarros.Count}");
//    foreach (Carro carro in listaCarros)
//    {
//        Carro.ExibirDetalhesDoCarro(carro);
//    }
//    Console.ResetColor();
//}
//Console.ResetColor();
//===============================================================

// Aula 2 - 4. Modelar e desserializar a classe Livro
//string? respostaLivros = await ClientAPILivros.ConectAPILivros();
//Console.WriteLine(respostaLivros);
//List<Livro>? listaLivros = await ClientAPILivros.ConectAPILivros();
//if (listaLivros != null)
//{
//    Console.ForegroundColor = ConsoleColor.DarkYellow;
//    Console.WriteLine($"\nQuantidade de livros: {listaLivros.Count}");
//    foreach (Livro livro in listaLivros)
//    {
//        Livro.ExibirDetalhesDoLivro(livro);
//    }
//    Console.ResetColor();
//}
//===============================================================

// Aula 2, desafio - Modelar e desserializar a classe Personagem de Game of Thrones
//PersonagemGOT? personagemGOT = await ClientAPIGOT.ConectAPIGOT();
//if (personagemGOT != null)
//{
//    Console.ForegroundColor = ConsoleColor.DarkYellow;
//    personagemGOT.ExibirDetalhesDoPersonagem();
//    Console.ResetColor();
//}
//===============================================================

// Aula 3 - Desafio 1. Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.
//Console.WriteLine($"\nAula 3 - Desafio 1. Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Aula3Desafios.Desafio1();
//Console.ResetColor();
//===============================================================

// Aula 3 - Desafio 1.5 Dadas duas listas de números, criar uma consulta LINQ para retornar uma lista que contenha apenas os números que estão presentes em ambas as listas.
//Console.WriteLine($"\nAula 3 - Desafio 1.5 Dadas duas listas de números, criar uma consulta LINQ para retornar uma lista que contenha apenas os números que estão presentes em ambas as listas.");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Aula3Desafios.Desafio1_5();
//Console.ResetColor();

//=================================================================

// Aula 3 - Desafio 2. Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.
//Console.WriteLine($"\nAula 3 - Desafio 2. Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Aula3Desafios.Desafio2();
//Console.ResetColor();
//===============================================================

// Aula 3 - Desafio 3. Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.
//Console.WriteLine($"\nAula 3 - Desafio 3. Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Aula3Desafios.Desafio3();
//Console.ResetColor();
//===============================================================

// Aula 3 - Desafio 4. Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.
//Console.WriteLine($"\nAula 3 - Desafio 4. Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Aula3Desafios.Desafio4();
//Console.ResetColor();
//===============================================================