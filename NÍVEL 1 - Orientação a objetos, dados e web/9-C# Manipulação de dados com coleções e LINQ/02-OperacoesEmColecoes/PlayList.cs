using System.Collections;
namespace _02_OperacoesEmColecoes;

class PlayList : ICollection<Musica>
{
    private readonly HashSet<Musica> hashSetMusicas = [];
    private readonly List<Musica> listaMusicas = [];
    //----------------------------------------------
    public string Nome { get; set; }
    //------------------------------
    public int Count => listaMusicas.Count;
    //-------------------------------------
    public bool IsReadOnly => false;
    //------------------------------
    public void Add(Musica objMusica)
    {
        //verificar se a música já existe na playlist para evitar duplicatas
        //if (listaMusicas.Any(m => m.Titulo.Equals(objMusica.Titulo, StringComparison.OrdinalIgnoreCase) && m.Artista.Equals(objMusica.Artista, StringComparison.OrdinalIgnoreCase)))
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //    Console.WriteLine($"\nA música '{objMusica.Titulo}' do artista '{objMusica.Artista}' já existe na playlist.");
        //    Console.ResetColor();
        //    return;
        //}
        if (hashSetMusicas.Add(objMusica))// se a música foi adicionada com sucesso ao HashSet (retorna True), então adicionamos à lista
        {
            listaMusicas.Add(objMusica);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nA música '{objMusica.Titulo}' do artista '{objMusica.Artista}' já existe na playlist.");
            Console.ResetColor();
        }
    }
    //-----------------
    public void Clear()
    {
        listaMusicas.Clear();
    }
    //-------------------------------------------------
    public Musica? ObterMusicaPeloTitulo(string titulo)
    {
        //return listaMusicas.FirstOrDefault(m => m.Titulo == titulo);
        foreach (var musica in listaMusicas)
        {
            if (musica.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)) return musica;
        }
        return null;
    }
    //-------------------------------------
    public Musica? ObterMusicaAleatoria()
    {
        if (listaMusicas.Count == 0) return null;
        var random = new Random();
        int indexAleatorio = random.Next(0, listaMusicas.Count -1);// para evitar o erro de "ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection."
        return listaMusicas[indexAleatorio];
    }
    //-------------------------------------
    public void OrdenarMusicasPorDuração()
    {
        listaMusicas.Sort((m1, m2) => m1.Duracao.CompareTo(m2.Duracao));
    }
    //-------------------------------------------------------------------
    public void OrdenarMusicasPorTitulo()
    {
        listaMusicas.Sort((m1, m2) => string.Compare(m1.Titulo, m2.Titulo, StringComparison.OrdinalIgnoreCase));
    }
    //-------------------------------
     public void OrdenarMusicasPorArtista()
    {
        listaMusicas.Sort((m1, m2) => string.Compare(m1.Artista, m2.Artista, StringComparison.OrdinalIgnoreCase));
    }
    //-------------------------------------
    public bool Contains(Musica objMusica)
    {
        return listaMusicas.Contains(objMusica);
    }
    //------------------------------------------------
    public void CopyTo(Musica[] array, int arrayIndex)
    {
        listaMusicas.CopyTo(array, arrayIndex);
    }
    //----------------------------------
    public bool Remove(Musica objMusica)
    {
        return listaMusicas.Remove(objMusica);
    }
    //--------------------------------------------------
    public static void ExibirPlayList(PlayList playList)
    {
        Console.WriteLine($"\nExibindo Playlist: {playList.Nome}");
        for (var i = 0; i < playList.Count; i++)
        {
            var musica = playList.ElementAt(i);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Musica {i + 1} - Título: {musica.Titulo}, Artista: {musica.Artista}, Duração: {musica.Duracao} segundos");
            Console.ResetColor();
        }
    }
    //----------------------------------------
    public IEnumerator<Musica> GetEnumerator()
    {
        return listaMusicas.GetEnumerator();
    }
    //-------------------------------------
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
