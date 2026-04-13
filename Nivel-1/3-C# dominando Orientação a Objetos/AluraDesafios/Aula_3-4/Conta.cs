namespace AluraDesafios.Aula3;

internal class Conta
{
    public string Numero { get; set; }
    public string Titular { get; set; }
    protected decimal Saldo { get; set; } = 0;
    public Conta(string numero, string titular)
    {
        Numero = numero;
        Titular = titular;
    }
    public virtual void Depositar(decimal valor)
    {
        Saldo = valor;
        Console.WriteLine("Operação de depósito não permitida para este tipo de conta.");
        //throw new InvalidOperationException("Operação de depósito não permitida para este tipo de conta.");
    }
    public virtual void Sacar(decimal valor)
    {
        Console.WriteLine("Operação de saque não permitida para este tipo de conta.");
        //throw new InvalidOperationException("Operação de saque não permitida para este tipo de conta.");
    }
    public virtual decimal ExibirSaldo()
    {
        return Saldo;
    }
}
