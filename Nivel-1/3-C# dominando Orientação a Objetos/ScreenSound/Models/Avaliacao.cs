namespace ScreenSound.Models;

internal class Avaliacao
{
    public int Nota { get; }
    public Avaliacao(int nota)
    {
        if (nota < 0)
        {
            nota = 0;
            Console.WriteLine("\nNota ajustada para 0, pois não pode ser negativa.");
        }
        else if (nota > 10) {
            nota = 10;
            Console.WriteLine("\nNota ajustada para 10, pois não pode ser maior que 10.");
        }
        Nota = nota;
    }
    // Método estático, são métodos que pertencem à classe em si, e não a uma instância específica da classe.
    // Eles podem ser chamados sem criar um objeto da classe (ou seja, sem instânciar, new() a classe).
    public static Avaliacao Parsear(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
