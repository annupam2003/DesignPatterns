namespace AbstractFactoryDesignPattern;

public abstract class BankingServiceFactory
{
    public abstract IBankingService GetService(string ServiceType);
    public static BankingServiceFactory CreateBankingServiceFactory(string FactoryType) => FactoryType.Equals("CreditCard") ? new CreditCardFactory(): new TakeLoanFactory();
}
