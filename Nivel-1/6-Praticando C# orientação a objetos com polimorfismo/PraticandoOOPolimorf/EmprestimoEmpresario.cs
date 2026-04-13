namespace PraticandoOOPolimorf;

internal class EmprestimoEmpresario : IEmprestimo
{
    //Polimorfismo de inclusão: A classe EmprestimoEmpresario implementa a interface IEmprestimo,
    //permitindo que seja tratada como um tipo de empréstimo, mesmo que tenha uma implementação diferente para o cálculo do valor final.
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.025m; // Taxa de 2.5% ao mês para empréstimos empresariais
        return valor + (valor * taxa * meses);
    }
}
