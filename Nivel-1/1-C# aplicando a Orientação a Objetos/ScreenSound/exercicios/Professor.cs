namespace ScreenSound.exercicios;
//A classe Professor deve ter informações sobre nome e disciplinas lecionadas.
internal class Professor
{
    private string nomeProfessor;
    public string NomeProfessor
    {
        get => nomeProfessor;
        set => nomeProfessor = value;

    }
    //------------------------------------------------
    private List<string> disciplinasProfessor = [];
    public List<string> DisciplinasProfessor
    {
        get => disciplinasProfessor;
        set => disciplinasProfessor = value;

    }
}
//versão do curso.
//class Professor
//{
//    public string Nome { get; set; }
//    public List<string> DisciplinasLecionadas { get; set; } = new List<string>();
//}