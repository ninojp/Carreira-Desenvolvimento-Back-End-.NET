namespace PraticandoOOHeranca;

internal class Avalicao
{
    public int Nota { get; private set; }
    public string Comentario { get; private set; }

    public Avalicao(int nota, string comentario)
    {
        Nota = nota;
        Comentario = comentario;
    }
}