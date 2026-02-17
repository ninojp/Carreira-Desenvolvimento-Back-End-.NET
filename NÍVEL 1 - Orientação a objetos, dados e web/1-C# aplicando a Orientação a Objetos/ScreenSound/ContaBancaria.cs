namespace ScreenSound;
internal class ContaBancaria
//1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
{
//    public string titular;
//    public int numeroIndicador;
//    public decimal saldo;
//    public string senha;
//    public void exibirDados()
//    {
//        Console.WriteLine(@$"O Titular é: {titular}
//Seu numero Indicador é: {numeroIndicador}
//Seu saldo é: {saldo}");
//    }
//===================================================================================

//Aula 2
//1. Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
    public string Titular { get; set; }
    public int NumeroIndicador { get; set; }
    public decimal Saldo { get; set; }
    public string Senha { get; set; }
    public void ExibirDados()
    {
        Console.WriteLine(@$"O Titular é: {Titular}
Seu numero Indicador é: {NumeroIndicador}
Seu saldo é: {Saldo}");
    }
}