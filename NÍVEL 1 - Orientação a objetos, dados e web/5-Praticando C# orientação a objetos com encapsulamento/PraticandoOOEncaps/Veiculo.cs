namespace PraticandoOOEncaps;

internal class Veiculo
{
    private double velocidadeAtual;
    public string Placa { get; set; }

    public Veiculo(string placa)
    {
        Placa = placa;
    }
    public double VelocidadeAtual => velocidadeAtual;
    public void AtualizarVelocidade(double novaVelocidade)
    {
        if (novaVelocidade >= 0)
            velocidadeAtual = novaVelocidade;
    }
}
