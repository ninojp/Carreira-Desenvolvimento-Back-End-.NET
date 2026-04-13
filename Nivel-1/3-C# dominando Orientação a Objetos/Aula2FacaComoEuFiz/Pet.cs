namespace Aula2FacaComoEuFiz;

internal class Pet
{

    public string NomePet { get; }
    public string Especie { get; }
    public int Idade { get; }
    public Pet(string nome, string especie, int idade)
    {
        NomePet = nome;
        Especie = especie;
        Idade = idade;
    }
    public void ExibirInformacoesPet()
    {
        Console.WriteLine($"Nome: {NomePet}");
        Console.WriteLine($"Espécie: {Especie}");
        Console.WriteLine($"Idade: {Idade} anos");
    }
}
