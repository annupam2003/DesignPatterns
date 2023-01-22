namespace FactoryMethodDesignPattern;

public class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct() => new Titanium();
}