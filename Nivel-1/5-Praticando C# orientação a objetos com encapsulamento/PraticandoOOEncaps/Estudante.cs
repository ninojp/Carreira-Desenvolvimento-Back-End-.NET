namespace PraticandoOOEncaps;

internal class Estudante
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public Estudante(string nome)
    {
        Nome = nome;
    }
    public double Media => (Nota1 + Nota2) / 2;
    public string Situacao => Media >= 6 ? "Aprovado" : "Reprovado";
}
