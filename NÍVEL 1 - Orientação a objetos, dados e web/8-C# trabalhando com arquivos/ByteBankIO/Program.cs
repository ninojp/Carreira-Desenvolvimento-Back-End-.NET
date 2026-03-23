using System.Text;
partial class Program
{
    static void Main(string[] args)
    {
        CriarArquivo();
        CriarArquivoComWriter();
        Console.ReadLine();

        //Aula 1 e 2 ==========================================================
        //var enderecoArquivo = "contas.txt";
        //Filestream é uma classe do namespace System.IO que representa um fluxo de bytes para leitura e escrita em arquivos.
        //using (var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        //    {
        //        var numeroBytesLidos = -1;
        //        var buffer = new byte[1024]; //1KB
        //        while (numeroBytesLidos != 0)
        //        {
        //            numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        //            Console.WriteLine($"Bytes lidos: {numeroBytesLidos}");
        //            EscreverBuffer(buffer, numeroBytesLidos);
        //        }
        //        fluxoDoArquivo.Close();
        //        Console.ReadLine();
        //    }
    }
    //static void EscreverBuffer(byte[] buffer, int bytesLidos)
    //{
    //var utf8 = new UTF8Encoding();
    //var texto = utf8.GetString(buffer, 0, bytesLidos);
    //var texto = UTF8Encoding.UTF8.GetString(buffer);
    //Console.WriteLine(texto);
    //foreach (var meuByte in buffer)
    //{
    //    Console.Write(meuByte);
    //    Console.Write(" ");
    //}
    //}
    //=========================================================
    //public void LerArquivo()
    //{
    //    var fs = new FileStream("c:/temp/teste.txt", FileMode.Open);
    //    var buffer = new byte[1024];
    //    var encoding = Encoding.ASCII;
    //    var bytesLidos = fs.Read(buffer, 0, 1024);
    //    var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);
    //    Console.Write(conteudoArquivo);
    //}
}