using AluraDesafios.Filmes;

List<Filme> listaFilmes = new();
void AdicionarFilme(string titulo, string duracao, List<string> elenco)
{
    Filme filme = new Filme(titulo, duracao, elenco);
    listaFilmes.Add(filme);
}

AdicionarFilme("Matrix", "2h 16min", new List<string> { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss" });
AdicionarFilme("O Senhor dos Anéis: A Sociedade do Anel", "2h 58min", new List<string> { "Elijah Wood", "Ian McKellen", "Orlando Bloom" });
AdicionarFilme("7 Vidas", "1h 43min", new List<string> { "Will Smith", "Rosario Dawson", "Woody Harrelson" });
AdicionarFilme("Alita: Anjo de Combate", "2h 2min", new List<string> { "Rosa Salazar", "Christoph Waltz", "Jennifer Connelly" });
AdicionarFilme("A Procura da Felicidade", "1h 57min", new List<string> { "Will Smith", "Jaden Smith", "Thandie Newton" });

void ExibirFilmes()
{
    Console.WriteLine("\nLista dos Filmes cadastrados:");
    for (int i = 0; i < listaFilmes.Count; i++)
    {
        Console.WriteLine($"{i + 1} - O Filme: {listaFilmes[i].Titulo}.\nTem a duração de: {listaFilmes[i].Duracao}.\nO elenco é: {string.Join(", ", listaFilmes[i].Elenco)}\n");
    }
}

Console.WriteLine("\nAula 1 -  Desafio: hora da prática - Desafio 1");
Console.ForegroundColor = ConsoleColor.Green;
ExibirFilmes();
Console.ResetColor();
