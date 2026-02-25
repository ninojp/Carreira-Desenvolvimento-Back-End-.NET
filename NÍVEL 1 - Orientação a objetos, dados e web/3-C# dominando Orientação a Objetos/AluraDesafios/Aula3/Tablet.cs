namespace AluraDesafios.Aula3;

internal class Tablet : ProdutoEletronico
{
    private string marca;
    private string modelo;
    private string sistemaOperacional;
    public Tablet(string marca, string modelo, string sistemaOperacional)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.sistemaOperacional = sistemaOperacional;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Tablet - Marca: {marca}, Modelo: {modelo}, Sistema Operacional: {sistemaOperacional}");
    }
}
