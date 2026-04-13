namespace PraticandoOOHeranca;

internal class PagamentoBoleto : Pessoa, IPagamentos
{
    public PagamentoBoleto(string nome, int idade) : base(nome, idade)
    {
    }
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Processando pagamento de R${valor} para {Nome} via boleto.");
    }
}