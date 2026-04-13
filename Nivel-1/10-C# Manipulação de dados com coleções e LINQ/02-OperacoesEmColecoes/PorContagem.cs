namespace _02_OperacoesEmColecoes;

internal class PorContagem : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}
