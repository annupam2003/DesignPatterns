namespace WithoutFactory;

public class Platinum : ICreditCard
{
    public int GetAnnualCharge() => 2500;
    public string GetCardType() => "Platinum Plus";
    public int GetCreditLimit() => 350000;
}
