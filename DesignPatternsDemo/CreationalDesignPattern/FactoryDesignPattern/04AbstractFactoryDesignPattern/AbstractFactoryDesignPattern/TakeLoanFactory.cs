namespace AbstractFactoryDesignPattern;

public class TakeLoanFactory : BankingServiceFactory
{
    public override IBankingService GetService(string ServiceType) => ServiceType.Equals("LoanPersonal") ? new LoanPersonal() : ServiceType.Equals("LoanVehical") ? new LoanVehical() : null;
}