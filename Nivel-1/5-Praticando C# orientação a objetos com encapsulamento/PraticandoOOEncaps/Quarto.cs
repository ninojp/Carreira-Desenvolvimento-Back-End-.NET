namespace PraticandoOOEncaps;

internal class Quarto
{
    private decimal valorDiaria;
    public int Numero { get; set; }
    public decimal ValorDiaria {
        get => valorDiaria;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Valor da diária não pode ser negativo. Atribuição ignorada.");
                return;
            }
            valorDiaria = value;
        }
    }
    public Quarto(int numero)
    {
        Numero = numero;
    }
}