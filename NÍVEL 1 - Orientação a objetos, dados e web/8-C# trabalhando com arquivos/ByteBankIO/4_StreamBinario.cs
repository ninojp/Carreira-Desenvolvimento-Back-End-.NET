
internal partial class Program
{
    static void TestaEscritaBinaria()
    {
        var caminhoNovoArquivo = "testeEscritaBinaria.txt";
        using var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create);
        using var escritor = new StreamWriter(fluxoDeArquivo);
        escritor.WriteLine(true);
        escritor.WriteLine(false);
        escritor.WriteLine(1432579876);
        //escritor.Flush();
        Console.WriteLine("Aplicação finalizada!");
    }
    static void EscritaBinaria()
    {
        using var fs = new FileStream("contaCorrenteBinaria.txt", FileMode.Create);
        using var escritor = new BinaryWriter(fs);
        escritor.Write(654);
        escritor.Write(84598098);
        escritor.Write(4000.50);
        escritor.Write("Gustavo Braga");
        Console.WriteLine("Aplicação EscritaBinaria(), finalizada!");
    }
    static void LeituraBinaria()
    {
        using var fs = new FileStream("contaCorrenteBinaria.txt", FileMode.Open);
        using var leitor = new BinaryReader(fs);
        var agencia = leitor.ReadInt32();
        var numero = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();
        Console.WriteLine($"Agência: {agencia}, Número: {numero}, Saldo: {saldo}, Titular: {titular}");
    }
}
