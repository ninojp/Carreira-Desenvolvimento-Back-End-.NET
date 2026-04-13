namespace ScreenSound.exercicios;

internal class ContaBancaria
{
    // Propriedades que DEVEM ser protegidas
    public decimal Saldo { get; private set; } // Só altera via métodos
    public string Senha { get; private set; }  // Senha não deve ser exposta
    
    // Propriedades que raramente mudam (podem ser imutáveis após criação)
    public Titular TitularDaConta { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    
    // Propriedade que pode precisar alteração
    public double Limite { get; set; }

    //Aula 4 - Desafio 2: Criar um construtor para a classe Conta, que inicialize todas suas propriedades.
    public ContaBancaria(Titular titularDaConta, int agencia, int numeroDaConta, double limite, string senha)
    {
        TitularDaConta = titularDaConta;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = 0;
        Limite = limite;
        Senha = senha;
    }
    // Métodos para modificar o Saldo de forma controlada
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor deve ser positivo");
        Saldo += valor;
    }

    public bool Sacar(decimal valor, string senha)
    {
        if (senha != Senha)
            return false;        
        if (valor > Saldo + (decimal)Limite)
            return false;            
        Saldo -= valor;
        return true;
    }
    public string ExibirInformacoes => $"Titular: {TitularDaConta.ExibirNomeCompleto}, Agência: {Agencia}, Número da Conta: {NumeroDaConta}, Saldo: {Saldo:C}, Limite: {Limite:C}";
}