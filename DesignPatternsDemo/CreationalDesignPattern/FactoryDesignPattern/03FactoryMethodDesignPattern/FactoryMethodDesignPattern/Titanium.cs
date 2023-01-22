namespace FactoryMethodDesignPattern;

public class Titanium : ICreditCard
{
    public int GetAnnualCharge() => 1500;
    public string GetCardType() => "Titanium Edge";
    public int GetCreditLimit() => 250000;
}