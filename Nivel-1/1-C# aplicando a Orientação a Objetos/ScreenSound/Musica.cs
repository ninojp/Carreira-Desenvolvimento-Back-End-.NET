using ScreenSound;

class Musica
//Atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância específica desta classe
//Propriedade é uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita.
{
    public Musica(string nomeDaMusica, Artista artista, int duracao, bool disponivel)
    {
        NomeDaMusica = nomeDaMusica;
        Artista = artista;
        Duracao = duracao;
        Disponivel = disponivel;
    }
    public string NomeDaMusica { get; }
    public Artista Artista { get; }
    public int Duracao { get; }
    private bool disponivel;
    private bool Disponivel
    {
        get => disponivel;
        set => disponivel = value;
    }
    public string ExibirDisponibilidade()
    {
        if (Disponivel)
        {
            return "Disponível no plano.";
        }
        else
        {
            return "Adquira o plano Plus++";
        }
    }
}