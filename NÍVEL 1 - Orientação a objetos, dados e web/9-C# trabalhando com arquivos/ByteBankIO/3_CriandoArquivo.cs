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
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "testeComFlush.txt";
        using var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create);
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"\nLinha {i}, foi escrita no arquivo!");
                //Força a escrita dos dados no arquivo, garantindo que o conteúdo seja gravado imediatamente.
                //Mesmo que o StreamWriter tenha um buffer interno para otimizar a escrita,
                //o Flush() garante que os dados sejam enviados para o arquivo sem esperar o buffer estar cheio.
                escritor.Flush(); 
                Console.WriteLine($"Linha {i}, foi escrita no Console. Tecle enter para prosseguir");
                Console.ReadLine();
            }
        }
    }
}
