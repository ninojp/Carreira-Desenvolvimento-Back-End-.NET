namespace PraticandoOOEncaps;

internal class Funcionario
{
    private decimal salario;
    public decimal Salario
    {
        get => salario;
        private set => salario = value;
    }
    public string Nome { get; private set; }
    public Funcionario(string nome, decimal salarioInicial)
    {
        Nome = nome;
        salario = salarioInicial;
    }
    public void ReajustarSalario(decimal novoValor)
    {
        if (novoValor < salario)
        {
            Console.WriteLine("Valor de reajuste inválido!\nO novo salário não pode ser menor ou igual a o salário inicial!");
            return;
        }
        salario = novoValor;
        Console.WriteLine($"Salário reajustado para: {salario:C}");
    }
}
