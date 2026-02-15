namespace PraticandoLoops;
internal class PulandoNumeros
{
    public void NumeroPular()
    {
        for (int i = 0; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
