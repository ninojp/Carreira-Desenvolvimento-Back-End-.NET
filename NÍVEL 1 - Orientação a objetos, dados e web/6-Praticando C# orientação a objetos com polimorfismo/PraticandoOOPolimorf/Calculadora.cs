namespace PraticandoOOPolimorf;

internal class Calculadora
{
    public int SomarSobrecarregado(int num1, int num2)
    {
        return num1 + num2;
    }
    public int SomarSobrecarregado(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
    public double SomarSobrecarregado(double num1, double num2)
    {
        return num1 + num2;
    }
}
