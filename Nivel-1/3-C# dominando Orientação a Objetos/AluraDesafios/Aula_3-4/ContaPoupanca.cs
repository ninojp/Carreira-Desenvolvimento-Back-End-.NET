namespace AluraDesafios.Aula3;

internal class ContaPoupanca : Conta
{
    public string PermiteTransferencia { get; set; } = "Não";

    public override void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public ContaPoupanca(string numero, string titular) : base(numero, titular)
    {

    }

}
