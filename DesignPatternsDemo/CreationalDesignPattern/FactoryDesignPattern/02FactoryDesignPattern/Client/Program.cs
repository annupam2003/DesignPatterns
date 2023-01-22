using FactoryDesignPattern;

public class Program
{
    static void Main(string[] args)
    {
        ICreditCard cardDetails = CreditCardFactory.GetCreditCard("MoneyBack");
        if (cardDetails != null)
        {
            Console.WriteLine("CardType : " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
    }
}
