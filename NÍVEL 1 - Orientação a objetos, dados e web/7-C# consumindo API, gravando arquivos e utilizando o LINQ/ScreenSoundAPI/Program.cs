using ScreenSoundAPI.Aula2;
using ScreenSoundAPI.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Quantidade de musicas: {musicas.Count}");
        musicas[0].ExibirDetalhesDaMusica();
        musicas[1].ExibirDetalhesDaMusica();
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
List<Pais>? listaPaises = await ClientAPIPais.ConectionAPIPais();
Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine($"\nResposta da API de países:\n {respostaPais}");
if (listaPaises != null)
{
    Console.WriteLine($"Quantidade de países: {listaPaises.Count}");
    foreach (Pais pais in listaPaises)
    {
        Pais.ExibirDetalhesDoPais(pais);
    }
}
Console.ResetColor();
//===============================================================

// Aula 2 - 3. Modelar e desserializar a classe Carro
List<Carro>? listaCarros = await ClientAPICarros.ConectAPICarros();
if (listaCarros != null)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"\nQuantidade de carros: {listaCarros.Count}");
    foreach (Carro carro in listaCarros)
    {
        Carro.ExibirDetalhesDoCarro(carro);
    }
    Console.ResetColor();
}
Console.ResetColor();
//===============================================================

// Aula 2 - 4. Modelar e desserializar a classe Livro
//string? respostaLivros = await ClientAPILivros.ConectAPILivros();
//Console.WriteLine(respostaLivros);
List<Livro>? listaLivros = await ClientAPILivros.ConectAPILivros();
if (listaLivros != null)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"\nQuantidade de livros: {listaLivros.Count}");
    foreach (Livro livro in listaLivros)
    {
        Livro.ExibirDetalhesDoLivro(livro);
    }
    Console.ResetColor();
}