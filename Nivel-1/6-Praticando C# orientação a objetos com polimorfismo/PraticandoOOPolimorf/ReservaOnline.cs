namespace PraticandoOOPolimorf;

internal class ReservaOnline : Reserva
{
    public ReservaOnline(string titulo) : base(titulo) { }
    public override void Confirmar()
    {
        Console.WriteLine("Confirmando reserva online: " + Titulo);
        Console.WriteLine("Link de acesso: www.exemplo.com/reserva");
    }
}
