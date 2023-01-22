namespace FactoryMethodDesignPattern;

public class MoneyBack : ICreditCard
{
    public int GetAnnualCharge() => 500;
    public string GetCardType() => "Money Back";
    public int GetCreditLimit() => 150000;
}
