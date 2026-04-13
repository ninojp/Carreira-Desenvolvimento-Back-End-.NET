namespace PraticandoOOEncaps;

internal class Avaliacao
{
    public string Aluno { get; set; }
    public double Nota { get; private set; }
    public Avaliacao(string aluno)
    {
        Aluno = aluno;
    }
    public string AtribuirNota(double novaNota)
    {
        if (novaNota >= 0 && novaNota <= 10)
        {
            Nota = novaNota;
            return $"Nota de {Aluno} atualizada para {Nota}.";
        }
        else
        {
            return $"Erro: Nota inválida. A nota deve ser entre 0 e 10.";
        }
    }
}