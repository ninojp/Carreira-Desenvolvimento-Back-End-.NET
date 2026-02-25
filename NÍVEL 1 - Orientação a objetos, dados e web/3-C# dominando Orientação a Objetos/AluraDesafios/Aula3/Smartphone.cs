namespace AluraDesafios.Aula3;

internal class Smartphone : ProdutoEletronico
{
    private string marca;
    private string modelo;
    private string sistemaOperacional;

    public Smartphone(string marca, string modelo, string sistemaOperacional)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.sistemaOperacional = sistemaOperacional;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Smartphone - Marca: {marca}, Modelo: {modelo}, Sistema Operacional: {sistemaOperacional}");
    }
}