namespace ScreenSoundAPI;

using ReportGenerator.Generators;

internal class CSVGenerator : CSVReporterGenerator
{
    public CSVGenerator(List<Dictionary<string, string>> inputData) : base(inputData)
    {
    }
    public string GerarRelatorio(string fileName)
    {
        GerarRelatorio();
        File.Move("relatorio.csv", fileName);
        Console.WriteLine($"Arquivo Renomeado para {fileName}");
        return Path.GetFullPath(fileName);
    }
}
