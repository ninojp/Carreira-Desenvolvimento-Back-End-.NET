namespace Aula2FacaComoEuFiz;

internal class Consulta
{
    public DonoPet DonoDoPet { get; }
    public Pet PetAtual { get; }
    public Medico MedicoResponsavel { get; }
    public DateTime DataConsulta { get; } = DateTime.Now;

    public Consulta(DonoPet donoDoPet, Pet petAtual, Medico medicoResponsavel)
    {
        DonoDoPet = donoDoPet;
        PetAtual = petAtual;
        MedicoResponsavel = medicoResponsavel;
    }
    public void ExibirInformacoesConsulta()
    {
        Console.WriteLine($"Data da Consulta: {DataConsulta}");
        DonoDoPet.ExibirInformacoesDono();
        MedicoResponsavel.ExibirInformacoesMedico();
    }
}
