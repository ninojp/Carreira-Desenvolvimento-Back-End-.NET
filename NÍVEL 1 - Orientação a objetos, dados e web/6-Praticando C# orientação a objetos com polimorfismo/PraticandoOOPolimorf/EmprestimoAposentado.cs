namespace PraticandoOOPolimorf;

internal class EmprestimoAposentado : IEmprestimo
{
    //Polimorfismo de inclusão: A classe EmprestimoAposentado implementa a interface IEmprestimo,
    //permitindo que seja tratada como um tipo de empréstimo, mesmo que tenha uma implementação diferente para o cálculo do valor final.
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.015m; // Taxa de 1.5% ao mês para empréstimos para aposentados
        return valor + (valor * taxa * meses);
    }
}
