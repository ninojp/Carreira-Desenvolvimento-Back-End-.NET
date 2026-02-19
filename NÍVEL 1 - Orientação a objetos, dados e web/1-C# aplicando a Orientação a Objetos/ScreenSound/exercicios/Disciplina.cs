namespace ScreenSound.exercicios;
//A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
internal class Disciplina
{
    private string nomeDisciplina;
    public string NomeDisciplina
    {
        get => nomeDisciplina;
        set => nomeDisciplina = value;
    }
    //------------------------------------------------
    private List<Aluno> alunos = [];
    public List<Aluno> Alunos
    {
        get => alunos;
        set => alunos = value;
    }
}
//versão do curso.
//class Disciplina
//{
//    public string NomeDisciplina { get; set; }
//    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();
//}