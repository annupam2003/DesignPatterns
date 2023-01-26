using BuilderDesignPattern;

namespace Client;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======< IReportBuilder Design Pattern >========");
        IReportBuilder builder = new ExcelReportConcreteBuilder();
        GenrateReportDirector genrateReport = new GenrateReportDirector();
        var report = genrateReport.GenrateExcelReport(new ExcelReportConcreteBuilder());
        Console.WriteLine($"{report.ReportType}\n{report.ReportHeader}\n{report.ReportContant}\n{report.ReportFooter}");
    }
}