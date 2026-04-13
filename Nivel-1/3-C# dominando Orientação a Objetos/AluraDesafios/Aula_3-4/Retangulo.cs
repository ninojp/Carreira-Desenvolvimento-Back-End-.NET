using AluraDesafios.Aula3;

namespace AluraDesafios.Aula_3_4;

internal class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }
    public override double CalcularArea()
    {
        return Largura * Altura;
    }
    public override double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}
