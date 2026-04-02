namespace PraticandoColecoes.Aula1;

internal class OrdenandoLista
{
    internal string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };
    internal void OrdenarLista()
    {
        //nomes.OrderBy(nome => nome).ToList().ForEach(nome => Console.WriteLine(nome));
        Array.Sort(nomes);
        foreach (var nome in nomes)
        {
            Console.WriteLine($"Array.Sort(), {nome}");
        }
    }
}
