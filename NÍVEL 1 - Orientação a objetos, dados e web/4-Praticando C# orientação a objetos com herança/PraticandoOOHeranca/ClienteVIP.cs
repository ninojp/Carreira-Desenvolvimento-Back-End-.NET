namespace PraticandoOOHeranca;

internal class ClienteVIP : Pessoa
{
    private string nivelFidelidade;
    private string codigoVIP;

    public ClienteVIP(string nome, int idade, string nivelFidelidade, string codigoVIP) : base(nome, idade)
    {
        this.nivelFidelidade = nivelFidelidade;
        this.codigoVIP = codigoVIP;
    }
    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Sou um cliente VIP com nível de fidelidade {nivelFidelidade} e código VIP {codigoVIP}.");
    }
}