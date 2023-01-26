namespace BuilderDesignPattern;

public interface IReportBuilder
{
    void AddReportType(string reportType);
    void AddReportHeader(string reportHeader);
    void AddReportContant(string reportContant);
    void AddReportFooter(string reportFooter);
    ReportProduct GetReport();
}
