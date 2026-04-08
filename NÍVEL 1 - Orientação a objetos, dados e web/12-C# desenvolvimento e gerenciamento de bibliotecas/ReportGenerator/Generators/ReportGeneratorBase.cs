namespace ReportGenerator.Generators;

public abstract class ReportGeneratorBase : IReportGenerator
{
    public List<Dictionary<string, string>> InputDados { get; set; }
    public string Title { get; set; }
    public string HeadLine { get; set; }
    public string FooterLine { get; set; }

    public ReportGeneratorBase(List<Dictionary<string, string>> input)
    {
        InputDados = input;
    }
    public abstract string GerarRelatorio();
}
