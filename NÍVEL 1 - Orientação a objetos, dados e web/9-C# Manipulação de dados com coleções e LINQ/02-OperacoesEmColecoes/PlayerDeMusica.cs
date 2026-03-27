namespace _02_OperacoesEmColecoes;

internal class PlayerDeMusica
{
    //private List<Musica> filaDeReproducao = new();
    private readonly Queue<Musica> filaDeReproducao = new(); // FIFO - First In, First Out (Fila: Primeiro a entrar, primeiro a sair)
    private readonly Stack<Musica> pilhaDeReproducao = new();// LIFO - Last In, First Out (Pilha: Último a entrar, primeiro a sair)
    public void AdicionarNaFila(Musica musica)
    {
        filaDeReproducao.Enqueue(musica);
    }
    //----------------------------------------------
    public void AdicionarNaFila(PlayList playList)
    {
        foreach (var musica in playList)
        {
            AdicionarNaFila(musica);
        }
    }
    //--------------------------------
    public Musica? ProximaMusicaDaFila()
    {
        if (filaDeReproducao.Count == 0) return null;
        //var proximaMusica = filaDeReproducao[0];
        //filaDeReproducao.Remove(proximaMusica);
        var proximaMusica = filaDeReproducao.Dequeue();
        pilhaDeReproducao.Push(proximaMusica);
        return proximaMusica;
    }
    //--------------------------------
    public Musica? MusicaAnterior()
    {
        if (pilhaDeReproducao.Count == 0) return null;
        var musicaAnterior = pilhaDeReproducao.Pop();
        //filaDeReproducao.Enqueue(musicaAnterior);
        return musicaAnterior;
    }
    //--------------------------------
    public IEnumerable<Musica> Fila()
    {
        foreach (var musica in filaDeReproducao)
        {
            yield return musica;
        }
    }
    //-------------------------------
    public IEnumerable<Musica> Historico()
    {
        foreach (var musica in pilhaDeReproducao)
        {
            yield return musica;
        }
    }
}
