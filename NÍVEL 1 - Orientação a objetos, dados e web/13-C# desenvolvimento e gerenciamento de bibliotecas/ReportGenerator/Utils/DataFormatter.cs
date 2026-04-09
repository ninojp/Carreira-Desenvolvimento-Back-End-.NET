namespace ReportGenerator.Utils;

internal class DataFormatter : IDataFormatter
{
    public string FormatData(string input)
    {
        if (DateTime.TryParse(input, out DateTime date))
        {
            return date.ToString("dd/MM/yyyy");
        }
        return input;
    }
}
