namespace PraticandoOOEncaps;

public class Paciente
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Paciente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
