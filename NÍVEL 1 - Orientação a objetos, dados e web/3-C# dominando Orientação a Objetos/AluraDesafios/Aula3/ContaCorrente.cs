namespace AluraDesafios.Aula3
{
    internal class ContaCorrente : Conta
    {
        public string PermiteTransferencia { get; set; } = "Sim";

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }
            Saldo -= valor;
        }

        public ContaCorrente(string numero, string titular) : base(numero, titular)
        {

        }
    }
}
