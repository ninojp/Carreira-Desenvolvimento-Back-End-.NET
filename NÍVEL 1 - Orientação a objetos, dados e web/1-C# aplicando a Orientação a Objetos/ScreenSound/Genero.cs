namespace ScreenSound;

internal class Genero
{
    public Genero(string nomeGenero)
    {
        this.NomeGenero = nomeGenero;
    }

    private string nomeGenero = string.Empty;
    public string NomeGenero
    {
        get => nomeGenero;
        set => nomeGenero = value;
    }
}
