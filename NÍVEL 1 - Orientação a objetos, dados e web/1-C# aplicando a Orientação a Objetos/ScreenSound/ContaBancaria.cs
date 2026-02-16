namespace ScreenSound;
internal class ContaBancaria
//1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
{
    public string titular;
    public int numeroIndicador;
    public decimal saldo;
    public string senha;
    public void exibirDados()
    {
        Console.WriteLine(@$"O Titular é: {titular}
Seu numero Indicador é: {numeroIndicador}
Seu saldo é: {saldo}");
    }

}
