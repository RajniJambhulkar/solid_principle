public class Program
{
    public static void Main()
    {
        // Using PdfReport
        Report pdfReport = new PdfReport();
        ReportGenerator pdfReportGenerator = new ReportGenerator(pdfReport);
        pdfReportGenerator.GenerateReport("Report data for PDF");

        // Using ExcelReport
        Report excelReport = new ExcelReport();
        ReportGenerator excelReportGenerator = new ReportGenerator(excelReport);
        excelReportGenerator.GenerateReport("Report data for Excel");

       
    }
}
