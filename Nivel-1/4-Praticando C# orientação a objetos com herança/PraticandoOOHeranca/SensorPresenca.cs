namespace PraticandoOOHeranca;

internal class SensorPresenca : ISensor
{
    private bool ativo;
    public void Ativar()
    {
        ativo = true;
        Console.WriteLine("Sensor de presença ativado.");
    }
    public void Desativar()
    {
        ativo = false;
        Console.WriteLine("Sensor de presença desativado.");
    }
    public bool DetectarPresenca()
    {
        if (!ativo)
        {
            Console.WriteLine("O sensor de presença está desativado. Ative-o para detectar presença.");
            return false; // Retorna false para indicar que a detecção não é válida
        }
        // Simula a detecção de presença (pode ser substituído por uma leitura real de hardware)
        Random random = new Random();
        bool presencaDetectada = random.Next(0, 2) == 1; // Gera um valor booleano aleatório
        Console.WriteLine(presencaDetectada ? "Presença detectada!" : "Nenhuma presença detectada.");
        return presencaDetectada;
    }
}
