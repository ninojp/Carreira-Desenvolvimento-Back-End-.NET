namespace PraticandoLoops;

internal class LacoCerto
{
    public void LacoCertoParaOProblema()
    {
        List<double> notas = new List<double>{ 8.5, 6.2, 9.1, 5.8, 7.4 };
        double mediaCorte = 7.0;
        foreach (var nota in notas)
        {
            if (nota < mediaCorte)
            {
                Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
            }
            else
            {
                Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
            }
        }
    }
}
