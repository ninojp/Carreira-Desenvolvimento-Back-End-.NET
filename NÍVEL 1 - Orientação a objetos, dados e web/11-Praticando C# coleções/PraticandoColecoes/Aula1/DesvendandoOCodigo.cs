namespace PraticandoColecoes.Aula1;

internal class DesvendandoOCodigo
{
    int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
    internal void DesvendarCodigo()
    {
        int codigo1 = Array.IndexOf(numeros, 19);
        int codigo2 = Array.IndexOf(numeros, 42);
        int codigo3 = Array.IndexOf(numeros, 7);
        Console.WriteLine($"Combinação do cadeado é: {codigo1}-{codigo2}-{codigo3}");
    }
}
