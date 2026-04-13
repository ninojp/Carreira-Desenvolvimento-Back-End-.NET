using ReportGenerator.Utils;
using System.Text;

namespace ReportGenerator.Generators;

public class CSVReporterGenerator : ReportGeneratorBase
{
    public CSVReporterGenerator(List<Dictionary<string, string>> input) : base(input){ }
    public override string GerarRelatorio()
    {
        if (InputDados == null || InputDados.Count == 0) throw new Exception("Input de Dados Inválido!");
        StringBuilder relatorio = new();

        if (string.IsNullOrWhiteSpace(Title))
        {
            relatorio.AppendLine(Title);
            relatorio.AppendLine("");
        }
        if (!string.IsNullOrWhiteSpace(HeadLine))
        {
            relatorio.AppendLine(HeadLine);
            relatorio.AppendLine("");
        }
        string header = string.Join(',', InputDados.First().Keys);
        relatorio.AppendLine(header);

        foreach (var item in InputDados)
        {
            string bodyLine = string.Join(',', item.Values);
            relatorio.AppendLine(bodyLine);
        }
        if (!string.IsNullOrWhiteSpace(FooterLine))
        {
            relatorio.AppendLine(FooterLine);
            relatorio.AppendLine("");
        }

        DataFormatter dataFormatter = new DataFormatter();
        relatorio.Append(dataFormatter.FormatData(DateTime.Now.ToString()));

        File.WriteAllText("relatorio.csv", relatorio.ToString(), Encoding.UTF8);

        return Path.GetFullPath("relatorio.csv");
    }
}
/* Modificadores de Acesso:
 * 
 * public: A classe ou membro é acessível de qualquer lugar.
 * internal: A classe ou membro é acessível apenas dentro do mesmo assembly (projeto).
 * protected: A classe ou membro é acessível dentro da própria classe e em classes derivadas.
 * private: A classe ou membro é acessível apenas dentro da própria classe.
 * sealed → impede que uma classe seja herdada, garantindo estabilidade.
 * Protected / virtual: Permite que um método seja sobrescrito em classes derivadas, promovendo flexibilidade. 
 * protected internal: A classe ou membro é acessível dentro do mesmo assembly e em classes derivadas, mesmo que estejam em outro assembly.
 * private protected: A classe ou membro é acessível apenas dentro da própria classe e em classes derivadas que estejam no mesmo assembly.
 */