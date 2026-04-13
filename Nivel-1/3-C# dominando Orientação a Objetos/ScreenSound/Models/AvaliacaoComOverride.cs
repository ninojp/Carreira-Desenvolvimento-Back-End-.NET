namespace ScreenSound.Models;

internal class AvaliacaoComOverride
{
    public AvaliacaoComOverride(int nota)
    {
        Nota = nota;
    }
    public int Nota { get; }
    public static AvaliacaoComOverride Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new AvaliacaoComOverride(nota);
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is not AvaliacaoComOverride other) return false;
        return Nota.Equals(other.Nota);
    }
    public override int GetHashCode()
    {
        return Nota.GetHashCode();
    }
    public override string ToString()
    {
        return Nota.ToString();
    }
}