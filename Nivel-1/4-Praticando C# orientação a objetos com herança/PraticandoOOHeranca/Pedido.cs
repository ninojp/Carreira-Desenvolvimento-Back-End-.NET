namespace PraticandoOOHeranca;

internal class Pedido : IExpiravel
{
    private bool pago;
    public int Id { get; }
    public string Cliente { get; }
    public DateTime Data { get; }
    public decimal ValorTotal { get; }
    public Avalicao Avalicao { get; }
    public Pedido(int id, string cliente, decimal valorTotal)
    {
        Id = id;
        Cliente = cliente;
        Data = DateTime.Now;
        ValorTotal = valorTotal;
        pago = false;
    }
    public void ExibirResumo()
    {
        Console.WriteLine($"Pedido #{Id} - Cliente: {Cliente}");
        Console.WriteLine($"Valor Total: R$ {ValorTotal:F2}");
        Console.WriteLine($"Status: {(EstaExpirado() ? "Expirado" : "Válido")}");
    }
    public bool EstaExpirado()
    {
        return !pago && DateTime.Now > Data.AddMinutes(15);
    }
    public void Pagar()
    {
        pago = true;
    }
}
