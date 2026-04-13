namespace PraticandoOOPolimorf;

internal class EmprestimoEstudante : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.01m;
        return valor + (valor * taxa * meses);
    }
}
