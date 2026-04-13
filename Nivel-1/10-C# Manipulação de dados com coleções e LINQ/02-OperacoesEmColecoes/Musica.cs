namespace _02_OperacoesEmColecoes;
internal class Musica : IComparable<Musica>
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    // lógica criada como demonstração, mas Eu não utilizei ela no código, pois a comparação foi feita utilizando o método de extensão OrderBy
    public int CompareTo(Musica? other)
    {
        if (other == null) return -1;
        if (other is Musica outraMusica) return this.Duracao.CompareTo(outraMusica.Duracao);
        return -1;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (obj is Musica outraMusica)
        {
            return this.Titulo.Equals(outraMusica.Titulo, StringComparison.OrdinalIgnoreCase) &&
                   this.Artista.Equals(outraMusica.Artista, StringComparison.OrdinalIgnoreCase) &&
                   this.Duracao == outraMusica.Duracao;
        }
        return false;
    }
    public override int GetHashCode()
    {
        //Aqui usamos o operador XOR (^) para combinar os hash codes das propriedades, garantindo que a ordem das propriedades não afete o resultado final do hash code.
        return this.Titulo.ToLower().GetHashCode() ^ this.Artista.ToLower().GetHashCode() ^ this.Duracao.GetHashCode();
        //return HashCode.Combine(Titulo.ToLower(), Artista.ToLower(), Duracao);
    }
}
