namespace PraticandoOOPolimorf;

internal class Bicicleta : Transporte
{
    //Bicicleta: tempo estimado = distância × 4 minutos
    public override int CalcularTempo(int distanciaKm)
    {
        return distanciaKm * 4; // Supondo um tempo base de 4 minutos por km para a bicicleta
    }
}
