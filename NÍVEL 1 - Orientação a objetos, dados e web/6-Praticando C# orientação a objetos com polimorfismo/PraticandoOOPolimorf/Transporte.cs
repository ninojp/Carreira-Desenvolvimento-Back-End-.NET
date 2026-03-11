namespace PraticandoOOPolimorf;

internal class Transporte
{
    public virtual int CalcularTempo(int distanciaKm)
    {
        return distanciaKm * 5; // Supondo um tempo base de 5 minutos por km para o transporte genérico
    }
}
