namespace PraticandoLoops;
internal class ForLacoRepeticao
{
    public void ForLoop()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine($"LoopFor com Pós Incremento++. Imprime o contador: 5 e seu indice: {i}\n");
        }
        for (int i = 0; i <= 5; ++i)
        {
            Console.WriteLine($"LoopFor com Pré ++Incremento. Imprime o contador: 5 e seu indice: {i}");
        }
        for (int i = 5; i >= 1; i--)
        {
            Console.WriteLine($"\nLoopFor com Pós Decremento--. Imprime o contador: 5 e seu indice: {i}");
        }
        for (int i = 5; i >= 1; --i)
        {
            Console.WriteLine($"LoopFor com Pré --Decremento. Imprime o contador: 5 e seu indice: {i}");
        }
        Console.WriteLine("\nA contagem chegou ao fim!");
    }
}
