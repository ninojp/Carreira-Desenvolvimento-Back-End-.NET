namespace PraticandoLoops;
internal class NumeroSecreto
{
    public void AdivinharNumeroSecreto()
    {
        int numeroSecreto = 66;
        int tentativa;
        Console.WriteLine("Tente adivinhar o número secreto (entre 1 e 100): ");
        do
        {
            tentativa = int.Parse(Console.ReadLine());
            if (tentativa < numeroSecreto)
            {
                Console.WriteLine("Muito baixo! Tente novamente.");
            }
            else if (tentativa > numeroSecreto)
            {
                Console.WriteLine("Muito alto! Tente novamente.");
            }
        } while (tentativa != numeroSecreto);
        Console.WriteLine("Parabéns! Você adivinhou o número secreto!");

    }
}
