namespace PraticandoOOHeranca;

internal class PagamentoCredito : Pessoa, IPagamentos
{
    public string Email { get; }

    public PagamentoCredito(string nome, int idade, string email) : base(nome, idade)
    {
        Email = email;
    }
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Processando pagamento de R${valor} para {Nome}, email {Email}, via cartão de crédito.");
    }
}