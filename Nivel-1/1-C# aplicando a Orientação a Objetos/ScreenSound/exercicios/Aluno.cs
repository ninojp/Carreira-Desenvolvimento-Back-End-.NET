namespace ScreenSound.exercicios;
//A classe Aluno deve ter informações como nome, idade e notas.
internal class Aluno
{
    private string nomeAluno;
    public string NomeAluno
    {
        get => nomeAluno;
        set => nomeAluno = value;
    }
    //-----------------------------------
    private int anoNascimento;
    public int AnoNascimento
    {
        get => anoNascimento;
        set => anoNascimento = value;

    }
    //----------------------------------------
    private List<double> notasAlunos = [];
    public List<double> NotasAlunos
        {
        get => notasAlunos;
        set => notasAlunos = value;
    }
}
//versão do curso.
//class Aluno
//{
//    public string Nome { get; set; }
//    public int Idade { get; set; }
//    public List<double> Notas { get; set; } = new List<double>();
//}