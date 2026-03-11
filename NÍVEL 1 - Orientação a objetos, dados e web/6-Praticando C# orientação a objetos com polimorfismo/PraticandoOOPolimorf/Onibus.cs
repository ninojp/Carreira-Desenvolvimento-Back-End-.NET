namespace PraticandoOOPolimorf;

internal class Onibus : Transporte
{
    //Ônibus: tempo estimado = (distância × 2) + 5 minutos
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm * 2 + 5; // Supondo um tempo base de 2 minutos por km mais 5 minutos de espera para o ônibus
    }
}
