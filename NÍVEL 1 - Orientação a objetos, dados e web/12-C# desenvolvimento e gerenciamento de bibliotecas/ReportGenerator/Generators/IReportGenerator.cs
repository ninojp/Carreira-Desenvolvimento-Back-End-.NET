namespace ReportGenerator.Generators;
/// <summary>
/// Interface para geração de relatórios.
/// </summary>
/// <remarks>Implementações desta interface devem fornecer métodos para gerar relatórios a partir de dados de entrada.</remarks>
public interface IReportGenerator
{
    /// <summary>
    /// Gets or sets the input data as a list of dictionaries, where each dictionary represents a set of key-value pairs
    /// for a data record.
    /// </summary>
    List<Dictionary<string, string>> InputDados { get; set; }

    /// <summary>
    /// Gets or sets the title associated with the object.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Gets or sets the headline text associated with the current instance.
    /// </summary>
    string HeadLine { get; set; }

    /// <summary>
    /// Gets or sets the text to display as the footer line.
    /// </summary>
    string FooterLine { get; set; }

    /// <summary>
    /// Gera um relatório formatado com base nos dados atuais.
    /// </summary>
    /// <returns>Uma cadeia de caracteres contendo o endereço do arquivo do relatório gerado. </returns>
    string GerarRelatorio();
}
