using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern;

public class GenrateReportDirector
{
    public ReportProduct GenrateExcelReport(IReportBuilder reportBuilder)
    {
        reportBuilder.AddReportType("Excel Report");
        reportBuilder.AddReportHeader("Excel Header");
        reportBuilder.AddReportContant("Excel Contant");
        reportBuilder.AddReportFooter("Excel Footer");
        return reportBuilder.GetReport();
    }
    public ReportProduct GenratePdfReport(IReportBuilder reportBuilder)
    {
        reportBuilder.AddReportType("PDF Report");
        reportBuilder.AddReportHeader("PDF Header");
        reportBuilder.AddReportContant("PDF Contant");
        reportBuilder.AddReportFooter("PDF Footer");
        return reportBuilder.GetReport();
    }
}
