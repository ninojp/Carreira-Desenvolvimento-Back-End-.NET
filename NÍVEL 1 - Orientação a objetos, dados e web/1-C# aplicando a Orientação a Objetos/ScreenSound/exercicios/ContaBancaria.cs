namespace ScreenSound.exercicios;
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
    public Titular TitularDaConta { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public decimal Saldo { get; set; }
    public double Limite { get; set; }
    public string Senha { get; set; }
    public string ExibirInformacoes => @$"Conta nº {this.NumeroDaConta},
Agência {this.Agencia},
Titular: {this.TitularDaConta.NomeDoTitular},
Saldo: {this.Saldo},
Limite: {this.Limite}";
}