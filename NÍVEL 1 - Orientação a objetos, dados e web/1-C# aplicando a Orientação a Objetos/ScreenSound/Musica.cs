using ScreenSound;

class Musica
    //No C#, um atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância
    //específica desta classe e uma propriedade é uma abstração que fornece um meio de acessar e
    //modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita.
{
    public string NomeDaMusica { get; set; }
    public Artista Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public void ExibirDisponibilidade()
    {
        if (Disponivel)
        {
            Console.WriteLine("\nDisponível no plano.");
        }
        else
        {
            Console.WriteLine("\nAdquira o plano Plus+");
        }
    }
    public Genero Genero { get; set; } = new();


    /*
     * public void EscreveDisponivel(bool valor)
    //{ disponivel = valor; }
    //public bool LeDisponivel()
    //{ return disponivel; }
    public string DescricaoResumida => $"Banda: {this.Artista}... {this.NomeDaMusica} é do artista {this.Artista} e tem duração de {this.Duracao} segundos.";
    public void ExibirDetalhesDoAlbum()
    {
        Console.WriteLine($"\nNome: {this.NomeDaMusica}");
        Console.WriteLine($"Artista: {this.Artista}");
        Console.WriteLine($"Gênero: {this.Genero.NomeGenero}");
        Console.WriteLine($"Duração: {this.Duracao}");
        if (this.Disponivel)
        {
            Console.WriteLine("\nDisponível no plano.");
        }
        else
        {
            Console.WriteLine("\nAdquira o plano Plus+");
        }
    }
    */
    }