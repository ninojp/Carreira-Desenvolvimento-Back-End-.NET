namespace PraticandoOOHeranca;

internal class SensorTemperatura : ISensor
{
    private bool ativo;
    public void Ativar()
    {
        ativo = true;
        Console.WriteLine("Sensor de temperatura ativado.");
    }
    public void Desativar()
    {
        ativo = false;
        Console.WriteLine("Sensor de temperatura desativado.");
    }
    public double LerTemperatura()
    {
        if (!ativo)
        {
            Console.WriteLine("O sensor de temperatura está desativado. Ative-o para ler a temperatura.");
            return double.NaN; // Retorna Not-a-Number para indicar que a leitura não é válida
        }
        // Simula a leitura da temperatura (pode ser substituído por uma leitura real de hardware)
        Random random = new Random();
        double temperatura = 15 + random.NextDouble() * 10; // Gera uma temperatura entre 15 e 25 graus Celsius
        Console.WriteLine($"Temperatura atual: {temperatura:F2} °C");
        return temperatura;
    }
}
