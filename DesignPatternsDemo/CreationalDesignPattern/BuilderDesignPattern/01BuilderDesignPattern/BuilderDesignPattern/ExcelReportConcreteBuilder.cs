using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern;

public class ExcelReportConcreteBuilder : IReportBuilder
{
    ReportProduct reportProduct = new ReportProduct();
    public void AddReportContant(string reportContant) => reportProduct.ReportContant = reportContant;
    public void AddReportFooter(string reportFooter) => reportProduct.ReportFooter = reportFooter;
    public void AddReportHeader(string reportHeader) => reportProduct.ReportHeader = reportHeader;
    public void AddReportType(string reportType) => reportProduct.ReportType = reportType;
    public ReportProduct GetReport() => reportProduct;
}
