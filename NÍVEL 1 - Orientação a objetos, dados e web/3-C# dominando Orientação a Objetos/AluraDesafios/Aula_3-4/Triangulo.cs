namespace AluraDesafios.Aula3;

internal class Triangulo : FormaGeometrica
{
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
    
        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    
        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
    }
}
