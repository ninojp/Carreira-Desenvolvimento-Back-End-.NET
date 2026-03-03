namespace PraticandoOOHeranca;

internal class CursoDesign : ICurso
{
    private string Titulo { get; }
    //Composição, usando a classe Instrutor como parte do curso de design
    private Instrutor InstrutorDesign { get; }
    public CursoDesign(string titulo,Instrutor instrutor)
    {
        InstrutorDesign = instrutor;
    }
    public void PublicarCurso()
    {
        Console.WriteLine($"Publicando o curso de design do instrutor {InstrutorDesign.Nome}.");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"instrutor {InstrutorDesign.Nome}: Validando conteúdo do curso de design.");
    }
}
