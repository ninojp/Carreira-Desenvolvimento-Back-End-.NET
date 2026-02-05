ExerciciosPraticos.Praticando.Main();

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
do
{
    Console.Write("\n Exercício 5: Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("\n Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("\n O número é maior.");
    }
    else
    {
        Console.WriteLine("\n O número é menor.");
    }

} while (true);

Console.WriteLine("\n O jogo acabou. Você acertou o número secreto!");