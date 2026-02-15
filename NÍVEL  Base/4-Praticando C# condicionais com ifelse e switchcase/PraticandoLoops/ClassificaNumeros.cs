namespace PraticandoLoops;
internal class ClassificaNumeros
{
    public void ClassificarNumeros()
    {
        List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

        for (int i = 0; i < notas.Count; i++)
        {
            if (notas[i] >= 6)
            {
                Console.WriteLine($"Nota {notas[i]} - Aprovado");
            }
            else
            {
                Console.WriteLine($"Nota {notas[i]} - Reprovado");
            }
        }
    }
}
