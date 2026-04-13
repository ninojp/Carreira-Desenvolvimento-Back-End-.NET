namespace PraticandoOOHeranca;

internal class Computador
{
    private Processador Cpu;
    private PlacaMae Mobo;
    public Computador(Processador cpu, PlacaMae mobo)
    {
        Cpu = cpu;
        Mobo = mobo;
    }
    public void ExibirConfiguracao()
    {
        Console.WriteLine("Computador configurado com:");
        Console.WriteLine($"Processador: {Cpu.Marca} - {Cpu.Modelo}");
        Console.WriteLine($"Placa-mãe: {Mobo.Fabricante} - {Mobo.Socket}");
    }
}
