using AluraDesafios.Filmes;
using AluraDesafios.Aula3;

//Aula 1 -  Desafio: hora da prática - Desafio 1
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
//================================================================================================================

//Aula 3 - 1. Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo.
Console.WriteLine("Aula 3 - 1. Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo.");
InstanciarObj instanciaObj = new InstanciarObj();
Console.ForegroundColor = ConsoleColor.Green;
instanciaObj.ExibirResultadosFormasGeometricas();
Console.ResetColor();
//================================================================================================================

//Aula 3 - 2. Crie uma hierarquia de classes representando funcionários de uma empresa.
Console.WriteLine("\nAula 3 - 2. Crie uma hierarquia de classes representando funcionários de uma empresa.");
Console.ForegroundColor = ConsoleColor.Green;
instanciaObj.ExibirResultadosFuncionarios();
Console.ResetColor();
//================================================================================================================

//Aula 3 - 3. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca.
Console.WriteLine("\nAula 3 - 3. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca.");
Console.ForegroundColor = ConsoleColor.Green;
instanciaObj.ExibirResultadosContasBancarias();
Console.ResetColor();
//================================================================================================================

//Aula 3 - 4. Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe.
Console.WriteLine("\nAula 3 - 4. Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe.");
Console.ForegroundColor = ConsoleColor.Green;
instanciaObj.ExibirResultadosAnimais();
Console.ResetColor();
//================================================================================================================

//Aula 3 - 5. Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Laptop e Tablet.
Console.WriteLine("\nAula 3 - 5. Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Laptop e Tablet.");
Console.ForegroundColor = ConsoleColor.Green;
instanciaObj.ExibirProdutosEletronicos();
Console.ResetColor();