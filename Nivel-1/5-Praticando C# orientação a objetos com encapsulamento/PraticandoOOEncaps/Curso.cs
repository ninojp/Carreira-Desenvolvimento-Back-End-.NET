namespace PraticandoOOEncaps;

internal class Curso
{
    private List<Estudante> matriculas;
    public string Nome { get; set; }
    public int VagasTotais { get; }
    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }
    public bool Matricular(Estudante estudante)
    {
        if (matriculas.Count >= VagasTotais)
        {
            Console.WriteLine($"\nNão há vagas disponíveis para o curso {Nome}.");
            return false;
        }
        if (matriculas.Any(e => e.Nome == estudante.Nome))
        {
            Console.WriteLine($"\nO estudante {estudante.Nome} já está matriculado no curso {Nome}.");
            return false;
        }
        matriculas.Add(estudante);
        Console.WriteLine($"\nEstudante {estudante.Nome} matriculado com sucesso no curso {Nome}.");
        return true;
    }
    public void ListarMatriculados()
    {
        Console.WriteLine($"\nEstudantes matriculados no curso {Nome}:");
        foreach (Estudante estudante in matriculas)
        {
            Console.WriteLine($"Nome: {estudante.Nome}, Nota 1: {estudante.Nota1}, Nota 2: {estudante.Nota2}, Média: {estudante.Media}, Situação: {estudante.Situacao}");
        }
    }
}
