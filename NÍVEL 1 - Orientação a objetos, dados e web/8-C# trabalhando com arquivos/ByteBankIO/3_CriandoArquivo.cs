using System.Text;
partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create);
        var contaComoString = "456, 7890, 321.5, Maria";
        var bytes = Encoding.UTF8.GetBytes(contaComoString);
        fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        Console.WriteLine("Arquivo criado com sucesso!");
    }
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas2.csv";
        using var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create);
        using var escritor = new StreamWriter(fluxoDeArquivo);
        escritor.Write("456,65465,456.0,Pedro");
        Console.WriteLine("Arquivo criado com StreamWriter, sucesso!");
    }
}
