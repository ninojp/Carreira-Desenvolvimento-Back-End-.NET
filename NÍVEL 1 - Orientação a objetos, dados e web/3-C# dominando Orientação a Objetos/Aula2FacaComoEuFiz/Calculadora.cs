namespace Aula2FacaComoEuFiz;

internal class Calculadora
{
    //4. Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas,
    //além de calcular raiz quadrada e potências. O usuario deve entrar com dois números
    //e um simbolo que represente a operação a ser feita.

    public double RealizarOperacao(double numero1, double numero2, string operacao)
    {
        return operacao switch
        {
            "+" => numero1 + numero2,
            "-" => numero1 - numero2,
            "*" => numero1 * numero2,
            "/" => numero2 != 0 ? numero1 / numero2 : throw new DivideByZeroException("Divisão por zero não é permitida."),
            "sqrt" => Math.Sqrt(numero1),
            "pow" => Math.Pow(numero1, numero2),
            _ => throw new InvalidOperationException("Operação inválida.")
        };
    }
}
