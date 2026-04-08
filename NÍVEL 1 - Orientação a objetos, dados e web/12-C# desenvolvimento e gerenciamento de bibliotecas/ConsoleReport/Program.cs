using ReportGenerator.Generators;

List<Dictionary<string, string>> data = new()
{
    new Dictionary<string, string>
    {
        { "Nome", "Alice" },
        { "Idade", "30" },
        { "Cidade", "São Paulo" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Roberto" },
        { "Idade", "25" },
        { "Cidade", "Salvador" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Carlos" },
        { "Idade", "35" },
        { "Cidade", "Rio de Janeiro" }
    }
};

//CSVReporterGenerator reportGenerator = new(data);
//reportGenerator.Title = "Relatório de Pessoas";
//reportGenerator.HeadLine = "Lista de pessoas cadastrados no sistema";
//reportGenerator.FooterLine = $"Total de pessoas: {data.Count}";

//string caminhoRelatorio = reportGenerator.GerarRelatorio();
//Console.WriteLine($"Relatório em CSV gerado em: {caminhoRelatorio}");

PDFReportGenerator pdfReportGenerator = new(data);
pdfReportGenerator.Title = "Relatório de Pessoas";
pdfReportGenerator.HeadLine = "Lista de pessoas cadastrados no sistema";
pdfReportGenerator.FooterLine = $"Total de pessoas: {data.Count}";

string caminhoRelatorioPDF = pdfReportGenerator.GerarRelatorio();
Console.WriteLine($"Relatório em PDF gerado em: {caminhoRelatorioPDF}");