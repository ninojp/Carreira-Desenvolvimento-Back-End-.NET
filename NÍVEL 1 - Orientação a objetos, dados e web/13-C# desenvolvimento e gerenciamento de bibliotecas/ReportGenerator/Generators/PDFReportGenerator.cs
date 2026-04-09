using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;


namespace ReportGenerator.Generators;

public class PDFReportGenerator : ReportGeneratorBase
{
    public PDFReportGenerator(List<Dictionary<string, string>> input) : base(input){ }

    /// <summary>
    /// Gera um relatório em formato PDF utilizando a biblioteca iText7. O método verifica se os dados de entrada são válidos, cria um documento PDF, adiciona o título, a manchete, os dados em formato de tabela e o rodapé, e salva o arquivo como "relatorioPDF.pdf". Retorna o caminho completo do arquivo gerado.
    /// </summary>
    /// <returns>Retorna o caminho completo do arquivo PDF gerado.</returns>
    /// <exception cref="Exception">Lançada quando os dados de entrada são inválidos.</exception>
    public override string GerarRelatorio()
    {
        if (InputDados == null || InputDados.Count == 0) throw new Exception("Input de Dados Inválido!");

        using var writer = new PdfWriter("relatorioPDF.pdf");
        using var pdf = new PdfDocument(writer);
        using var document = new Document(pdf);

        if (!string.IsNullOrWhiteSpace(Title))
        {
            var title = new Paragraph(Title)
                .SetFontSize(20)
                .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                .SetTextAlignment(TextAlignment.CENTER);
            document.Add(title);
        }

        if (!string.IsNullOrWhiteSpace(HeadLine))
        {
            var headLine = new Paragraph(HeadLine)
                .SetFontSize(16)
                .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                .SetMarginBottom(10);
            document.Add(headLine);
        }

        Table table = new Table(InputDados.First().Keys.Count);
        foreach (var header in InputDados.First().Keys)
        {
            table.AddHeaderCell(new Cell().Add(new Paragraph(header).SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))));
        }

        foreach (var item in InputDados)
        {
            foreach (var value in item.Values)
            {
                table.AddCell(new Cell().Add(new Paragraph(value)));
            }
        }        
        document.Add(table);

        if (!string.IsNullOrWhiteSpace(FooterLine))
        {
            var footer = new Paragraph(FooterLine)
                .SetFontSize(12)
                .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetMarginTop(10);
            document.Add(footer);
        }

        return Path.GetFullPath("relatorioPDF.pdf");
    }
}
