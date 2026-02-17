class Musica
    //No C#, um atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância
    //específica desta classe e uma propriedade é uma abstração que fornece um meio de acessar e
    //modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita.
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} é do artista {Artista} e tem duração de {Duracao} segundos.";
    //public string DescricaoResumida { 
    //    get { return $"A musica {Nome} é do artista {Artista} e tem duração de {Duracao} segundos."; }
    //}
    //public void EscreveDisponivel(bool valor)
    //{ disponivel = valor; }
    //public bool LeDisponivel()
    //{ return disponivel; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}