namespace PraticandoColecoes.Aula1;

internal class Somando
{
    internal decimal[] doacoes = { 103.54m, 259.72m, 82.16m, 154.87m, 364.45m, 14.49m };
    
    internal void SomarDoacoes()
    {
        decimal total = 0;
        foreach (var doacao in doacoes)
        {
            total += doacao;
        }
        //for (int i = 0; i < doacoes.Length; i++)
        //{
        //    total += doacoes[i];
        //}
        Console.WriteLine($"O valor total das doações é: {total}");
    }
}
