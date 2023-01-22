namespace FactoryMethodDesignPattern;

public class MoneyBackFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct() => new MoneyBack();
}
