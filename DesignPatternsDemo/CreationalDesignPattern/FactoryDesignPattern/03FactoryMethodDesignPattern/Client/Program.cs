using FactoryMethodDesignPattern;

namespace Client;
public class Program
{
    static void Main(string[] args) 
    {
        ICreditCard creditCard = new TitaniumFactory().CreateProduct();
        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
    }
}