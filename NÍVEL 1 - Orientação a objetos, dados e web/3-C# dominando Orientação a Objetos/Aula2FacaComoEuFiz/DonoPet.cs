namespace Aula2FacaComoEuFiz;

internal class DonoPet
{
    public List<Pet> ListaPetsDono = [];
    public string NomeDono {  get; }
    public string EnderecoDono { get; set; }
    public int TelefoneDono { get; set; }
    public DonoPet(string nomeDono, string enderecoDono, int telefoneDono)
    {
        NomeDono = nomeDono;
        EnderecoDono = enderecoDono;
        TelefoneDono = telefoneDono;
    }
    public void ExibirInformacoesDono()
    {
        Console.WriteLine($"Nome: {NomeDono}");
        Console.WriteLine($"Endereço: {EnderecoDono}");
        Console.WriteLine($"Telefone: {TelefoneDono}");
        if (ListaPetsDono.Count > 0)
        {
            Console.WriteLine("Pets do dono:");
            foreach (var pet in ListaPetsDono)
            {
                pet.ExibirInformacoesPet();
            }
        }
    }
    public void AdicionarPetALista(Pet pet)
    {
        ListaPetsDono.Add(pet);
    }
}
