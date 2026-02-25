namespace AluraDesafios.Aula3;

internal class InstanciarObj
{
    //1. Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo.
    //Utilize herança para criar uma classe base chamada FormaGeometrica,
    //que contenha métodos para calcular a área e o perímetro de uma forma.
    FormaGeometrica quadrado = new Quadrado { Lado = 5 };
    FormaGeometrica circulo = new Circulo { Raio = 3 };
    FormaGeometrica triangulo = new Triangulo { Base = 4, Altura = 3, Lado1 = 4, Lado2 = 3, Lado3 = 5 };
    public void ExibirResultadosFormasGeometricas()
    {
        Console.WriteLine($"\nÁrea do quadrado: {quadrado.CalcularArea()}");
        Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro do quadrado: {quadrado.CalcularPerimetro()}");
        Console.WriteLine($"Perímetro do círculo: {circulo.CalcularPerimetro()}");
        Console.WriteLine($"Perímetro do triângulo: {triangulo.CalcularPerimetro()}");
    }

    //2. Crie uma hierarquia de classes representando funcionários de uma empresa.
    //Utilize herança para criar classes como Gerente, Programador e Analista.
    //Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.
    Funcionario gerente = new Gerente { Nome = "João", Salario = 5000, Setor = "Vendas" };
    Funcionario programador = new Programador { Nome = "Maria", Salario = 4000, LinguagemDeProgramacao = "C#" };
    Funcionario analista = new Analista { Nome = "Carlos", Salario = 4500, AreaDeAtuacao = "Análise de Sistemas" };
    public void ExibirResultadosFuncionarios()
    {
        Console.WriteLine($"Gerente: {gerente.Nome}, Salário: {gerente.Salario}, Setor: {(gerente as Gerente)?.Setor}");
        Console.WriteLine($"Programador: {programador.Nome}, Salário: {programador.Salario}, Linguagem de Programação: {(programador as Programador)?.LinguagemDeProgramacao}");
        Console.WriteLine($"Analista: {analista.Nome}, Salário: {analista.Salario}, Área de Atuação: {(analista as Analista)?.AreaDeAtuacao}");
    }

    //3. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca.
    //Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.
    Conta contaCorrente = new ContaCorrente("12345-6", "João");
    Conta contaPoupanca = new ContaPoupanca("65432-1", "Maria");
    public void ExibirResultadosContasBancarias()
    {
        contaCorrente.Depositar(1000);
        Console.WriteLine($"Saldo após depósito R$1000 na Conta Corrente: {contaCorrente.ExibirSaldo()}");
        Console.WriteLine($"Saldo da Conta Poupança antes do depósito: {contaPoupanca.ExibirSaldo()}");
        contaCorrente.Sacar(200);
        Console.WriteLine($"Saldo da Conta Corrente: {contaCorrente.ExibirSaldo()}");
        contaPoupanca.Depositar(500);
        Console.WriteLine($"Saldo após depósito R$500 na Conta Poupança: {contaPoupanca.ExibirSaldo()}");
        contaPoupanca.Sacar(200);
        Console.WriteLine($"Saldo da Conta Poupança: {contaPoupanca.ExibirSaldo()}");
    }

    //4. Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe.
    //Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom
    //que represente o som característico de cada tipo de animal.
    Animal animal = new Animal();
    public void ExibirResultadosAnimais()
    {
        Mamifero mamifero = new Mamifero();
        Ave ave = new Ave();
        Peixe peixe = new Peixe();

        Console.WriteLine("Som do Mamífero:");
        mamifero.EmitirSom();

        Console.WriteLine("\nSom da Ave:");
        ave.EmitirSom();

        Console.WriteLine("\nSom do Peixe:");
        peixe.EmitirSom();
    }
    //5. Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop.
    //Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes
    //que retorne informações específicas de cada produto.
    ProdutoEletronico smartphone = new Smartphone("Apple", "iPhone 13", "iOS");
    ProdutoEletronico tablet = new Tablet("Samsung", "Galaxy Tab S7", "Android");
    ProdutoEletronico laptop = new Laptop("Dell", "XPS 15", "Windows");
    public void ExibirProdutosEletronicos()
    {
        Console.WriteLine("Informações do Smartphone:");
        smartphone.ExibirInformacoes();

        Console.WriteLine("\nInformações do Tablet:");
        tablet.ExibirInformacoes();

        Console.WriteLine("\nInformações do Laptop:");
        laptop.ExibirInformacoes();
    }
}
