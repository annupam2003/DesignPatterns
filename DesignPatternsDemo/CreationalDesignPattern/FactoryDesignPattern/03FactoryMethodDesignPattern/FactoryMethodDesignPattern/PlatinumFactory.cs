namespace FactoryMethodDesignPattern;

public class PlatinumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct() => new Platinum();
}
