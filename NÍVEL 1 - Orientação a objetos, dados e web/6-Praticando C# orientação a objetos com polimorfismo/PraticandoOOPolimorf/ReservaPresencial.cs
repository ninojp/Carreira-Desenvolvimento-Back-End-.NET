namespace PraticandoOOPolimorf;

internal class ReservaPresencial : Reserva
{
    public ReservaPresencial(string titulo) : base(titulo) { }
    public override void Confirmar()
    {
        Console.WriteLine("Confirmando reserva presencial: " + Titulo);
        Console.WriteLine("Ponto de encontro: Praça Central, às 8h");
    }
}
