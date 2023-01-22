namespace AbstractFactoryDesignPattern;

public class CreditCardFactory : BankingServiceFactory
{
    public override IBankingService GetService(string ServiceType) => ServiceType.Equals("MoneyBack") ? new MoneyBack() : ServiceType.Equals("Platinum") ? new Platinum() : ServiceType.Equals("Titanium") ? new Titanium() : null;
}
