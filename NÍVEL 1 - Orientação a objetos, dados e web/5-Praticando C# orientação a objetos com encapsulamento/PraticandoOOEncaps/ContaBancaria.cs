namespace PraticandoOOEncaps;

internal class ContaBancaria
{
    private decimal saldo;
    public string Titular { get; set; }
    public decimal Saldo => saldo;
    public ContaBancaria(string titular, decimal saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
    }
    //Método público Sacar(double valor) que só realiza o saque se a classe interna de segurança permitir
    public void Sacar(decimal valor)
    {
        SegurancaConta seguranca = new SegurancaConta();
        if (seguranca.ValidarSaque(valor))
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saque negado pela política de segurança.");
        }
    }
}
