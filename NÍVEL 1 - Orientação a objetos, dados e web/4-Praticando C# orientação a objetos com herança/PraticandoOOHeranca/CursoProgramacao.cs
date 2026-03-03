namespace PraticandoOOHeranca;

internal class CursoProgramacao : ICurso
{
    private string Titulo { get; }
    private Instrutor InstrutorProgramacao { get; }

    public CursoProgramacao(string titulo, Instrutor instrutor)
    {
        InstrutorProgramacao = instrutor;
    }
    public void PublicarCurso()
    {
        Console.WriteLine($"Class CursoProgramacao: Publicando o curso de programação do instrutor {InstrutorProgramacao.Nome}.");
    }

    public void ValidarConteudo()
    {
        Console.WriteLine($"Class CursoProgramacao: instrutor {InstrutorProgramacao.Nome}: Validando conteúdo do curso de programação.");
    }
}
