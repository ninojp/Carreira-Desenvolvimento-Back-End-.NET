using System.Text;
internal partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using var fluxoDeEntrada = Console.OpenStandardInput();
        using var fs = new FileStream("entradaConsole.txt", FileMode.Create);
        var buffer = new byte[1024];
        while (true)
        {
            var numeroBytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);
            var textoDigitado = Encoding.UTF8.GetString(buffer, 0, numeroBytesLidos);
            fs.Write(buffer, 0, numeroBytesLidos);
            fs.Flush();
            Console.WriteLine($"Bytes lidos {numeroBytesLidos} -> Texto digitado: {textoDigitado}");
        }
    }
}
