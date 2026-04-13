namespace ScreenSound.exercicios;

internal class Lambdas
{
    //O Atributo List<int>, quando não declaramos o modificador de acesso, ele é privado por padrão.
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    // Exemplo de função sem lambda
    public void FuncaoSemLambda()
    {
        List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);
        bool BuscarNumerosQueSaoPares(int numero)
        {
            return numero % 2 == 0;
        }
        foreach (int numero in numerosPares)
        {
            Console.WriteLine(numero);
        }
    }
    // Exemplo de função com lambda "arrow function", que é uma função anônima, ou expressão lambda.
    public void FuncaoComLambda()
    {
        List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
        numerosPares.ForEach(numero => Console.WriteLine(numero));
    }
    //Faça como eu fiz: refatorando uma função
    public int Somar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }
    public int SomarComLambda(int a, int b) => a + b;
}
