public class ReportGenerator
{
    private readonly Report _report;

    public ReportGenerator(Report report)
    {
        _report = report;
    }

    public void GenerateReport(string data)
    {
        _report.Generate(data);
    }
}
