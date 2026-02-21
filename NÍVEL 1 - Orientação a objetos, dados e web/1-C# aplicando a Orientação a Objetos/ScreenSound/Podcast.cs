namespace ScreenSound;

internal class Podcast
{
    //retirei o set do Host e do Nome, pois não faz sentido alterar o nome do podcast ou o host depois de criado.
    private List<Episodio> listaEpisodios = [];
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => listaEpisodios.Count;
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public void AdicionaEpisodios(Episodio episodio)
    {
        //Console.WriteLine("\nDigite todos os dados para adicionar um novo episódio.");
        //Console.WriteLine("Digite o Titulo do episódio");
        //string tituloEp = Console.ReadLine();
        //Console.WriteLine("Digite a Duração do episódio");
        //int duracaoEp = int.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a Ordem do episódio");
        //int ordemEp = int.Parse(Console.ReadLine());
        //Episodio novoEpisodio = new(string tituloEp, int duracaoEp, int ordemEp);
        //listaEpisodiosOrdenados.Add(Episodio novoEpisodio);
        //Console.WriteLine($"\nTodos os dados, {tituloEp} - {duracaoEp} - {ordemEp}, foram adicionados com sucesso!");
        listaEpisodios.Add(episodio);
    }
    //O método ExibirDetalhes() deve mostrar o nome do podcast e o host na primeira linha,
    //seguido pela lista de episódios ordenados por sequência e por fim o total de episódios.
    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nPodcast {Nome} Apresentado por {Host}");
        //Oredenar o resultado da lista de episódios por ordem de sequência, utilizando o método OrderBy() da classe List.
        listaEpisodios.OrderBy(episodio => episodio.Ordem).ToList().ForEach(episodio => Console.WriteLine(episodio.Resumo));
        Console.WriteLine($"Este Podcast {Nome} possui um total de {TotalEpisodios} episódios.\n");
    }
}
