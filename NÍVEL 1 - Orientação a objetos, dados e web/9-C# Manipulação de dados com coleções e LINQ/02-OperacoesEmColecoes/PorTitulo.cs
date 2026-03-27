namespace _02_OperacoesEmColecoes;

internal class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}