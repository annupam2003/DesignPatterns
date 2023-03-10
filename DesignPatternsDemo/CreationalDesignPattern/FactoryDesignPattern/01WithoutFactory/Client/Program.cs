using WithoutFactory;

namespace Client;
public class Program
{
    static void Main(string[] args)
    {
        string cardType = "MoneyBack";
        ICreditCard cardDetails = null;

        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platinum();
        }
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
