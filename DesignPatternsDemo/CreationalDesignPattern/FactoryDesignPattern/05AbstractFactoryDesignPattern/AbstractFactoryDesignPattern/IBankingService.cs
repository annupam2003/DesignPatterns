namespace AbstractFactoryDesignPattern;

public interface IBankingService
{
    string GetService();
    int MaxLimit();
    int Charges();
}
public class MoneyBack : IBankingService
{
    public string GetService() => "Money Back";
    public int MaxLimit() => 150000;
    public int Charges() => 500;
}
public class Platinum : IBankingService
{
    public string GetService() => "Platinum";
    public int MaxLimit() => 250000;
    public int Charges() => 1500;
}
public class Titanium : IBankingService
{
    public string GetService() => "Titanium";
    public int MaxLimit() => 350000;
    public int Charges() => 2500;
}

public class Personal : IBankingService
{
    public string GetService() => "Personal";
    public int MaxLimit() => 50000;
    public int Charges() => 1200;
}
public class Vehical : IBankingService
{
    public string GetService() => "Vehical";
    public int MaxLimit() => 750000;
    public int Charges() => 1600;
}

public abstract class BankingServiceFactory
{
    protected abstract IBankingService MakeProduct();
    public IBankingService CreateProduct() => this.MakeProduct();
}

public class MoneyBackFactory : BankingServiceFactory
{
    protected override IBankingService MakeProduct() => new MoneyBack();
}
public class PlatinumFactory : BankingServiceFactory
{
    protected override IBankingService MakeProduct() => new Platinum();
}
public class TitaniumFactory : BankingServiceFactory
{
    protected override IBankingService MakeProduct() => new Titanium();
}
public class PersonalFactory : BankingServiceFactory
{
    protected override IBankingService MakeProduct() => new Personal();
}
public class VehicalFactory : BankingServiceFactory
{
    protected override IBankingService MakeProduct() => new Vehical();
}

public abstract class BankingMoneyServiceFactory
{
    public abstract IBankingService GetService(string ServiceType);
    public static BankingMoneyServiceFactory CreateBankingServiceFactory(string FactoryType) => FactoryType.Equals("CreditCard") ? new CreditCardBankingService() : FactoryType.Equals("Loan") ? new TakeLoanFactory(): null;
}

public class CreditCardBankingService : BankingMoneyServiceFactory
{
    public override string ToString() => "Credit Card Banking Service";
    public override IBankingService GetService(string ServiceType) => ServiceType.Equals("MoneyBack") ? new MoneyBackFactory().CreateProduct() : ServiceType.Equals("Platinum") ? new PlatinumFactory().CreateProduct() : ServiceType.Equals("Titanium") ? new TitaniumFactory().CreateProduct() : null;
}
public class TakeLoanFactory : BankingMoneyServiceFactory
{
    public override string ToString() => "Loan Banking Service";
    public override IBankingService GetService(string ServiceType) => ServiceType.Equals("Personal") ? new PersonalFactory().CreateProduct() : ServiceType.Equals("Vehical") ? new VehicalFactory().CreateProduct()  : null;
}