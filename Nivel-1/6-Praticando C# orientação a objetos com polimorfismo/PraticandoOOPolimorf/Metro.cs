namespace PraticandoOOPolimorf;

internal class Metro : Transporte
{
    //Metrô: tempo estimado = distância + 5 minutos
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm + 5; // Supondo um tempo base de 1 minuto por km mais 5 minutos de espera para o metrô
    }
}
