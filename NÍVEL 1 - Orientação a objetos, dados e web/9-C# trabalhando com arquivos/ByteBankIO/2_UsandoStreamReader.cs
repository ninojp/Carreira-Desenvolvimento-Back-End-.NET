using ByteBankIO;
using System.Numerics;
using System.Text;
internal partial class Program
{
    public void UsandoStreamReader()
    {
        var enderecoArquivo = "contas.txt";
        using (var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo, Encoding.UTF8);
            //var linha = leitor.ReadLine();
            //var todoTexto = leitor.ReadToEnd();
            //Read(), retorna o código do próximo caractere a ser lido, ou -1 se não houver mais caracteres para ler.
            //var numero = leitor.Read();
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);
                Console.WriteLine($"Titular: {contaCorrente.Titular.Nome}, Agência: {contaCorrente.Agencia}, Número: {contaCorrente.Numero}, Saldo: {contaCorrente.Saldo}");
            }
        }

        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            // 375 4644 2483.13 Jonatan
            var campos = linha.Split(',');
            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.', ','));
            var titular = campos[3];

            var novoTitular = new Cliente();
            novoTitular.Nome = titular;

            var resultado = new ContaCorrente(agencia, numero);
            resultado.Depositar(saldo);
            resultado.Titular = novoTitular;
            return resultado;
        }
    }
}
